using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class PatientLabTest : Identifiable<int>, IHasMeta
    {
        public PatientLabTest()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TestId")]
        public override int Id { get; set; }
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Attr("TestName")]
        [StringLength(100)]
        [Required]
        public string TestName { get; set; }
        [Attr("TestTypeID")]
        [ForeignKey("MasterTestType")]
        [Required(ErrorMessage = "Please select one Test Type")]
        public int TestTypeID { get; set; }
        [Attr("LonicCodeID")]
        [ForeignKey("MasterLonic")]
        public int LonicCodeID { get; set; }
        [Attr("ScheduledDate")]
        [Required(ErrorMessage = "Please select ScheduledDate")]
        public DateTime ScheduledDate { get; set; }
        [Attr("LabName")]
        [Required(ErrorMessage = "Please select Lab Name")]
        [ForeignKey("MasterLabs")]
        public int LabName { get; set; }
        [Attr("Ordered")]
        public bool Ordered { get; set; }
        [Attr("OrderBy")]
        [ForeignKey("Provider")]
        public int? OrderBy { get; set; }
        [Attr("OrderDate")]        
        public DateTime OrderDate { get; set; }
        [Attr("TestSpecimenSource")]
        [StringLength(200)]
        public string TestSpecimenSource { get; set; }
        [Attr("ConditionOfSpecimen")]
        [StringLength(200)]
        public string ConditionOfSpecimen { get; set; }
        [Attr("TimeTypeID")]
        [ForeignKey("MasterTimeType")]        
        public int TimeTypeID { get; set; }
        [Attr("FrequencyID")]
        [ForeignKey("MasterFrequencyType")]
        public int FrequencyID { get; set; }
        [Attr("FrequencyDuration")]
        [StringLength(100)]
        public string FrequencyDuration { get; set; }
        [Attr("FrequencyDurationID")]
        [ForeignKey("MasterDurationType")]
        public int FrequencyDurationID { get; set; }
        [Attr("Notes")]
        public string Notes { get; set; }
        //

        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Users")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        //Foreign key's tables
        public virtual Patients Patient { get; set; }
        [HasOne("masteralcohal")]
        public virtual MasterType MasterTestType { get; set; }
        [HasOne("mastertobacco")]
        public virtual MasterLonic MasterLonic { get; set; }
        [HasOne("masterlabs")]
        public virtual MasterLabs MasterLabs { get; set; }

        [HasOne("provider")]
        public virtual Provider Provider { get; set; }
        [HasOne("mastertimetype")]
        public virtual MasterType MasterTimeType { get; set; }
        [HasOne("masterfrequencytype")]
        public virtual MasterType MasterFrequencyType { get; set; }
        [HasOne("masterdurationtype")]
        public virtual MasterType MasterDurationType { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }
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