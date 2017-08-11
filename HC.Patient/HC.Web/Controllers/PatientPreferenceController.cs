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
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Http.Internal;
using HC.Common.Filters;
using JsonApiDotNetCore.Data;

namespace HC.Patient.Web.Controllers
{
    [ValidateModel]
    public class PatientPreferenceController : JsonApiController<Entity.PatientPreference, int>
    {
        #region Construtor of the class
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        public PatientPreferenceController(
           IJsonApiContext jsonApiContext,
           IResourceService<Entity.PatientPreference, int> resourceService,
           ILoggerFactory loggerFactory)
        : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
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

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientPreference = await base.GetAsync(id);
            var patientPreference = (Entity.PatientPreference)((ObjectResult)asyncPatientPreference).Value;
            patientPreference.IsDeleted = true;
            return await base.PatchAsync(patientPreference.Id, patientPreference);
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientPreference patientPreference)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientPreferenceOld = _dbContextResolver.GetDbSet<PatientPreference>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientPreferenceOld, patientPreference, "PatientPreference").Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName)).Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);

            return await base.PatchAsync(id, patientPreference);
        }
            #endregion

            #region Helping Methods
            #endregion
        }
}