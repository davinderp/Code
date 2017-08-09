using HC.Common.Enums;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Entity;
using HC.Patient.Model.User;
using HC.Patient.Service.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HC.Service;

namespace HC.Patient.Service.Users
{
    public class UserService : BaseService, IUserService
    {
        #region Global Variables
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        #endregion
        public UserService(IUserRepository userRepository,IUserRoleRepository userRoleRepository)
        {
            this._userRepository = userRepository;
            this._userRoleRepository = userRoleRepository;
        }
        #region private members

        private const int PASSWORD_REHASH_TIMES = 256000;
        private const int PIN_HASH_TIMES = 1;
        private PASCore_Users _user;
        private PASCore_UserRoles _userRoles;

        #endregion private members

        #region public methods

        public StatusEnum.Status SaveUser(UserModel model)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                _user = new PASCore_Users();
                _user.Id = Guid.NewGuid();
                _user.UserName = model.UserName;                
                _user.TelMobile = model.TelMobile;
                _user.TelMainTwo = model.TelMainTwo;
                _user.TelMainOne = model.TelMainOne;
                _user.Telex = model.Telex;
                _user.Prefix = model.Prefix;
                _user.Password = model.Password;
                _user.OfficeId = Guid.NewGuid();
                _user.ModifiedDateTime = null;
                _user.MiddleName = model.MiddleName;
                _user.LastName = model.LastName;
                _user.LastLoginDateTime = null;
                _user.IsDeleted = false;
                _user.IsActive = true;
                _user.FirstName = model.FirstName;
                _user.EntityId = model.EntityId;
                _user.EmailAddress = model.emailAddress;
                _user.DeletedDateTime = null;
                _user.CreatedDateTime = DateTime.UtcNow;                
                _userRepository.Create(_user);
                _userRepository.SaveChanges();
                if(_user.Id!=null)
                {
                    if (model.UserRole.Length > 0)
                    {
                        foreach (var roles in model.UserRole)
                        {
                            Guid roleId = new Guid(roles);
                            _userRoles = new PASCore_UserRoles()
                            {
                                RoleId=roleId,
                                UserId=_user.Id
                            };
                            _userRoleRepository.Create(_userRoles);
                        }
                        _userRoleRepository.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
            }
            return status;
        }

        public StatusEnum.Status UpdateUser(UserModel model)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                PASCore_Users user = _userRepository.GetByID(model.UserId);
                user.UserName = model.UserName;
                user.TelMobile = model.TelMobile;
                user.TelMainTwo = model.TelMainTwo;
                user.TelMainOne = model.TelMainOne;
                user.Telex = model.Telex;
                user.Prefix = model.Prefix;
                user.Password = model.Password;
                user.OfficeId = Guid.NewGuid();
                user.ModifiedDateTime = null;
                user.MiddleName = model.MiddleName;
                user.LastName = model.LastName;
                user.LastLoginDateTime = null;
                user.IsDeleted = false;
                user.IsActive = true;
                user.FirstName = model.FirstName;
                user.EntityId = model.EntityId;
                user.EmailAddress = model.emailAddress;
                user.DeletedDateTime = null;
                user.CreatedDateTime = DateTime.UtcNow;
                _userRepository.Update(user);
                _userRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                status = StatusEnum.Status.Fail;
            }
            return status;
        }
        

        public dynamic GetAllUser()
        {
            dynamic AllUsers = _userRepository.GetAll(x=>x.IsActive==true & x.IsDeleted==false);
            return AllUsers;
        }

        public dynamic GetUser(Guid id)
        {
            dynamic user = _userRepository.GetByID(id);
            return user;
        }

        public StatusEnum.Status DeleteUser(Guid id)
        {
            StatusEnum.Status status = StatusEnum.Status.Success;
            try
            {
                PASCore_Users userDelete = _userRepository.GetByID(id);
                userDelete.IsDeleted = true;
                _userRepository.Update(userDelete);
                _userRepository.SaveChanges();
            }
            catch (Exception)
            {
                status = StatusEnum.Status.Fail;
            }
            return status;
        }

        public dynamic LoginUser(string Email, string Password)
        {
            try
            {
                //var getUserDetails = _userRepository.Get(x => x.EmailAddress == Email && x.Password == Password);
                var getUserDetails = _userRepository.Get(x => x.EmailAddress == Email);
                if (getUserDetails!=null)
                {
                    return getUserDetails;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return "UserName or password Not match";
        }

        #endregion

    }
}
