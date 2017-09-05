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
    public class AuthorizationProcedures : Identifiable<int>, IHasMeta
    {
        public AuthorizationProcedures()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AuthorizationProcedureId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("AuthorizationId")]
        [ForeignKey("Authorization")]
        public int AuthorizationId { get; set; }

        [Attr("CPTCodeID")]
        [ForeignKey("MasterCPT")]
        public int CPTCodeID { get; set; }

        [Attr("Unit")]
        public int Unit { get; set; }

        [Attr("TypeID")]
        [ForeignKey("MasterType")]
        public int TypeID { get; set; }

        [Required]
        public bool IsActive { get; set; }
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
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }

        [HasOne("authorization")]
        public virtual Authorization Authorization { get; set; }
        [HasOne("mastertype")]
        public virtual MasterType MasterType { get; set; }
        [HasOne("mastercpt")]
        public virtual MasterCPT MasterCPT { get; set; }
        [HasOne("users")]
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
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