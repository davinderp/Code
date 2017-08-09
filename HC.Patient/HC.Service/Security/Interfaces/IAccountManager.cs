using HC.Common.CommonData;
using HC.Common.Enums;
using HC.Patient.Entity;
using HC.Patient.Model.User;
using HC.Service.Interfaces;
using System;

namespace HC.Patient.Service.Security.Interfaces
{
    public interface IAccountManager: IBaseService
    {
        /// <summary>
        /// Validates a user's credentials.
        /// </summary>
        /// <param name="credential">Login credentials of the user.</param>
        /// <param name="secUser">SecUser against which login credentials will be validated.</param>
        /// <returns>Result of validation. <seealso cref="UserValidationResult"/></returns>
        UserActivityReason ValidateUser(LoginCredential credential, SecUser secUser = null);
        /// <summary>
        /// This will change user's password
        /// </summary>
        /// <param name="credential">Login credentials of the user.</param>
        /// <param name="secUser">SecUser against which login credentials will be validated.</param>
        /// <returns>Enum result of change password</returns>
        StatusEnum.ChangePasswordStatus ChangePassword(LoginCredential credential, SecUser secUser = null);
        /// <summary>
        /// Validates a user's password.
        /// </summary>
        /// <param name="credentials">Login credentials of the user.</param>
        /// <param name="activityReason">Reason of active/non-active user.</param>
        /// <returns>Result of Validation.</returns>
        UserActivityReason ValidatePassword(LoginCredential credentials, UserActivityReason activityReason);
        /// <summary>
        /// Save new primary password.
        /// </summary>
        /// <param name="newPassword">New primary password.</param>
        /// <param name="newSalt">New salt for new password.</param>
        /// <param name="email">Optional email for password creating.</param>
        void SaveNewPrimaryPassword(string newPassword, Guid? newSalt = null, string email = "");
        /// <summary>
        /// Validate passwor prior to chnage.
        /// </summary>
        /// <param name="credential">Login credentials of the user.</param>
        /// <returns>Result of validation.</returns>
        StatusEnum.ChangePasswordStatus ValidatePasswordForChange(LoginCredential credential);
        /// <summary>
        /// Will get user by email id.
        /// </summary>
        /// <param name="email">Input user's email</param>
        /// <returns>Will return user's details</returns>
        SecUser GetUserByEmail(string email);
    }
}
