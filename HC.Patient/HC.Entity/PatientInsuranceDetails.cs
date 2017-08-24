using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class PatientInsuranceDetails : Identifiable<int>, IHasMeta
    {
        public PatientInsuranceDetails()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientInsuranceID")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("InsuranceCompanyID")]
        [ForeignKey("InsuranceCompanies")]
        public int InsuranceCompanyID { get; set; }
        [StringLength(500)]
        [Attr("InsuranceCompanyAddress")]
        public string InsuranceCompanyAddress { get; set; }
        [StringLength(20)]
        [Attr("CarrierPayerID")]
        public string CarrierPayerID { get; set; }
        [StringLength(20)]
        [Attr("TPLCode")]
        public string TPLCode { get; set; }
        [StringLength(20)]
        [Attr("InsuranceIDNumber")]
        public string InsuranceIDNumber { get; set; }
        [StringLength(100)]
        [Attr("InsuranceGroupName")]
        public string InsuranceGroupName { get; set; }
        [StringLength(100)]
        [Attr("InsurancePlanName")]
        public string InsurancePlanName { get; set; }
        [Attr("InsurancePlanTypeID")]
        [ForeignKey("MasterType")]
        public int? InsurancePlanTypeID { get; set; }
        [Attr("InsuranceTypeID")]
        [ForeignKey("MasterType1")]
        public int? InsuranceTypeID { get; set; }
        [StringLength(20)]
        [Attr("InsuranceClaimOfficeNumber")]
        public string InsuranceClaimOfficeNumber { get; set; }
        [Attr("VisitsAllowedPerYear")]
        public int? VisitsAllowedPerYear { get; set; }
        [Attr("CardIssueDate")]
        public DateTime? CardIssueDate { get; set; }
        [StringLength(500)]
        [Attr("Notes")]
        public string Notes { get; set; }    
        [Attr("InsurancePhotoPathFront")]
        public string InsurancePhotoPathFront { get; set; }
        [Attr("InsurancePhotoPathThumbFront")]
        public string InsurancePhotoPathThumbFront { get; set; }
        [NotMapped]
        [Attr("Base64Front")]
        public string Base64Front { get; set; }
        [Attr("InsurancePhotoPathBack")]
        public string InsurancePhotoPathBack { get; set; }
        [Attr("InsurancePhotoPathThumbBack")]
        public string InsurancePhotoPathThumbBack { get; set; }
        [NotMapped]
        [Attr("Base64Back")]
        public string Base64Back { get; set; }
        [Attr("InsurancePersonSameAsPatient")]
        public bool? InsurancePersonSameAsPatient { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Attr("CreatedBy")]
        [ForeignKey("Users")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Attr("UpdatedBy")]
        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public bool? IsVerified { get; set; }


        public virtual Patients Patient { get; set; }
        public virtual InsuranceCompanies InsuranceCompanies { get; set; }
        public virtual MasterType MasterType { get; set; }
        public virtual MasterType MasterType1 { get; set; }
        
        public virtual User Users { get; set; }
        public User Users1 { get; set; }
        public User Users2 { get; set; }
        public Dictionary<string, object> GetMeta(IJsonApiContext context)
        {
            return new Dictionary<string, object> {
                { "total-count",  context.PageManager.TotalRecords },
                { "total-pages",  context.PageManager.TotalPages },
                { "page-size",  context.PageManager.PageSize },
                { "current-page",  context.PageManager.CurrentPage },
                { "default-page-size",  context.PageManager.DefaultPageSize },
            };
        }
    }
}