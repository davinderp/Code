using HC.Common.Filters;
using HC.Patient.Service.PatientCommon.Interfaces;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
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
    public class PatientMedicalFamilyHistoryController : JsonApiController<Entity.PatientMedicalFamilyHistory, int>
    {   
        private readonly IPatientCommonService _patientCommonService;

        #region Construtor of the class
        public PatientMedicalFamilyHistoryController(
        IJsonApiContext jsonApiContext,
        IResourceService<Entity.PatientMedicalFamilyHistory, int> resourceService,
        ILoggerFactory loggerFactory, IPatientCommonService patientCommonService)
        : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                //_dbContextResolver = jsonApiContext.GetDbContextResolver();
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
        /// <remarks>this method is used for get list for patient medical family history</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        /// </summary>
        public override async Task<IActionResult> GetAsync()
        {
            // return result from base class
            return await base.GetAsync();
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]Entity.PatientMedicalFamilyHistory patientMedicalFamilyHistory)
        {
            return await base.PatchAsync(id, patientMedicalFamilyHistory);
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientMedicalFamilyHistory = await base.GetAsync(id);
            var patientMedicalFamilyHistory = (Entity.PatientMedicalFamilyHistory)((ObjectResult)asyncPatientMedicalFamilyHistory).Value;
            patientMedicalFamilyHistory.IsDeleted = true;
            return await base.PatchAsync(patientMedicalFamilyHistory.Id, patientMedicalFamilyHistory);
        }

        #endregion

        #region Helping Methods
        #endregion
    }
}