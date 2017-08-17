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
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Http.Internal;
using HC.Common.Filters;
using JsonApiDotNetCore.Data;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    [ValidateModel]
    public class PatientAddressController : JsonApiController<Entity.PatientAddress, int>
    {

        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        #region Construtor of the class
        public PatientAddressController(
        IJsonApiContext jsonApiContext,
        IResourceService<Entity.PatientAddress, int> resourceService,
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

        /// <summary>
        /// this method is use to get the list of patient Address
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            // custom code
            if (RequestIsValid() == false)
                return BadRequest();

            // return result from base class
            return await base.GetAsync();
        }
        /// <summary>
        /// this method is used to update the Patient Address
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patientAddress"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientAddress patientAddress)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientAddressOld = _dbContextResolver.GetDbSet<PatientAddress>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();

            var patientAddressInfo = await base.PatchAsync(id, patientAddress);
            int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id;
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientAddressOld, patientAddress, "PatientAddress", attrToUpdate)
                //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
                .Select(q => new AuditLogs()
                {
                    NewValue = q.NewValue,
                    OldValue = q.OldValue,
                    PrimaryKeyID = q.PrimaryKeyID,
                    TableName = q.TableName,
                    PropertyName = q.PropertyName,
                    EventID = eventID
                }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return patientAddressInfo;
        }


        /// <summary>
        /// this method is used for get data on basis of type and relationship
        /// </summary>
        /// <param name="type"></param>
        /// <param name="Id"></param>
        /// <param name="relationshipName"></param>
        /// <returns></returns>
        [HttpGet("{type}/{id}/{relationshipName}")]
        public async Task<IActionResult> GetRelationshipAsync(string type, int Id, string relationshipName)
        {
            return await base.GetRelationshipAsync(Id, relationshipName);
        }

        [HttpGet("{type}/{id}/relationships/{relationshipName}")]
        public async Task<IActionResult> GetRelationshipsAsync(string type, int Id, string relationshipName)
        {
            return await base.GetRelationshipsAsync(Id, relationshipName);
        }

        /// <summary>
        /// this method is used to soft delete of record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientAddress = await base.GetAsync(id);
            var patientAddress = (Entity.PatientAddress)((ObjectResult)asyncPatientAddress).Value;
            patientAddress.IsDeleted = true;
            return await base.PatchAsync(patientAddress.Id, patientAddress);
        }

        #endregion

        #region Helping Methods
        // some custom validation logic
        private bool RequestIsValid() => true;
        #endregion


    }
}