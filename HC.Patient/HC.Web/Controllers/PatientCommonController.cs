using Audit.WebApi;
using HC.Patient.Entity;
using HC.Patient.Service.PatientCommon.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientCommonController : Controller
    {
        private readonly IPatientCommonService _patientCommonService;

        #region Construtor of the class
        public PatientCommonController(IPatientCommonService patientCommonService)
        {
            try
            {
                this._patientCommonService = patientCommonService;
            }
            catch
            {

            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// this method is used for check patient exist or not
        /// </summary>
        /// <param name="patientInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PatientExist")]
        public JsonResult PatientExist([FromBody]Patients patientInfo)
        {
            Patients patient = _patientCommonService.PatientExist(patientInfo);
            if (patient != null)
            {
                return Json(new
                {
                    data = patient,
                    Message = "Patient already exist",
                    StatusCode = 200
                });
            }
            else
            {
                return Json(new
                {
                    data = new object(),
                    Message = "No Data",
                    StatusCode = 404
                });
            }
        }
        #endregion

    }
}