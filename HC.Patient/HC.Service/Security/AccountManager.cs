using HC.Common.CommonData;
using HC.Common.Enums;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Entity;
using HC.Patient.Model.User;
using HC.Patient.Service.Security.Interfaces;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using HC.Service;

namespace HC.Patient.Service.Security
{
    public class AccountManager : BaseService, IAccountManager
    {
        #region Global Variables
        private readonly ISecUserRepository _secUserRepository;
        bool _isPIN = false;
        bool _isOldPIN = false;
        #endregion

        public AccountManager(ISecUserRepository secUserRepository)
        {
            this._secUserRepository = secUserRepository;
        }

        #region private members

        private const int PASSWORD_REHASH_TIMES = 256000;
        private const int PIN_HASH_TIMES = 1;

        private SecUser _user;

        #endregion private members

        #region public methods

        public UserActivityReason ValidateUser(LoginCredential credential, SecUser secUser = null)
        {
            UserActivityReason activityReason = new UserActivityReason();
            activityReason.ReturnFlag = false;
            activityReason.Message = UserAccountNotification.EmailNotFound;
            try
            {
                _user = secUser ?? GetUserByEmail(credential.Email.Trim());
                if (_user != null)
                {
                    activityReason = ValidatePassword(credential, activityReason);
                    if (activityReason.ReturnFlag == true)
                    {
                        activityReason.UserId = _user.SecUserID;
                        //activityReason.UserTypeId = _user.SecUserTypeID;
                    }
                }
                return activityReason;
            }
            catch (Exception) { throw; }
        }
        public StatusEnum.ChangePasswordStatus ChangePassword(LoginCredential credential, SecUser secUser = null)
        {
            StatusEnum.ChangePasswordStatus status = StatusEnum.ChangePasswordStatus.InvalidOldPassword;
            try
            {
                _user = secUser ?? GetUserByEmail(credential.Email.ToLower());
                if (_user != null)
                {
                    _isPIN = credential.IsPIN;
                    _isOldPIN = credential.IsOldPIN;
                    status = ValidatePasswordForChange(credential);
                }
                return status;
            }
            catch (Exception) { throw; }
        }
        public UserActivityReason ValidatePassword(LoginCredential credentials, UserActivityReason activityReason)
        {
            UserActivityReason activityReasonNew = new UserActivityReason();
            if (activityReason != null)
            {
                activityReasonNew = activityReason;
            }
            if (!_user.IsActive)
            {
                activityReasonNew.Message = UserAccountNotification.AccountDeactiveOrExpirePass;
                activityReasonNew.ReturnFlag = false;
                return activityReasonNew;
            }
            activityReasonNew = credentials.IsPIN != true ? ValidatePrimaryPassword(credentials.Password.Trim(), activityReasonNew) : ValidatePINPassword(credentials.PIN, activityReasonNew);
            _secUserRepository.Update(_user);
            _secUserRepository.SaveChanges();
            return activityReasonNew;
        }
        public void SaveNewPrimaryPassword(string newPassword, Guid? newSalt = null, string email = "")
        {
            _user = new SecUser();
            if (newSalt == null)
                newSalt = Guid.NewGuid();
            byte[] computedPassword = ComputePasswordHash(newPassword, newSalt.Value, PASSWORD_REHASH_TIMES);
            _user.ID = Guid.NewGuid();
            _user.SecUserID = Guid.NewGuid();
            _user.Email = email;
            _user.PasswordHash256 = computedPassword;
            _user.PasswordSalt = newSalt.Value;
            _user.CreatedDate = DateTime.UtcNow;
            _user.IsActive = true;
            _user.IsDeleted = false;
            _user.ModifiedDate = null;
            _secUserRepository.Create(_user);
            _secUserRepository.SaveChanges();
        }
        public StatusEnum.ChangePasswordStatus ValidatePasswordForChange(LoginCredential credential)
        {
            StatusEnum.ChangePasswordStatus status = StatusEnum.ChangePasswordStatus.Success;
            if (!_user.IsActive)
            {
                status = StatusEnum.ChangePasswordStatus.AccountDeactivated;
                return status;
            }
            status = _isOldPIN != true ? ValidatePrimaryPasswordForChange(credential.OldPassword) : ValidatePINPasswordForChange(credential.OldPIN);
            if (status != StatusEnum.ChangePasswordStatus.Success)
            {
                status = StatusEnum.ChangePasswordStatus.InvalidOldPassword;
                return status;
            }
            return status;
        }
        public SecUser GetUserByEmail(string email)
        {
            return _secUserRepository.GetFirstOrDefault(x => x.Email == email && x.IsDeleted == false);
        }
        #endregion public methods

        #region protected methods

        protected static byte[] ComputePasswordHash(string password, Guid passwordSalt, int rehashTimes)
        {
            using (var sha = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF32.GetBytes(password);
                byte[] hashOutput = sha.ComputeHash(passwordBytes);
                byte[] saltBytes = passwordSalt.ToByteArray();
                var hashInput = new byte[48];
                for (int i = 0; i < rehashTimes; i++) //256000 times to delay the process upto ~1second
                {
                    Buffer.BlockCopy(hashOutput, 0, hashInput, 0, hashOutput.Length);
                    Buffer.BlockCopy(saltBytes, 0, hashInput, hashOutput.Length, saltBytes.Length);

                    hashOutput = sha.ComputeHash(hashInput);
                }
                return hashOutput;
            }
        }


        protected static bool IsPasswordEqual(byte[] storePassword, byte[] providedPassword)
        {
            if ((storePassword != null) && (providedPassword != null))
            {
                if (storePassword.Length != providedPassword.Length)
                    return false;

                return !storePassword.Where((t, i) => t != providedPassword[i]).Any();
            }
            return false;
        }

        protected static string ShuffleCharacters(string password)
        {
            var random = new Random();

            char[] passwordChars = password.ToCharArray();
            passwordChars.OrderBy(c => random.Next()); //shuffles the chars

            return new string(passwordChars);
        }

        protected static Guid GenerateTemporarySalt()
        {
            return Guid.NewGuid();
        }

        
        #endregion protected methods

        #region private methods

        private static bool IsPrimaryPasswordExpired(DateTime expirationTime)
        {
            return expirationTime < DateTime.UtcNow;
        }
        private static bool HasLowerCaseAlphabets(string password)
        {
            return Regex.IsMatch(password, ".*[a-z]");
        }

        private static bool HasUpperCaseAlphabets(string password)
        {
            return Regex.IsMatch(password, ".*[A-Z]");
        }
        
        private UserActivityReason ValidatePINPassword(string userProvidedPassword, UserActivityReason activityReason)
        {
            activityReason.ReturnFlag = true;
            activityReason.Message = UserAccountNotification.Success;
            Guid passwordSalt = _user.PINSalt ?? default(Guid);
            byte[] computedPassword = ComputePasswordHash(userProvidedPassword, passwordSalt,
                                                          PASSWORD_REHASH_TIMES);
            if (IsPasswordEqual(_user.PINHash256, computedPassword))
                UpdateLastLoginTime();
            else
            {
                activityReason.ReturnFlag = false;
                activityReason.Message = UserAccountNotification.InvalidPassword;
            }
            return activityReason;
        }
        private UserActivityReason ValidatePrimaryPassword(string userProvidedPassword, UserActivityReason activityReason)
        {
            activityReason.ReturnFlag = true;
            activityReason.Message = UserAccountNotification.Success;
            Guid passwordSalt = _user.PasswordSalt ?? default(Guid);
            byte[] computedPassword = ComputePasswordHash(userProvidedPassword, passwordSalt,
                                                          PASSWORD_REHASH_TIMES);
            if (IsPasswordEqual(_user.PasswordHash256, computedPassword))
                UpdateLastLoginTime();
            else
            {
                activityReason.ReturnFlag = false;
                activityReason.Message = UserAccountNotification.InvalidPassword;
            }
            return activityReason;
        }

        private void CheckExpiration(out bool passwordExpired)
        {
            passwordExpired = false;
            DateTime passwordExpirationTime = _user.PasswordExpirationTime ?? default(DateTime);
            if (IsPrimaryPasswordExpired(passwordExpirationTime))
                passwordExpired = true;
        }

        private void UpdateLastLoginTime()
        {
            _user.LastLoginTime = DateTime.UtcNow;
        }

        #region Change Password
        private StatusEnum.ChangePasswordStatus ValidatePrimaryPasswordForChange(string userProvidedPassword)
        {
            StatusEnum.ChangePasswordStatus status = StatusEnum.ChangePasswordStatus.InvalidOldPassword;
            Guid passwordSalt = _user.PasswordSalt ?? default(Guid);
            byte[] computedPassword = ComputePasswordHash(userProvidedPassword, passwordSalt,
                                                          PASSWORD_REHASH_TIMES);
            if (IsPasswordEqual(_user.PasswordHash256, computedPassword))
            {
                status = StatusEnum.ChangePasswordStatus.Success;
            }
            return status;
        }

        private StatusEnum.ChangePasswordStatus ValidatePINPasswordForChange(string userProvidedPassword)
        {
            StatusEnum.ChangePasswordStatus status = StatusEnum.ChangePasswordStatus.InvalidOldPassword;
            Guid passwordSalt = _user.PINSalt ?? default(Guid);
            byte[] computedPassword = ComputePasswordHash(userProvidedPassword, passwordSalt,
                                                          PASSWORD_REHASH_TIMES);
            if (IsPasswordEqual(_user.PINHash256, computedPassword))
            {
                status = StatusEnum.ChangePasswordStatus.Success;
            }
            return status;
        }
        #endregion

        #endregion private methods
    }
}
