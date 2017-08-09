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
    public class PatientPastIllness : Identifiable<int>, IHasMeta
    {
        public PatientPastIllness()
        {
            //this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PastIllnessId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Attr("Illness")]   
        [StringLength(300)]
        public string Illness { get; set; }
        [Attr("StatusID")]
        [Required]
        [RequiredNumber]
        [ForeignKey("MasterStatus")]
        public int StatusID { get; set; }
        [Required]
        [RequiredDate]
        [Attr("DiagnosisDate")]        
        public DateTime DiagnosisDate { get; set; }

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
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }        

        [HasOne("Patient")]
        public virtual Patients Patient { get; set; }
        public virtual MasterStatus MasterStatus { get; set; }
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
