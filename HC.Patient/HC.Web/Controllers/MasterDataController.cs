using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HC.Patient.Model.MasterData;
using HC.Patient.Data;
using Microsoft.Extensions.Logging;
using HC.Patient.Service.MasterData.Interfaces;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using HC.Patient.Entity;
using HC.Common.Filters;
using HC.Model;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    [ValidateModel]
    [Produces("application/json")]
    [Route("api/MasterData")]
    public class MasterDataController : Controller
    {
        private readonly IMasterDataService _masterDataService;

        #region Construtor of the class
        public MasterDataController(IMasterDataService masterDataService)
        {
            this._masterDataService = masterDataService;

        }
        #endregion

        #region Class Methods
        //GET: api/GetMasterDataByName
        //[Authorize]
        /// <summary>
        /// Get master Data by Name
        /// </summary>
        /// <param name="masterDataNames"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MasterDataByName")]
        public MasterDataModel MasterDataByName([FromBody]JObject masterDataNames)
        {
            List<string> masterDataNamesList = new List<string>(Convert.ToString(masterDataNames["masterdata"]).Split(','));
            return _masterDataService.GetMasterDataByName(masterDataNamesList);

        }

        /// <summary>
        /// to get State by country ID
        /// </summary>
        /// <param name="countryID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStateByCountryID")]
        public JsonResult GetStateByCountryID(int countryID)
        {
            var masterStates = _masterDataService.GetStateByCountryID(countryID);
            if (masterStates != null && masterStates.Count > 0)
            {
                return Json(new JsonModel
                {
                    data = masterStates,
                    Message = "success",
                    StatusCode = 200
                });
            }
            else
            {
                return Json(new JsonModel
                {
                    data = new object(),
                    Message = "no data found",
                    StatusCode = 404
                });
            }

            //return _masterDataService.GetStateByCountryID(countryID);

        }
        #endregion

        #region Helping Methods
        //[HttpGet]
        //public string Get()
        //{
        //    Common.CommonMethods co = new Common.CommonMethods();

        //    return co.HashPassword("test", "123");
        //}
        #endregion
    }
}
