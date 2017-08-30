using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class PatientImmunization : Identifiable<int>, IHasMeta
    {
        public PatientImmunization()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ImmunizationId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }




        [Attr("OrderBy")]
        [ForeignKey("Clinician")]
        public int? OrderBy { get; set; }
        [Attr("VFCID")]
        [ForeignKey("MasterVFCEligibility")]
        public int? VFCID { get; set; }


        [Required]
        [RequiredDate]
        [Attr("AdministeredDate")]        
        public DateTime AdministeredDate { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("Immunization")]
        [ForeignKey("MasterImmunization")]
        public int Immunization { get; set; }



        [Attr("AmountAdministered")]
        public int? AmountAdministered { get; set; }
        [Attr("ManufactureID")]
        [ForeignKey("MasterManufacture")]
        public int? ManufactureID { get; set; }


        [Required]
        [RequiredDate]
        [Attr("ExpireDate")]
        public DateTime ExpireDate   { get; set; }
        [Attr("VaccineLotNumber")]        
        public string VaccineLotNumber { get; set; }


        [Attr("AdministrationSiteID")]
        [ForeignKey("MasterAdministrationSite")]
        public int? AdministrationSiteID { get; set; }
        [Attr("RouteOfAdministrationID")]
        [ForeignKey("MasterRouteOfAdministration")]
        public int? RouteOfAdministrationID { get; set; }


        [Attr("AdministeredBy")]
        [ForeignKey("Clinician1")]
        public int? AdministeredBy { get; set; }
        [Attr("ImmunityStatusID")]
        [Required]
        [RequiredNumber]

        [ForeignKey("MasterImmunityStatus")]
        public int ImmunityStatusID { get; set; }

        [Required]
        [Attr("RejectedImmunization")]        
        public bool RejectedImmunization { get; set; }
        [Attr("RejectionReasonID")]
        [ForeignKey("MasterRejectionReason")]
        public int? RejectionReasonID { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Users")]
        [Required]
        [RequiredNumber]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Foreign key's tables
        /// </summary>
        public Patients Patient { get; set; }
        public Clinicians Clinician { get; set; }
        public MasterVFCEligibility MasterVFCEligibility { get; set; }
        [HasOne("masterimmunization")]
        public MasterImmunization MasterImmunization { get; set; }
        public MasterManufacture MasterManufacture { get; set; }
        public MasterAdministrationSite MasterAdministrationSite { get; set; }
        public MasterRouteOfAdministration MasterRouteOfAdministration { get; set; }
        public Clinicians Clinician1 { get; set; }
        public MasterImmunityStatus MasterImmunityStatus { get; set; }
        public MasterRejectionReason MasterRejectionReason { get; set; }
        public virtual User Users { get; set; }
        public User Users1 { get; set; }
        public User Users2 { get; set; }
        public Dictionary<string, object> GetMeta(IJsonApiContext context)
        {
            return new Dictionary<string, object> {
                //{ "total-count",  context.PageManager.TotalRecords },
                { "total-pages",  context.PageManager.TotalPages },
                { "page-size",  context.PageManager.PageSize },
                { "current-page",  context.PageManager.CurrentPage },
                { "default-page-size",  context.PageManager.DefaultPageSize },
            };
        }
    }
}