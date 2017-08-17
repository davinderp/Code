using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class AuditLogs : Identifiable<int>, IHasMeta
    {
        public AuditLogs()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AuditLogID")]
        public override int Id { get; set; }
        //public int UserID { get; set; }

        [Attr("PrimaryKeyID")]
        public int PrimaryKeyID { get; set; }
        [Attr("TableName")]
        public string TableName { get; set; }
        [Required]
        [Attr("PropertyName")]
        public string PropertyName { get; set; }
        [Required]
        [Attr("OldValue")]
        public string OldValue { get; set; }
        [Required]
        [Attr("NewValue")]
        public string NewValue { get; set; }

        //[ForeignKey("Event")]
        [Attr("EventID")]
        public int? EventID { get; set; }
        [Required]
        [ForeignKey("User1")]
        [Attr("CreatedBy")]
        public int CreatedBy { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }
        public virtual User Users { get; set; }

        //public virtual Event Event { get; set; }
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
        public User User1 { get; set; }
    }
}
