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
using System.IO;
using System.Text.RegularExpressions;
using HC.Patient.Model.Image;
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Http.Internal;
using static HC.Common.Enums.CommonEnum;
using HC.Common.Filters;
using JsonApiDotNetCore.Data;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientInsuranceDetailController : JsonApiController<PatientInsuranceDetails, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;


        #region Construtor of the class
        public PatientInsuranceDetailController(
        IJsonApiContext jsonApiContext,
        IResourceService<PatientInsuranceDetails, int> resourceService,
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
        /// this method is used for get patient insurance detail
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
        /// this method is used for save Patient Insurance
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateModel]
        public override async Task<IActionResult> PostAsync([FromBody]PatientInsuranceDetails entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CommonMethods commonMethods = new CommonMethods();
                    ConvertBase64ToImage(entity, commonMethods);
                }
                else
                {
                    Response.StatusCode = 404;//(Not Found)
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
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(int id)
        {

            var asyncPatientInsuranceDetails = await base.GetAsync(id);
            var patientInsuranceDetails = (Entity.PatientInsuranceDetails)((ObjectResult)asyncPatientInsuranceDetails).Value;
            patientInsuranceDetails.IsDeleted = true;
            return await base.PatchAsync(patientInsuranceDetails.Id, patientInsuranceDetails);
        }

        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]PatientInsuranceDetails patientInsuranceDetail)
        {

            CommonMethods commonMethods = new CommonMethods();
            //Convert Base64 to Image
            patientInsuranceDetail = ConvertBase64ToImage(patientInsuranceDetail, commonMethods);
            //For Fornt Image
            if (!string.IsNullOrEmpty(patientInsuranceDetail.InsurancePhotoPathFront) && !string.IsNullOrEmpty(patientInsuranceDetail.InsurancePhotoPathThumbFront))
            {
                AttrAttribute InsurancePhotoPathFront = new AttrAttribute(AttrToUpdate.InsurancePhotoPathFront.ToString(), AttrToUpdate.InsurancePhotoPathFront.ToString());
                AttrAttribute InsurancePhotoPathThumbFront = new AttrAttribute(AttrToUpdate.InsurancePhotoPathThumbFront.ToString(), AttrToUpdate.InsurancePhotoPathThumbFront.ToString());
                _jsonApiContext.AttributesToUpdate.Add(InsurancePhotoPathFront, patientInsuranceDetail.InsurancePhotoPathFront);
                _jsonApiContext.AttributesToUpdate.Add(InsurancePhotoPathThumbFront, patientInsuranceDetail.InsurancePhotoPathThumbFront);
            }
            //For Back Image
            if (!string.IsNullOrEmpty(patientInsuranceDetail.InsurancePhotoPathBack) && !string.IsNullOrEmpty(patientInsuranceDetail.InsurancePhotoPathThumbBack))
            {
                AttrAttribute InsurancePhotoPathBack = new AttrAttribute(AttrToUpdate.InsurancePhotoPathBack.ToString(), AttrToUpdate.InsurancePhotoPathBack.ToString());
                AttrAttribute InsurancePhotoPathThumbBack = new AttrAttribute(AttrToUpdate.InsurancePhotoPathThumbBack.ToString(), AttrToUpdate.InsurancePhotoPathThumbBack.ToString());
                _jsonApiContext.AttributesToUpdate.Add(InsurancePhotoPathBack, patientInsuranceDetail.InsurancePhotoPathBack);
                _jsonApiContext.AttributesToUpdate.Add(InsurancePhotoPathThumbBack, patientInsuranceDetail.InsurancePhotoPathThumbBack);
            }
            var patientInsurance= await base.PatchAsync(id, patientInsuranceDetail);

            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientInsuranceDetailOld = _dbContextResolver.GetDbSet<PatientInsuranceDetails>().Where(m => m.Id == id).FirstOrDefault();
            int eventID = _dbContextResolver.GetDbSet<Event>().LastOrDefault().Id;
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientInsuranceDetailOld, patientInsuranceDetail, "PatientInsuranceDetails", attrToUpdate)
                .Select(q => new AuditLogs()
                { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();


            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);

            return patientInsurance;
        }

            #endregion

            #region Helping Methods
            /// <summary>
            /// this method is used to convert base64 to Images 
            /// </summary>
            /// <param name="entity"></param>
            /// <param name="commonMethods"></param>
            private PatientInsuranceDetails ConvertBase64ToImage(PatientInsuranceDetails entity, CommonMethods commonMethods)
        {
            try
            {
                string webRootPath = "";
#if DEBUG
                webRootPath = Directory.GetCurrentDirectory();
#else
            webRootPath = Directory.GetCurrentDirectory().Replace("HC_Patient", "HC_Photos");
#endif
                if (!Directory.Exists(webRootPath + "\\Images\\PatientInsurancePhotos\\"))
                {
                    Directory.CreateDirectory(webRootPath + "\\Images\\PatientInsurancePhotos\\");
                }
                if (!Directory.Exists(webRootPath + "\\Images\\PatientInsurancePhotos\\thumb\\"))
                {
                    Directory.CreateDirectory(webRootPath + "\\Images\\PatientInsurancePhotos\\thumb\\");
                }

                List<ImageModel> obj = new List<ImageModel>();
                if (!string.IsNullOrEmpty(entity.Base64Front))
                {
                    //getting data from base64 url
                    var base64Datafront = Regex.Match(entity.Base64Front, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                    //getting extension of the image
                    string extensionfront = Regex.Match(entity.Base64Front, @"data:image/(?<type>.+?),(?<data>.+)").Groups["type"].Value.Split(';')[0];
                    extensionfront = "." + extensionfront;

                    string photoConcF = Guid.NewGuid().ToString();

                    //Front
                    ImageModel imgF = new ImageModel();
                    imgF.Base64 = base64Datafront;
                    imgF.ImageUrl = webRootPath + "\\Images\\PatientInsurancePhotos\\pic_" + photoConcF + extensionfront;
                    imgF.ThumbImageUrl = webRootPath + "\\Images\\PatientInsurancePhotos\\thumb\\pic_thumb_" + photoConcF + extensionfront;
                    obj.Add(imgF);

#if DEBUG
                    entity.InsurancePhotoPathFront = imgF.ImageUrl;
                    entity.InsurancePhotoPathThumbFront = imgF.ThumbImageUrl;
#else
                    entity.InsurancePhotoPathFront = "http://108.168.203.227/HC_Photos/Images/PatientInsurancePhotos/pic_" + photoConcF + extensionfront;
                    entity.InsurancePhotoPathThumbFront = "http://108.168.203.227/HC_Photos/Images/PatientInsurancePhotos/thumb/pic_thumb_"+ photoConcF + extensionfront;
#endif
                }

                if (!string.IsNullOrEmpty(entity.Base64Back))
                {
                    //getting data from base64 url
                    var base64Databack = Regex.Match(entity.Base64Back, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                    //getting extension of the image
                    string extensionback = Regex.Match(entity.Base64Back, @"data:image/(?<type>.+?),(?<data>.+)").Groups["type"].Value.Split(';')[0];
                    extensionback = "." + extensionback;

                    string photoConcB = Guid.NewGuid().ToString();
                    ImageModel imgB = new ImageModel();
                    imgB.Base64 = base64Databack;
                    imgB.ImageUrl = webRootPath + "\\Images\\PatientInsurancePhotos\\pic_" + photoConcB + extensionback;
                    imgB.ThumbImageUrl = webRootPath + "\\Images\\PatientInsurancePhotos\\thumb\\pic_thumb_" + photoConcB + extensionback;
                    obj.Add(imgB);

#if DEBUG
                    entity.InsurancePhotoPathBack = imgB.ImageUrl;
                    entity.InsurancePhotoPathThumbBack = imgB.ThumbImageUrl;
#else
         
                    entity.InsurancePhotoPathBack = "http://108.168.203.227/HC_Photos/Images/PatientInsurancePhotos/pic_" + photoConcB + extensionback;
                    entity.InsurancePhotoPathThumbBack = "http://108.168.203.227/HC_Photos/Images/PatientInsurancePhotos/thumb/pic_thumb_"+ photoConcB + extensionback;
#endif
                }

                commonMethods.SaveImageAndThumb(obj);
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        // some custom validation logic
        private bool RequestIsValid() => true;
        #endregion
    }
}