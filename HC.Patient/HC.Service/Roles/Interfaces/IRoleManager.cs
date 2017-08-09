using HC.Common.Enums;
using HC.Patient.Model.Roles;
using HC.Service.Interfaces;
using System;

namespace HC.Patient.Service.Roles.Interfaces
{
    public interface IRoleManager : IBaseService
    {
        /// <summary>
        /// Create a new Role
        /// </summary>
        /// <param name="model">role data in model</param>
        /// <returns></returns>
        StatusEnum.Status CreateRole(RoleModel model);
        /// <summary>
        /// update a  Role
        /// </summary>
        /// <param name="model">role data in model</param>
        /// <returns></returns>

        StatusEnum.Status UpdateRole(RoleModel model);
        /// <summary>
        /// Delete a  Role
        /// </summary>
        /// <param name="model">role data in model</param>
        /// <returns></returns>
        StatusEnum.Status DeleteRole(Guid id);
        /// <summary>
        /// Get Role Info
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        dynamic GetAllRole();
        /// <summary>
        /// Delete a  Role
        /// </summary>
        /// <param name="id">role id</param>
        /// <returns></returns>
        dynamic GetRoleByID(Guid id);
    }
}
