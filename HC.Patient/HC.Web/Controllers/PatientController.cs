using HC.Common;
using HC.Patient.Entity;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HC.Patient.Model.Image;
using System.Collections.Generic;
using HC.Patient.Service.PatientCommon.Interfaces;
using HC.Patient.Service.PatientCommon;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Model.Patient;
using static HC.Common.CommonMethods;
using JsonApiDotNetCore.Data;
using System.Linq;
using static HC.Common.Enums.CommonEnum;
using JsonApiDotNetCore.Internal.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Internal;
using JsonApiDotNetCore.Models;
using HC.Common.Filters;
using HC.Patient.Data;
using HC.Model;
using System.Net.Http;
using System.Net;
using Audit.WebApi;

namespace HC.Patient.Web.Controllers
{
    //[Authorize("AuthorizedUser")]
    [AuditApi(EventTypeName = "{controller}/{action} ({verb})", IncludeResponseBody = true, IncludeHeaders = true, IncludeModelState = true)]
    public class PatientController : CustomJsonApiController<Patients, int>
    {
        private readonly IDbContextResolver _dbContextResolver;

        public readonly IJsonApiContext _jsonApiContext;

        #region Construtor of the class
        public PatientController(
       IJsonApiContext jsonApiContext,
       IResourceService<Patients, int> resourceService,
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
        /// this method is used for get request for patient
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public override async Task<IActionResult> GetAsync()
        {
            return await CustomFilters();

        }
        [HttpGet("{type}/{id}/{relationshipName}")]
        public async Task<IActionResult> GetRelationshipAsync(string type, int id, string relationshipName)
        {
            return await base.GetRelationshipAsync(id, relationshipName);
        }


        [HttpGet("{type}/{id}/relationships/{relationshipName}")]
        public async Task<IActionResult> GetRelationshipsAsync(string type, int id, string relationshipName)
        {
            return await base.GetRelationshipsAsync(id, relationshipName);
        }

        /// <summary>
        /// this method is used for save patient
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateModel]
        public override async Task<IActionResult> PostAsync(Patients entity)
        {
            try
            {
                Patients newPatinet = new Patients();
                if (ModelState.IsValid)
                {
                    newPatinet = _dbContextResolver.GetDbSet<Patients>().Where(m => m.FirstName == entity.FirstName && m.LastName == entity.LastName && m.PrimaryClinician == entity.PrimaryClinician && m.SSN == entity.SSN).FirstOrDefault();
                    if (newPatinet != null)
                    {
                        Response.StatusCode = 422;//(Unprocessable Entity)
                        return Json(new
                        {
                            data = new object(),
                            Message = "Patient already Exist",
                            StatusCode = 422
                        });
                    }

                    CommonMethods commonMethods = new CommonMethods();
                    ConvertBase64ToImage(entity, commonMethods);
                }
                else
                {
                    Response.StatusCode = 422;//(Unprocessable Entity)
                    return Json(new
                    {
                        data = new object(),
                        Message = "Please check your fields",
                        StatusCode = 422
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

            var asyncPatients = await base.GetAsync(id);
            var patients = (Entity.Patients)((ObjectResult)asyncPatients).Value;
            patients.IsDeleted = true;
            return await base.PatchAsync(patients.Id, patients);
        }
        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(int id, [FromBody]Patients patientInfo)
        {
           // var attrToUpdate= _jsonApiContext.AttributesToUpdate;
           //var patientInfoOld =  _dbContextResolver.GetDbSet<Patients>().Where(m => m.Id == id).FirstOrDefault();

            CommonMethods commonMethods = new CommonMethods();

            if (!string.IsNullOrEmpty(patientInfo.PhotoBase64))
            {
                patientInfo = ConvertBase64ToImage(patientInfo, commonMethods);
                if (!string.IsNullOrEmpty(patientInfo.PhotoPath) && !string.IsNullOrEmpty(patientInfo.PhotoThumbnailPath))
                {
                    AttrAttribute photoPath = new AttrAttribute(AttrToUpdate.PhotoPath.ToString(), AttrToUpdate.PhotoPath.ToString());
                    AttrAttribute photoThumbnailPath = new AttrAttribute(AttrToUpdate.PhotoThumbnailPath.ToString(), AttrToUpdate.PhotoThumbnailPath.ToString());

                    _jsonApiContext.AttributesToUpdate.Add(photoPath, patientInfo.PhotoPath);
                    _jsonApiContext.AttributesToUpdate.Add(photoThumbnailPath, patientInfo.PhotoThumbnailPath);
                }
            }
            //var patientDetails = await base.PatchAsync(id, patientInfo);

            //int eventID = _dbContextResolver.GetDbSet<Event>().AsQueryable().OrderByDescending(p => p.Id).FirstOrDefault().Id + 1;
            //List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientInfoOld, patientInfo, "Patients", attrToUpdate)
            //    //.Where(i=> attrToUpdate.Keys.Any(a1 =>  a1.InternalAttributeName == i.PropertyName))
            //    .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID, TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            //await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, patientInfo);
        }
        #endregion

        #region Helping Methods
        /// <summary>
        /// this method is used for get the custom filter
        /// </summary>
        /// <returns></returns>
        private async Task<IActionResult> CustomFilters()
        {
            bool IsSearchKey = false;
            bool IsStartWith = false;

            FilterQuery filterQuery = new FilterQuery("", "", "");
            if (_jsonApiContext.QuerySet != null && _jsonApiContext.QuerySet.Filters != null)
            {
                _jsonApiContext.QuerySet.Filters.ForEach(p => { if (p.Key.ToUpper() == PatientSearch.SEARCHKEY.ToString()) { IsSearchKey = true; filterQuery = p; } });
                _jsonApiContext.QuerySet.Filters.ForEach(p => { if (p.Key.ToUpper() == PatientSearch.STARTWITH.ToString()) { IsStartWith = true; filterQuery = p; } });
                if (IsSearchKey)
                {

                    List<Patients> patients = new List<Patients>();
                    CommonMethods commonMethods = new CommonMethods();
                    var type = commonMethods.ParseString(filterQuery.Value);
                    if (type == DataType.System_String || type == DataType.System_Int32 || type == DataType.System_Int64)
                    {
                        patients = _jsonApiContext.GetDbContextResolver().GetDbSet<Patients>().Where(l => l.FirstName.ToUpper().Contains(filterQuery.Value.ToUpper()) ||
                        l.LastName.ToUpper().Contains(filterQuery.Value.ToUpper()) || l.MiddleName.ToUpper().Contains(filterQuery.Value.ToUpper()) ||
                        l.SSN.ToUpper().Contains(filterQuery.Value.ToUpper())).ToList();
                        _jsonApiContext.QuerySet.Filters.Remove(filterQuery);
                    }
                    else if (type == DataType.System_DateTime)
                    {
                        patients = DateFilter(filterQuery, patients);

                    }
                    patients = CustomSorting(patients);
                    if (_jsonApiContext.QuerySet.PageQuery.PageSize != 0)
                    {
                        patients = patients.Take(_jsonApiContext.QuerySet.PageQuery.PageSize).ToList();
                    }
                    var asyncPatients = await base.GetAsync();

                    patients.ForEach(p => p.GenderValue = _jsonApiContext.GetDbContextResolver().GetDbSet<MasterGender>().Where(o => o.Id == p.Gender).FirstOrDefault().Gender);
                    ((ObjectResult)asyncPatients).Value = patients;
                    _jsonApiContext.PageManager.TotalRecords = patients.Count();

                    return asyncPatients;
                }
                if (IsStartWith)
                {

                    List<Patients> patients = new List<Patients>();
                    CommonMethods commonMethods = new CommonMethods();
                    var type = commonMethods.ParseString(filterQuery.Value);
                    if (type == DataType.System_String || type == DataType.System_Int32 || type == DataType.System_Int64)
                    {
                        patients = _jsonApiContext.GetDbContextResolver().GetDbSet<Patients>().Where(l => l.FirstName.ToUpper().StartsWith(filterQuery.Value.ToUpper())).ToList();
                        _jsonApiContext.QuerySet.Filters.Remove(filterQuery);
                    }
                    else if (type == DataType.System_DateTime)
                    {
                        patients = DateFilter(filterQuery, patients);

                    }
                    patients = CustomSortingForStartWith(patients);
                    if (_jsonApiContext.QuerySet.PageQuery.PageSize != 0)
                    {
                        patients = patients.Take(_jsonApiContext.QuerySet.PageQuery.PageSize).ToList();
                    }
                    var asyncPatients = await base.GetAsync();

                    patients.ForEach(p => p.GenderValue = _jsonApiContext.GetDbContextResolver().GetDbSet<MasterGender>().Where(o => o.Id == p.Gender).FirstOrDefault().Gender);
                    ((ObjectResult)asyncPatients).Value = patients;
                    _jsonApiContext.PageManager.TotalRecords = patients.Count();

                    return asyncPatients;
                }
                else
                {
                    return await base.GetAsync();
                }

            }
            else
            {
                return await base.GetAsync();
            }
        }
        private List<Patients> CustomSortingForStartWith(List<Patients> patients)
        {   if (patients.Count > 0)
            {
                patients = patients.OrderByDescending(a => a.CreatedDate).ToList();
            }
            return patients;
        }
            private List<Patients> CustomSorting(List<Patients> patients)
        {
            if (_jsonApiContext.QuerySet.SortParameters != null)
            {
                _jsonApiContext.QuerySet.SortParameters.ForEach(i =>
                {
                    if (i.Direction == SortDirection.Ascending)
                        switch ((PatientSearch)Enum.Parse(typeof(PatientSearch), i.SortedAttribute.InternalAttributeName.ToString().ToUpper()))
                        {
                            case PatientSearch.ID:
                                patients = patients.OrderBy(m => m.Id).ToList();
                                break;
                            case PatientSearch.CLINICIANNAME:
                                patients = patients.OrderBy(m => m.ClinicianName).ToList();
                                break;
                            case PatientSearch.FIRSTNAME:
                                patients = patients.OrderBy(m => m.FirstName).ToList();
                                break;
                            case PatientSearch.LASTNAME:
                                patients = patients.OrderBy(m => m.LastName).ToList();
                                break;
                            case PatientSearch.GENDER:
                                patients = patients.OrderBy(m => m.Gender).ToList();
                                break;
                            case PatientSearch.SSN:
                                patients = patients.OrderBy(m => m.SSN).ToList();
                                break;
                            case PatientSearch.DOB:
                                patients = patients.OrderBy(m => m.DOB).ToList();
                                break;
                            case PatientSearch.PATIENTINSURANCE:
                                patients = patients.OrderBy(m => m.PatientInsurance).ToList();
                                break;


                        }
                    else if (i.Direction == SortDirection.Descending)
                        switch ((PatientSearch)Enum.Parse(typeof(PatientSearch), i.SortedAttribute.InternalAttributeName.ToString().ToUpper()))
                        {
                            case PatientSearch.ID:
                                patients = patients.OrderByDescending(m => m.Id).ToList();
                                break;
                            case PatientSearch.CLINICIANNAME:
                                patients = patients.OrderByDescending(m => m.ClinicianName).ToList();
                                break;
                            case PatientSearch.FIRSTNAME:
                                patients = patients.OrderByDescending(m => m.FirstName).ToList();
                                break;
                            case PatientSearch.LASTNAME:
                                patients = patients.OrderByDescending(m => m.LastName).ToList();
                                break;
                            case PatientSearch.GENDER:
                                patients = patients.OrderByDescending(m => m.Gender).ToList();
                                break;
                            case PatientSearch.SSN:
                                patients = patients.OrderByDescending(m => m.SSN).ToList();
                                break;
                            case PatientSearch.DOB:
                                patients = patients.OrderByDescending(m => m.DOB).ToList();
                                break;
                            case PatientSearch.PATIENTINSURANCE:
                                patients = patients.OrderByDescending(m => m.PatientInsurance).ToList();
                                break;
                        }
                });
            }

            return patients;
        }

        private List<Patients> DateFilter(FilterQuery filterQuery, List<Patients> patients)
        {
            DateTime searchDate = new DateTime();
            DateTime.TryParse(filterQuery.Value, out searchDate);

            switch ((PatientSearch)Enum.Parse(typeof(PatientSearch), filterQuery.Operation.ToUpper()))
            {
                case PatientSearch.FROMDATE:
                    patients = _jsonApiContext.GetDbContextResolver().GetDbSet<Patients>().Where(o => o.CreatedDate >= searchDate).ToList();
                    _jsonApiContext.QuerySet.Filters.Remove(filterQuery);
                    break;
                case PatientSearch.TODATE:
                    patients = _jsonApiContext.GetDbContextResolver().GetDbSet<Patients>().Where(o => o.CreatedDate <= searchDate).ToList();
                    _jsonApiContext.QuerySet.Filters.Remove(filterQuery);
                    break;
                case PatientSearch.FROMDOB:
                    patients = _jsonApiContext.GetDbContextResolver().GetDbSet<Patients>().Where(o => o.DOB >= searchDate).ToList();
                    _jsonApiContext.QuerySet.Filters.Remove(filterQuery);
                    break;
                case PatientSearch.TODOB:
                    patients = _jsonApiContext.GetDbContextResolver().GetDbSet<Patients>().Where(o => o.DOB <= searchDate).ToList();
                    _jsonApiContext.QuerySet.Filters.Remove(filterQuery);
                    break;
            }

            return patients;
        }

        // some custom validation logic


        private Patients ConvertBase64ToImage(Patients entity, CommonMethods commonMethods)
        {
            try
            {
                if (!string.IsNullOrEmpty(entity.PhotoBase64))
                {
                    string webRootPath = "";
#if DEBUG
                    webRootPath = Directory.GetCurrentDirectory();
#else
            webRootPath = Directory.GetCurrentDirectory().Replace("HC_Patient", "HC_Photos");
#endif

                    //getting data from base64 url
                    var base64Data = Regex.Match(entity.PhotoBase64, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                    //getting extension of the image
                    string extension = Regex.Match(entity.PhotoBase64, @"data:image/(?<type>.+?),(?<data>.+)").Groups["type"].Value.Split(';')[0];

                    extension = "." + extension;
                    if (!Directory.Exists(webRootPath + "\\Images\\PatientPhotos\\"))
                    {
                        Directory.CreateDirectory(webRootPath + "\\Images\\PatientPhotos\\");
                    }
                    if (!Directory.Exists(webRootPath + "\\Images\\PatientPhotos\\thumb\\"))
                    {
                        Directory.CreateDirectory(webRootPath + "\\Images\\PatientPhotos\\thumb\\");
                    }
                    string photoConc = Guid.NewGuid().ToString();

                    List<ImageModel> obj = new List<ImageModel>();

                    ImageModel img = new ImageModel();

                    img.Base64 = base64Data;
                    img.ImageUrl = webRootPath + "\\Images\\PatientPhotos\\Patientphoto_" + photoConc + extension;
                    img.ThumbImageUrl = webRootPath + "\\Images\\PatientPhotos\\thumb\\pic_thumb_" + photoConc + extension;
                    obj.Add(img);

                    commonMethods.SaveImageAndThumb(obj);
#if DEBUG
                    entity.PhotoPath = webRootPath + "\\Images\\PatientPhotos\\Patientphoto_" + photoConc + extension;
                    entity.PhotoThumbnailPath = webRootPath + "\\Images\\PatientPhotos\\thumb\\pic_thumb_" + photoConc + extension;
#else
            entity.PhotoPath = "http://108.168.203.227/HC_Photos/Images/PatientPhotos/Patientphoto_" + photoConc + extension;
            entity.PhotoThumbnailPath = "http://108.168.203.227/HC_Photos/Images/PatientPhotos/thumb/pic_thumb_" + photoConc + extension;
#endif              
                }
            }
            catch (Exception)
            {
                throw;
            }

            return entity;

        }

        #endregion

    }
}