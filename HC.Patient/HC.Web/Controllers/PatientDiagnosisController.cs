using HC.Common.Filters;
using HC.Patient.Entity;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Internal.Query;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HC.Patient.Web.Controllers
{
    [ValidateModel]
    public class PatientDiagnosisController : JsonApiController<Entity.PatientDiagnosis, int>
    {
        #region Construtor of the class
        public PatientDiagnosisController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.PatientDiagnosis, int> resourceService,
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
            return await base.PatchAsync(id, patientDiagnosis);
        }
            #endregion

            #region Helping Methods
            #endregion
        }
}