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

    public class PatientGuardianController : CustomJsonApiController<Entity.PatientGuardian, int>
    {
        //private readonly IDbContextResolver _dbContextResolver;
        private readonly IPatientCommonService _patientCommonService;
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        #region Construtor of the class
        public PatientGuardianController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.PatientGuardian, int> resourceService,
       ILoggerFactory loggerFactory, IPatientCommonService patientCommonService)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
                jsonApiContext.PageManager.DefaultPageSize = 10;
                //_dbContextResolver = jsonApiContext.GetDbContextResolver();
                this._patientCommonService = patientCommonService;
                if (jsonApiContext.QuerySet !=null && !jsonApiContext.QuerySet.Equals(null))
                {
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsActive", "true", ""));
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsDeleted", "false", ""));
                }
                else
                {

                    jsonApiContext.QuerySet = new QuerySet(jsonApiContext, new QueryCollection());
                    jsonApiContext.QuerySet.Filters = new List<FilterQuery>();
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsActive", "true", ""));
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsDeleted", "false", ""));

                }
            }
            catch(Exception ex)
            {

            }
        }
        #endregion

        #region Class Methods
        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            return await base.GetAsync();
        }

        [HttpPost]        
        public override async Task<IActionResult> PostAsync([FromBody]PatientGuardian patientInfo)
        {
            var Token = HttpContext.Request.Headers.Skip(7).FirstOrDefault().Value; // 

            return await base.PostAsync(patientInfo);
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientGuardian patientGuardian)
        {
            //var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            //var patientPastIllnessOld = _dbContextResolver.GetDbSet<PatientPastIllness>().Where(m => m.Id == id).FirstOrDefault();

            //CommonMethods commonMethods = new CommonMethods();
            ////List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientPastIllnessOld, patientGuardian, "PatientPastIllness", attrToUpdate)
            ////    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            ////    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            ////await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            ////return await base.PatchAsync(id, patientGuardian);

            ////var patientPastIllnessInfo = await base.PatchAsync(id, patientGuardian);

            //int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id + 1;
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientPastIllnessOld, patientGuardian, "PatientPastIllness", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, patientGuardian);
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientGuardian = await base.GetAsync(id);
            var patientGuardian = (Entity.PatientGuardian)((ObjectResult)asyncPatientGuardian).Value;
            patientGuardian.IsDeleted = true;
            return await base.PatchAsync(patientGuardian.Id, patientGuardian);
        }

        #endregion

        #region Helping Methods
        #endregion


    }
}