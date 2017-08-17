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
using Newtonsoft.Json.Linq;
using JsonApiDotNetCore.Data;
using HC.Patient.Model.Patient;
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Http.Internal;
using HC.Common.Filters;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    [ValidateModel]
    public class PatientPhoneNumberController : JsonApiController<PhoneNumbers, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;

        #region Construtor of the class
        public PatientPhoneNumberController(
        IJsonApiContext jsonApiContext,
        IResourceService<PhoneNumbers, int> resourceService,
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
        /// this method is used to save phone numcber
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost("postMultiple")]
        public async Task<IActionResult> PostAsync([FromBody]JObject entity)
        {
            try
            {
                PatientNumbers patientNumbers = entity.ToObject<PatientNumbers>();
                int patientID = patientNumbers.PatientID;
                var dbContext = _dbContextResolver.GetDbSet<PhoneNumbers>();
                if (patientNumbers.PhoneNumbers !=null && patientNumbers.PhoneNumbers.Count > 0)
                {
                    //int patientID = phoneNumbers.FirstOrDefault().PatientID_fk;

                    var phoneNumber = dbContext.Where(m => m.PatientID == patientID).ToList();

                    dbContext.RemoveRange(phoneNumber);
                    foreach (PhoneNumbers phone in patientNumbers.PhoneNumbers) { await base.PostAsync(phone); }
                    Response.StatusCode = 200;//(Status Ok)
                    return Json(new
                    {
                        data = new object(),
                        Message = "Success",
                        StatusCode = 200
                    });
                }
                else
                {
                    var phoneNumber = dbContext.Where(m => m.PatientID == patientID).ToList();
                    dbContext.RemoveRange(phoneNumber);
                    await _dbContextResolver.GetContext().SaveChangesAsync();
                    Response.StatusCode = 200;//(Status Ok)
                    return Json(new
                    {
                        data = new object(),
                        Message = "Success",
                        StatusCode = 200
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPhoneNumbers = await base.GetAsync(id);
            var phoneNumbers = (Entity.PhoneNumbers)((ObjectResult)asyncPhoneNumbers).Value;
            phoneNumbers.IsDeleted = true;
            return await base.PatchAsync(phoneNumbers.Id, phoneNumbers);
        }

        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PhoneNumbers patientPhoneNumbers)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientPhoneNumbersOld = _dbContextResolver.GetDbSet<PhoneNumbers>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientPhoneNumbersOld, patientPhoneNumbers, "PhoneNumbers", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);

            //return await base.PatchAsync(id, patientPhoneNumbers);

            var patientPhoneNumbersInfo = await base.PatchAsync(id, patientPhoneNumbers);

            int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id;
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientPhoneNumbersOld, patientPhoneNumbers, "PhoneNumbers", attrToUpdate)
                //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
                .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return patientPhoneNumbersInfo;
        }
            #endregion

            #region Helping Methods
            #endregion
        }
}