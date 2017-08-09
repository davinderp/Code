using HC.Patient.Model.Vitals;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Internal.Query;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Web.Controllers
{
    public class UserController : JsonApiController<Entity.User, int>
    {
        Common.CommonMethods _commonMethods = new Common.CommonMethods();
        #region Construtor of the class
        public UserController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.User, int> resourceService,
       ILoggerFactory loggerFactory)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                if (jsonApiContext.QuerySet != null && !jsonApiContext.QuerySet.Equals(null))
                {
                    //jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsActive", "true", ""));
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsDeleted", "false", ""));
                }
                else
                {

                    jsonApiContext.QuerySet = new QuerySet(jsonApiContext, new QueryCollection());
                    jsonApiContext.QuerySet.Filters = new List<FilterQuery>();
                    //jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsActive", "true", ""));
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsDeleted", "false", ""));

                }
            }
            catch
            {

            }
        }
        #endregion

        #region Class Methods
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]Entity.User user)
        {
            try
            {
                if (!string.IsNullOrEmpty(user.Password))
                {
                    user.Password = _commonMethods.Encrypt(user.Password);
                }
            }
            catch (Exception ex)
            {

            }
            return await base.PostAsync(user);
        }
        

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientVitals = await base.GetAsync(id);
            var user = (Entity.User)((ObjectResult)asyncPatientVitals).Value;
            //user.IsDeleted = true;
            return await base.PatchAsync(user.Id, user);
        }
        /// <summary>
        /// Patch is used to update user attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]Entity.User user)
        {
            if (!string.IsNullOrEmpty(user.Password))
            {
                user.Password = _commonMethods.Encrypt(user.Password);
            }
            return await base.PatchAsync(id, user);
        }



        #endregion

        #region Helping Methods        
        #endregion
    }
}