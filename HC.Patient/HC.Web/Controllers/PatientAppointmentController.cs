using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HC.Common.Filters;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using HC.Patient.Entity;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Http.Internal;

namespace HC.Patient.Web.Controllers
{
    
    public class PatientAppointmentController : JsonApiController<PatientAppointment, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;

        #region Construtor of the class
        public PatientAppointmentController(
       IJsonApiContext jsonApiContext,
       IResourceService<PatientAppointment, int> resourceService,
       ILoggerFactory loggerFactory)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
                if (jsonApiContext.QuerySet != null && !jsonApiContext.QuerySet.Equals(null))
                {
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsDeleted", "false", ""));
                }
                else
                {

                    jsonApiContext.QuerySet = new QuerySet(jsonApiContext, new QueryCollection());
                    jsonApiContext.QuerySet.Filters = new List<FilterQuery>();
                    jsonApiContext.QuerySet.Filters.Add(new FilterQuery("IsDeleted", "false", ""));

                }

            }
            catch
            {

            }
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            return await base.GetAsync();

        }

        [ValidateModel]
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]PatientAppointment entity)
        {

            return await base.PostAsync(entity);
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientAppointment entity)
        {

            return await base.PatchAsync(id,entity);
        }
        #endregion

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientAppointments = await base.GetAsync(id);
            var patientAppointment = (PatientAppointment)((ObjectResult)asyncPatientAppointments).Value;
            patientAppointment.IsDeleted = true;
            return await base.PatchAsync(patientAppointment.Id, patientAppointment);
        }
    }
}
