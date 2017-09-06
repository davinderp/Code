using HC.Common;
using HC.Patient.Entity;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HC.Patient.Model.Image;
using System.Collections.Generic;
using HC.Patient.Service.PatientCommon.Interfaces;
using HC.Patient.Service.PatientCommon;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Model.Patient;
using static HC.Common.CommonMethods;
using JsonApiDotNetCore.Data;
using System.Linq;
using static HC.Common.Enums.CommonEnum;
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Internal;
using JsonApiDotNetCore.Models;
using HC.Common.Filters;
using HC.Patient.Data;
using HC.Model;
using System.Net.Http;
using System.Net;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    //[Authorize("AuthorizedUser")]
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientCustomLabelsController : CustomJsonApiController<PatientCustomLabels, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;

        #region Construtor of the class
        public PatientCustomLabelsController(
       IJsonApiContext jsonApiContext,
       IResourceService<PatientCustomLabels, int> resourceService,
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



        /// <summary>
        /// this method is used for get request for patient
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            return await base.GetAsync();

        }
        [HttpGet("{type}/{id}/{relationshipName}")]
        public async Task<IActionResult> GetRelationshipAsync(string type, int id, string relationshipName)
        {
            return await base.GetRelationshipAsync(id, relationshipName);
        }


        [HttpGet("{type}/{id}/relationships/{relationshipName}")]
        public async Task<IActionResult> GetRelationshipsAsync(string type, int id, string relationshipName)
        {
            return await base.GetRelationshipsAsync(id, relationshipName);
        }

        /// <summary>
        /// this method is used for save PatientCustomLabels
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [ValidateModel]
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]PatientCustomLabels patientCustomLabels)
        {
            return await base.PostAsync(patientCustomLabels);
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientCustomLabels = await base.GetAsync(id);
            var patientCustomLabels = (PatientCustomLabels)((ObjectResult)asyncPatientCustomLabels).Value;
            patientCustomLabels.IsDeleted = true;
            return await base.PatchAsync(patientCustomLabels.Id, patientCustomLabels);
        }

        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientCustomLabels patientCustomLabels)
        {

            return await base.PatchAsync(id, patientCustomLabels);
        }
        #endregion


    }
}