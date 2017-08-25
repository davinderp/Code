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
    public class PatientVitals : Identifiable<int>, IHasMeta
    {
        public PatientVitals()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientVitalId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }        
        [Required]
        [RequiredNumber]
        [Attr("BPDiastolic")]
        public int BPDiastolic { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("BPSystolic")]
        public int BPSystolic { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("HeightFt")]
        public double HeightFt { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("HeightIn")]
        public double HeightIn { get; set; }
        //[Attr("Height_cm")]
        //public double Height_cm { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("WeightLbs")]
        public double WeightLbs { get; set; }
        //[Attr("Weight_kg")]
        //public double Weight_kg { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("HeartRate")]
        public int HeartRate { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("Pulse")]
        public int Pulse { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("Respiration")]
        public int Respiration { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("BMI")]
        public double BMI { get; set; }
        //[Attr("BMI_Status")]
        //public string BMI_Status { get; set; }
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
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        [Attr("IsActive")]
        [Required]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }       

        [HasOne("Patient")]
        public virtual Patients Patient { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }

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
