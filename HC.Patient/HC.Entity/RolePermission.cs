using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class RolePermission : Identifiable<int>
    {
        public RolePermission()
        {   
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RolePermissionID")]
        public override int Id { get; set; }
        [Attr("CreatePermission")]
        public bool CreatePermission { get; set; }
        [Attr("ViewPermission")]
        public bool ViewPermission { get; set; }
        [Attr("EditPermission")]
        public bool EditPermission { get; set; }
        [Attr("DeletePermission")]
        public bool DeletePermission { get; set; }
        [Attr("RoleID")]
        [ForeignKey("UserRoles")]
        public int RoleID { get; set; }
        [Attr("ModuleID")]
        [ForeignKey("Modules")]
        public int ModuleID { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        //Foreign key table
        [HasOne("userroles")]
        public virtual UserRoles UserRoles { get; set; }
        [HasOne("modules")]
        public virtual Modules Modules { get; set; }

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