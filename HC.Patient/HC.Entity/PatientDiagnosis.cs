using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HC.Patient.Entity
{
    public class PatientDiagnosis : Identifiable<int>, IHasMeta
    {
        public PatientDiagnosis()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientDiagnosisId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("ICDID")]
        [ForeignKey("MasterICD")]
        public int ICDID { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("DiagnosisDate")]
        public DateTime DiagnosisDate { get; set; }
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
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        //Foreign key's tables
        public Patients Patient { get; set; }
        [HasOne("mastericd")]
        public MasterICD MasterICD { get; set; }
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