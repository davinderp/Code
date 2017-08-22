using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class Organization : Identifiable<int>, IHasMeta
    {
        public Organization()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;

        }
        [Attr("OrganizationID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrganizationID")]
        public override int Id { get; set; }

        [Required]
        [Attr("OrganizationName")]
        [MaxLength(100)]
        public string OrganizationName { get; set; }

        [Required]
        [Attr("OrganizationDescription")]
        [MaxLength(1000)]
        public string OrganizationDescription { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        //[ForeignKey("Users2")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

       // [ForeignKey("Users")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //[ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }


        [HasMany("organizationconnectionstring")]
        public virtual OrganizationConnectionstring OrganizationConnectionstring { get; set; }

        //[HasOne("users")]
        //public virtual User Users { get; set; }
        //public virtual User Users1 { get; set; }
        //public virtual User Users2 { get; set; }
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
