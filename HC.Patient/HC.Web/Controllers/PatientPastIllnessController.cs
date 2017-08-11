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

namespace HC.Patient.Web.Controllers
{
    [ValidateModel]
    public class PatientPastIllnessController : JsonApiController<Entity.PatientPastIllness, int>
    {
        //private readonly IDbContextResolver _dbContextResolver;
        private readonly IPatientCommonService _patientCommonService;
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        #region Construtor of the class
        public PatientPastIllnessController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.PatientPastIllness, int> resourceService,
       ILoggerFactory loggerFactory, IPatientCommonService patientCommonService)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
                //_dbContextResolver = jsonApiContext.GetDbContextResolver();
                this._patientCommonService = patientCommonService;
                if (jsonApiContext.QuerySet !=null && !jsonApiContext.QuerySet.Equals(null))
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
            catch(Exception ex)
            {

            }
        }
        #endregion

        #region Class Methods
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]PatientPastIllness patientInfo)
        {
            return await base.PostAsync(patientInfo);
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientPastIllness patientPastIllness)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientPastIllnessOld = _dbContextResolver.GetDbSet<PatientPastIllness>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientPastIllnessOld, patientPastIllness, "PatientPastIllness").Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName)).Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, patientPastIllness);
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientPastIllness = await base.GetAsync(id);
            var patientPastIllness = (Entity.PatientPastIllness)((ObjectResult)asyncPatientPastIllness).Value;
            patientPastIllness.IsDeleted = true;
            return await base.PatchAsync(patientPastIllness.Id, patientPastIllness);
        }

        #endregion

        #region Helping Methods
        #endregion


    }
}