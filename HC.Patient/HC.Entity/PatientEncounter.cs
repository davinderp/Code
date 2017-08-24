using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class PatientEncounter : Identifiable<int>, IHasMeta
    {
        public PatientEncounter()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientEncounterId")]
        public override int Id { get; set; }
        [Required]
        [RequiredDate]
        [Attr("VisitStartDate")]
        public DateTime VisitStartDate { get; set; }
        [Required]
        [RequiredDate]
        [Attr("VisitEndDate")]
        public DateTime VisitEndDate { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("ClinicianID")]
        [ForeignKey("Clinician")]
        public int ClinicianID { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("CPTID")]
        [ForeignKey("MasterCPT")]
        public int CPTID { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("LocationID")]
        [ForeignKey("MasterLocation")]
        public int LocationID { get; set; }
        [Attr("AppointmentID")]
        [ForeignKey("PatientAppointment")]
        public int AppointmentID { get; set; }

        [Attr("Subjective")]
        public string Subjective { get; set; }
        [Attr("Objective")]
        public string Objective { get; set; }
        [Attr("Assessment")]
        public string Assessment { get; set; }
        [Attr("Plans")]
        public string Plans { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users")]
        [Attr("CreatedBy")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [ForeignKey("Users1")]
        [Attr("UpdatedBy")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }


        //Foreign key's tables
        public Clinicians Clinician { get; set; }
        public Patients Patient { get; set; }
        public MasterCPT MasterCPT { get; set; }
        public MasterLocation MasterLocation { get; set; }
        public PatientAppointment PatientAppointment { get; set; }
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