using HC.Common;
using HC.Common.Filters;
using HC.Patient.Entity;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Internal.Query;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HC.Patient.Web.Controllers
{
    [ValidateModel]
    public class PatientDiagnosisController : JsonApiController<Entity.PatientDiagnosis, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        #region Construtor of the class
        public PatientDiagnosisController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.PatientDiagnosis, int> resourceService,
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

            var asyncPatientDiagnosis = await base.GetAsync(id);
            var patientDiagnosis = (Entity.PatientDiagnosis)((ObjectResult)asyncPatientDiagnosis).Value;
            patientDiagnosis.IsDeleted = true;
            return await base.PatchAsync(patientDiagnosis.Id, patientDiagnosis);
        }

        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientDiagnosis patientDiagnosis)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientDiagnosisOld = _dbContextResolver.GetDbSet<PatientDiagnosis>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientDiagnosisOld, patientDiagnosis, "PatientDiagnosis").Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName)).Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, patientDiagnosis);
        }
            #endregion

            #region Helping Methods
            #endregion
        }
}