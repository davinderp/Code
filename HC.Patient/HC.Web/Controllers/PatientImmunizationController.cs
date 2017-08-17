using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JsonApiDotNetCore.Controllers;
using HC.Common;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using HC.Patient.Entity;
using Microsoft.AspNetCore.JsonPatch;
using HC.Patient.Data;
using JsonApiDotNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using JsonApiDotNetCore.Data;
using HC.Patient.Service.PatientCommon.Interfaces;
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Http.Internal;
using HC.Common.Filters;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    [ValidateModel]
    public class PatientImmunizationController : JsonApiController<Entity.PatientImmunization, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        private readonly IPatientCommonService _patientCommonService;
        
        #region Construtor of the class
        public PatientImmunizationController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.PatientImmunization, int> resourceService,
       ILoggerFactory loggerFactory, IPatientCommonService patientCommonService)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
                // _dbContextResolver = jsonApiContext.GetDbContextResolver();
                this._patientCommonService = patientCommonService;
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

        [HttpGet]
        /// <summary>        
        /// <remarks>Following are the relationship tables</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        /// </summary>
        public override async Task<IActionResult> GetAsync()
        {
            // return result from base class
            return await base.GetAsync();
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientImmunization patientImmunization)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientImmunizationOld = _dbContextResolver.GetDbSet<PatientImmunization>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();

            //return await base.PatchAsync(id, patientImmunization);
            var patientImmunizationInfo = await base.PatchAsync(id, patientImmunization);

            int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id;
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientImmunizationOld, patientImmunization, "PatientImmunization", attrToUpdate)
                //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
                .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return patientImmunizationInfo;
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientImmunization = await base.GetAsync(id);
            var patientImmunization = (Entity.PatientImmunization)((ObjectResult)asyncPatientImmunization).Value;
            patientImmunization.IsDeleted = true;
            return await base.PatchAsync(patientImmunization.Id, patientImmunization);
        }

        #endregion

        #region Helping Methods
        #endregion
    }
}