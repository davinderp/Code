using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HC.Patient.Entity
{
    public class Provider : Identifiable<int>, IHasMeta
    {
        public Provider()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProviderId")]
        [Attr("ProviderId")]
        public override int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Attr("ProviderName")]
        public string ProviderName { get; set; }
        [NotMapped]
        public string value { get { return this.ProviderName; } set { this.ProviderName = value; } }
        [Required]
        [StringLength(500)]
        public string ProviderAddress { get; set; }        
        [Required]
        [Attr("ProviderEmail")]
        [StringLength(256)]
        public string ProviderEmail { get; set; }
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Required]
        [Attr("DeletedBy")]
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        [Attr("CreatedBy")]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        //public PhoneNumbers PhoneNumbers { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        [HasMany("phonenumbers")]
        public virtual List<PhoneNumbers> PhoneNumbers { get; set; }
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
