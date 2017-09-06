using Audit.WebApi;
using HC.Common;
using HC.Patient.Entity;
using HC.Patient.Service.PatientCommon.Interfaces;
using HC.Patient.Service.Token.Interfaces;
using HC.Patient.Web.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.IO;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientCommonController : Controller
    {
        private readonly IPatientCommonService _patientCommonService;
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly ITokenService _tokenService;
        private readonly JsonSerializerSettings _serializerSettings;

        #region Construtor of the class
        public PatientCommonController(IPatientCommonService patientCommonService, IOptions<JwtIssuerOptions> jwtOptions, ITokenService tokenService)
        {
            try
            {
                _jwtOptions = jwtOptions.Value;
                ThrowIfInvalidOptions(_jwtOptions);

                _tokenService = tokenService;

                _serializerSettings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };

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
                Response.StatusCode = 200;//(Status Ok)
                return Json(new
                {
                    data = patient,
                    Message = "Patient already exist",
                    StatusCode = 200
                });
            }
            else
            {
                Response.StatusCode = 404;//(Not Found)
                return Json(new
                {
                    data = new object(),
                    Message = "No Data",
                    StatusCode = 404
                });
            }
        }

        [HttpPost]
        [Route("GetUserByToken")]
        public JsonResult GetUserByToken(string Token)
        {
            CommonMethods commonMethods = new CommonMethods();
            var encryptData = commonMethods.GetDataFromToken(Token);
            int userid=0;
            if (encryptData != null && encryptData.Claims!=null)
            {
                if (encryptData.Claims.Count > 0)
                {
                    userid = Convert.ToInt32(encryptData.Claims[0].Value);
                    Response.StatusCode = 200;//(Not Found)
                    var response = new
                    {
                        access_token = Token,
                        expires_in = (int)_jwtOptions.ValidFor.TotalSeconds,
                        data = _tokenService.GetDoctorByUserID(userid)
                        
                    };
                    var json = JsonConvert.SerializeObject(response, _serializerSettings);
                    return new JsonResult(json);
                }
                else
                {
                    Response.StatusCode = 401;//(Unauthorized)
                    return Json(new
                    {
                        data = new object(),
                        Message = "Invalid token",
                        StatusCode = 401
                    });
                }
                
            }
            else
            {
                Response.StatusCode = 401;//(Unauthorized)
                return Json(new
                {
                    data = new object(),
                    Message = "Invalid token",
                    StatusCode = 401
                });
            }
        }
        private static void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.ValidFor <= TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(JwtIssuerOptions.ValidFor));
            }

            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));
            }

            if (options.JtiGenerator == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
            }
        }
        #endregion

    }
}