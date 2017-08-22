using Audit.WebApi;
using HC.Common;
using HC.Common.Filters;
using HC.Patient.Entity;
using HC.Patient.Model.Vitals;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
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
using System.Linq;
using System.Threading.Tasks;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class UserController : CustomJsonApiController<Entity.User, int>
    {
        private readonly IDbContextResolver _dbContextResolver;
        public readonly IJsonApiContext _jsonApiContext;
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
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
                jsonApiContext.PageManager.DefaultPageSize = 10;
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

        [ValidateModel]
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
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]User user)
        {
            //var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            //var userOld = _dbContextResolver.GetDbSet<User>().Where(m => m.Id == id).FirstOrDefault();

            //CommonMethods commonMethods = new CommonMethods();
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(userOld, user, "User", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);

            if (!string.IsNullOrEmpty(user.Password))
            {
                user.Password = _commonMethods.Encrypt(user.Password);
            }
            //return await base.PatchAsync(id, user);

            //var userInfo = await base.PatchAsync(id, user);

            //int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id + 1;
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(userOld, user, "User", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, user);
        }



        #endregion

        #region Helping Methods        
        #endregion
    }
}