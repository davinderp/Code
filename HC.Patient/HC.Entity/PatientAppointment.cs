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
    public class PatientAppointment : Identifiable<int>, IHasMeta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientAppointmentId")]
        public override int Id { get; set; }

        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [Required]
        [RequiredNumber]
        [Attr("ClinicianID")]
        [ForeignKey("Clinician")]
        public int ClinicianID { get; set; }

        [RequiredDate]
        [Attr("StartDateTime")]
        public DateTime StartDateTime { get; set; }

        [RequiredDate]
        [Attr("EndDateTime")]
        public DateTime EndDateTime { get; set; }
        [Required]
        [Attr("Description")]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users")]
        [Attr("CreatedBy")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Attr("UpdatedBy")]
        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Attr("AppointmentTypeID")]
        [ForeignKey("AppointmentType")]
        public int AppointmentTypeID { get; set; }

        //[Attr("AppointmentRecurrenceID")]
        //[ForeignKey("MasterRecurrence")]
        //public int AppointmentRecurrenceID { get; set; }

        //Foreign key's tables
        [HasOne("Patient")]
        public virtual Patients Patient { get; set; }
        [HasOne("Users")]
        public virtual User Users { get; set; }
        [HasOne("Users1")]
        public virtual User Users1 { get; set; }
        [HasOne("Users2")]
        public virtual User Users2 { get; set; }
        [HasOne("Clinician")]
        public virtual Clinicians Clinician { get; set; }
        [HasOne("AppointmentType")]
        public virtual AppointmentType AppointmentType { get; set; }
        //[HasOne("MasterRecurrence")]
        //public virtual MasterType MasterRecurrence { get; set; }

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
