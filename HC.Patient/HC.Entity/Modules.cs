using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JsonApiDotNetCore.Services;

namespace HC.Patient.Entity
{
    public class Modules : Identifiable<int>, IHasMeta
    {

        [Attr("ModuleID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ModuleID")]
        public override int Id { get; set; }

        [StringLength(100)]
        [Attr("ModuleName")]
        public string ModuleName { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }        

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }        

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
