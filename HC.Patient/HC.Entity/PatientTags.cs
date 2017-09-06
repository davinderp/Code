using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JsonApiDotNetCore.Services;

namespace HC.Patient.Entity
{
    public class PatientTags : Identifiable<int>, IHasMeta
    {
        public PatientTags()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Attr("PatientTagID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientTagID")]
        public override int Id { get; set; }
        
        [Required]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [Required]
        [Attr("TagID")]
        [ForeignKey("MasterTags")]
        public int TagID { get; set; }

        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Attr("CreatedBy")]
        [ForeignKey("Users")]
        public int CreatedBy { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users1")]
        public int? DeletedBy { get; set; }
        [Attr("DeletedDate")]
        public DateTime? DeletedDate { get; set; }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("patient")]
        public virtual Patients Patient { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }
        [HasOne("mastertags")]
        public virtual MasterTags MasterTags { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }


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
