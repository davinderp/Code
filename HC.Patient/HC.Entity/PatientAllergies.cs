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
    public class PatientAllergies : Identifiable<int>, IHasMeta
    {
        public PatientAllergies()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientAllergyId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Attr("AllergyTypeID")]
        [ForeignKey("MasterAllergies")]
        public int AllergyTypeID { get; set; }
        [StringLength(100)]
        [Attr("Allergen")]
        public string Allergen { get; set; }
        [StringLength(100)]
        [Attr("Source")]
        public string Source { get; set; }
        [StringLength(100)]
        [Attr("Reaction")]
        public string Reaction { get; set; }        
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
        public bool? IsVerified { get; set; }
        public bool? IsDeleted { get; set; }




        [HasOne("patient")]
        public Patients Patient { get; set; }
        [HasOne("masterallergies")]
        public MasterAllergies MasterAllergies { get; set; }
        public virtual User Users { get; set; }
        public User Users1 { get; set; }
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