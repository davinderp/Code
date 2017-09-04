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
using Audit.WebApi;
using HC.Common.Filters;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientLabTestController : CustomJsonApiController<Entity.PatientLabTest, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;
        private readonly IPatientCommonService _patientCommonService;

        #region Construtor of the class
        public PatientLabTestController(
        IJsonApiContext jsonApiContext,
        IResourceService<Entity.PatientLabTest, int> resourceService,
        ILoggerFactory loggerFactory, IPatientCommonService patientCommonService)
        : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
                jsonApiContext.PageManager.DefaultPageSize = 10;
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
        /// <summary>
        /// this method is used for update patient social history
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patientInfo"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientLabTest patientLabTest)
        {
            //var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            //var patientLabTestOld = _dbContextResolver.GetDbSet<PatientLabTest>().Where(m => m.Id == id).FirstOrDefault();

            //CommonMethods commonMethods = new CommonMethods();
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientLabTestOld, patientLabTest, "PatientLabTest", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            //return await base.PatchAsync(id, patientLabTest);

            //var patientLabTestInfo = await base.PatchAsync(id, patientLabTest);

            //int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id + 1;
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientLabTestOld, patientLabTest, "PatientLabTest", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, patientLabTest);
        }

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientLabTest = await base.GetAsync(id);
            var patientLabTest = (Entity.PatientLabTest)((ObjectResult)asyncPatientLabTest).Value;
            patientLabTest.IsDeleted = true;
            return await base.PatchAsync(patientLabTest.Id, patientLabTest);
        }


        [ValidateModel]
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]PatientLabTest patientLabTest)
        {

            return await base.PostAsync(patientLabTest);
        }


        //[HttpGet]
        //public dynamic GetAsyncHL7(int id)
        //{
        //    NHapi.Base.Parser.PipeParser parser = new NHapi.Base.Parser.PipeParser();
        //    NHapi.Model.V231.Message.QRY_R02 qry = new NHapi.Model.V231.Message.QRY_R02();
        //    qry.MSH.MessageType.MessageType.Value = "QRY";
        //    qry.MSH.MessageType.TriggerEvent.Value = "R02";
        //    qry.MSH.MessageType.MessageStructure.Value = "QRY_R02";
        //    qry.MSH.FieldSeparator.Value = "|";
        //    qry.MSH.SendingApplication.NamespaceID.Value = "CohieCentral";
        //    qry.MSH.SendingFacility.NamespaceID.Value = "COHIE";
        //    qry.MSH.ReceivingApplication.NamespaceID.Value = "Clinical Data Provider";
        //    qry.MSH.ReceivingFacility.NamespaceID.Value = "facility";
        //    qry.MSH.EncodingCharacters.Value = @"^~\&";
        //    qry.MSH.VersionID.VersionID.Value = "2.3.1";
        //    qry.MSH.DateTimeOfMessage.TimeOfAnEvent.SetLongDate(DateTime.Now);
        //    qry.MSH.MessageControlID.Value = "messageControlId";
        //    qry.MSH.ProcessingID.ProcessingID.Value = "P";

        //    NHapi.Model.V231.Datatype.XCN st = qry.QRD.GetWhoSubjectFilter(0);
        //    st.AssigningAuthority.UniversalID.Value = "facility";
        //    st.IDNumber.Value = "mrn";
        //    qry.QRD.QueryDateTime.TimeOfAnEvent.SetLongDate(DateTime.Now);
        //    qry.QRD.QueryFormatCode.Value = "R";
        //    qry.QRD.QueryPriority.Value = "I";
        //    NHapi.Model.V231.Datatype.CE what = qry.QRD.GetWhatSubjectFilter(0);
        //    what.Identifier.Value = "RES";
        //    //return parser.Encode(qry);
        //    return parser.Encode(qry);

        //}

        #endregion

        #region Helping Methods
        #endregion


    }
}