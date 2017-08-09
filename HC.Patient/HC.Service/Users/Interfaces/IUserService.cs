using HC.Common.Enums;
using HC.Patient.Model.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Service.Users.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Save New User
        /// </summary>
        /// <param name="model"></param>
        /// <param name="newSalt"></param>
        /// <param name="email"></param>
        StatusEnum.Status SaveUser(UserModel model);
        /// <summary>
        /// Update User records
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        StatusEnum.Status UpdateUser(UserModel model);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        dynamic GetAllUser();
        /// <summary>
        /// get specific user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        dynamic GetUser(Guid id);

        StatusEnum.Status DeleteUser(Guid id);

        dynamic LoginUser(string Email, string Password);

    }
}
