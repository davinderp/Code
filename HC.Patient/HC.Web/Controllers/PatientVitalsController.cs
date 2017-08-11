using HC.Common;
using HC.Common.Filters;
using HC.Patient.Entity;
using HC.Patient.Model.Vitals;
using HC.Patient.Service.PatientCommon.Interfaces;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Internal.Query;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Web.Controllers
{
    [ValidateModel]
    public class PatientVitalsController : JsonApiController<Entity.PatientVitals, int>
    {

        private readonly IDbContextResolver _dbContextResolver;
        private readonly IPatientCommonService _patientCommonService;
        public readonly IJsonApiContext _jsonApiContext;

        #region Construtor of the class
        public PatientVitalsController(
       IJsonApiContext jsonApiContext,
       IResourceService<Entity.PatientVitals, int> resourceService,
       ILoggerFactory loggerFactory, IPatientCommonService patientCommonService)
    : base(jsonApiContext, resourceService, loggerFactory)
        {
            try
            {
                _dbContextResolver = jsonApiContext.GetDbContextResolver();
                _jsonApiContext = jsonApiContext;
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
        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody]Entity.PatientVitals entity)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    entity = calculateBmi(entity);
                }
                else
                {
                    return Json(new
                    {
                        data = new object(),
                        Message = "Please check your fields",
                        StatusCode = 404
                    });
                }
            }
            catch (Exception ex)
            {

            }
            return await base.PostAsync(entity);
        }

        //[HttpDelete("{id}")]
        //public override async Task<IActionResult> DeleteAsync(int id)
        //{
        //    try
        //    {
        //        //delete the record by json API default method
        //        await base.DeleteAsync(id);
        //        return Json(new
        //        {
        //            data = new object(),
        //            Message = "Record Successfully deleted",
        //            StatusCode = 200
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new
        //        {
        //            data = new object(),
        //            Message = ex.Message,
        //            StatusCode = 404
        //        });
        //    }
        //}

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientVitals = await base.GetAsync(id);
            var patientVitals = (Entity.PatientVitals)((ObjectResult)asyncPatientVitals).Value;
            patientVitals.IsDeleted = true;
            return await base.PatchAsync(patientVitals.Id, patientVitals);
        }

        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientVitals patientVital)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientVitalOld = _dbContextResolver.GetDbSet<PatientVitals>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientVitalOld, patientVital, "PatientVitals").Where(i => attrToUpdate.Keys.Any(a1 => a1.InternalAttributeName == i.PropertyName)).Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);

            AttrAttribute BMI = new AttrAttribute(AttrToUpdate.BMI.ToString(), AttrToUpdate.BMI.ToString());
            patientVital = calculateBmi(patientVital);
            _jsonApiContext.AttributesToUpdate.Add(BMI, patientVital.BMI);
            return await base.PatchAsync(id, patientVital);
        }

        [HttpPatch]
        public JsonResult PatchAsync([FromBody]JObject patientInfo)
        {
            try
            {
                if (patientInfo.Count != 0)
                {
                    Vitals vital = JsonConvert.DeserializeObject<Vitals>(patientInfo.ToString());

                    _patientCommonService.UpdatePatientVitalsFollowUpData(vital);
                    return Json(new
                    {
                        data = new object(),
                        Message = "success",
                        StatusCode = 200
                    });
                }
                else
                {
                    return Json(new
                    {
                        data = new object(),
                        Message = "Please check your fields",
                        StatusCode = 404
                    });
                }
            }
            catch (Exception)
            {
                throw;
                //return Json(new
                //{
                //    data = new object(),
                //    Message = "Please check your fields",
                //    StatusCode = 404
                //});
            }
        }

        #endregion

        #region Helping Methods
        /// <summary>
        /// Calculate BMI and update relevant fields
        /// </summary>
        /// <param name="patientVitals"></param>
        /// <returns></returns>
        private static Entity.PatientVitals calculateBmi(Entity.PatientVitals patientVitals)
        {
            double weightKg = 0;
            double heightCm = 0;
            if (patientVitals.WeightLbs > 0)
            {
                //convert lbs into pound (.45 is 1kg value in pounds)
                weightKg = Math.Round(patientVitals.WeightLbs * .45, 2);
            }

            if (patientVitals.HeightFt > 0)
            {
                //convert height of feet and inches into cm
                heightCm = Math.Round(((patientVitals.HeightFt * 12) + patientVitals.HeightIn) * 2.54, 2);
            }

            //var height = patientVitals.Height_cm;
            //var weight = patientVitals.Weight_kg;

            if (heightCm > 0 && weightKg > 0)
            {
                //calculate BMI
                patientVitals.BMI = Math.Round(weightKg / (heightCm / 100 * heightCm / 100), 2);

                //if (patientVitals.BMI < 18.5)
                //{
                //    patientVitals.BMI_Status = "Below Normal";
                //}
                //if (patientVitals.BMI > 18.5 && patientVitals.BMI < 25)
                //{
                //    patientVitals.BMI_Status = "Normal";
                //}
                //if (patientVitals.BMI > 25)
                //{
                //    patientVitals.BMI_Status = "Overweight";
                //}
            }
            return patientVitals;
        }
        #endregion
    }
}