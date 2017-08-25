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
            // BuildMyString.com generated code. Please enjoy your string responsibly.

            string sb = "BEGIN:VCALENDAR\r\n" +
            "VERSION:2.0\r\n" +
            "PRODID:-//Mozilla.org/NONSGML Mozilla Calendar V1.1//EN\r\n" +
            "BEGIN:VEVENT\r\n" +
            "CREATED:20060717T210517Z\r\n" +
            "LAST-MODIFIED:20060717T210718Z\r\n" +
            "DTSTAMP:20060717T210718Z\r\n" +
            "UID:uuid1153170430406\r\n" +
            "SUMMARY:Test event\r\n" +
            "DTSTART;TZID=US-Eastern:19970902T090000\r\n" +
            "RRULE:FREQ=DAILY;UNTIL=19971224T000000Z\r\n" +
            "DTEND:19970902T100000\r\n" +
            "END:VEVENT\r\n" +
            "BEGIN:VTIMEZONE\r\n" +
            "TZID:US-Eastern\r\n" +
            "LAST-MODIFIED:19870101T000000Z\r\n" +
            "TZURL:http://zones.stds_r_us.net/tz/US-Eastern\r\n" +
            "BEGIN:STANDARD\r\n" +
            "DTSTART:19671029T020000\r\n" +
            "RRULE:FREQ=YEARLY;BYDAY=-1SU;BYMONTH=10\r\n" +
            "TZOFFSETFROM:-0400\r\n" +
            "TZOFFSETTO:-0500\r\n" +
            "TZNAME:EST\r\n" +
            "END:STANDARD\r\n" +
            "BEGIN:DAYLIGHT\r\n" +
            "DTSTART:19870405T020000\r\n" +
            "RRULE:FREQ=YEARLY;BYDAY=1SU;BYMONTH=4\r\n" +
            "TZOFFSETFROM:-0500\r\n" +
            "TZOFFSETTO:-0400\r\n" +
            "TZNAME:EDT\r\n" +
            "END:DAYLIGHT\r\n" +
            "END:VTIMEZONE\r\n" +
            "END:VCALENDAR\r\n";




            var iCal1 = Calendar.LoadFromStream(new StringReader(sb));
            var events = iCal1[0].Events[0].GetOccurrences(new CalDateTime(1997, 9, 1), new CalDateTime(2017, 9, 1));
            return await base.GetAsync();

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
