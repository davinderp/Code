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
using HC.Common;
using Audit.WebApi;
using Ical.Net;
using System.IO;
using Ical.Net.DataTypes;
using System.Globalization;
using Ical.Net.Interfaces.Evaluation;
using Ical.Net.Utility;

namespace HC.Patient.Web.Controllers
{
    [ServiceFilter(typeof(LogFilter))]
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientAppointmentController : CustomJsonApiController<PatientAppointment, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;

        private ILogger<PatientAppointmentController> _logger;

        #region Construtor of the class
        public PatientAppointmentController(
       IJsonApiContext jsonApiContext,
       IResourceService<PatientAppointment, int> resourceService,
       ILoggerFactory loggerFactory, ILogger<PatientAppointmentController> logger)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            //_logger = logger;
            //_logger.LogCritical("nlog is working from a controller");
            //throw new ArgumentException("way wrong");
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
            var asyncPatientAppointments = await base.GetAsync();
            var patientAppointments = (List<PatientAppointment>)((ObjectResult)asyncPatientAppointments).Value;

            patientAppointments.ForEach(p => {

                RecurrencePattern pattern = new RecurrencePattern(p.RecurrenceRule);
                pattern.RestrictionType = RecurrenceRestrictionType.NoRestriction;

                var us = new CultureInfo("en-US");

                var startDate = new CalDateTime(p.StartDateTime, "UTC");
                var fromDate = new CalDateTime(p.StartDateTime, "UTC");
                var toDate = new CalDateTime(pattern.Until, "UTC");

                var evaluator = pattern.GetService(typeof(IEvaluator)) as IEvaluator;

                p.Occurrences = evaluator.Evaluate(
                    startDate,
                    DateUtil.SimpleDateTimeToMatch(fromDate, startDate),
                    DateUtil.SimpleDateTimeToMatch(toDate, startDate),
                    true)
                    .OrderBy(o => o.StartTime)
                    .ToList();
                var endDate = new CalDateTime(p.EndDateTime, "UTC");
                TimeSpan t = p.EndDateTime - p.StartDateTime;
                p.Occurrences.ForEach(m => m.Duration = t);
                p.RecurrencePattern = pattern;
            });

            ((ObjectResult)asyncPatientAppointments).Value = patientAppointments;

            return asyncPatientAppointments;
            
            //return

        }

        [ValidateModel]
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]PatientAppointment entity)
        {

            return await base.PostAsync(entity);
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientAppointment patientAppointment)
        {
            //var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            //var patientAppointmentOld = _dbContextResolver.GetDbSet<PatientAppointment>().Where(m => m.Id == id).FirstOrDefault();

            //CommonMethods commonMethods = new CommonMethods();

            //// var patientAppointmentInfo = await base.PatchAsync(id, patientAppointment);

            //int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id + 1;
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientAppointmentOld, patientAppointment, "PatientAppointment", attrToUpdate)
            //    //.Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs()
            //    {
            //        NewValue = q.NewValue,
            //        OldValue = q.OldValue,
            //        PrimaryKeyID = q.PrimaryKeyID,
            //        TableName = q.TableName,
            //        PropertyName = q.PropertyName,
            //        EventID = eventID
            //    }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, patientAppointment);
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
