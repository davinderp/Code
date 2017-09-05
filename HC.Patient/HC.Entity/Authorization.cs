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
    public class Authorization : Identifiable<int>, IHasMeta
    {
        public Authorization()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AuthorizationId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [Attr("AuthorizationNumber")]
        public int AuthorizationNumber { get; set; }

        [Attr("StartDate")]
        public DateTime StartDate { get; set; }

        [Attr("EndDate")]
        public DateTime EndDate { get; set; }

        [Attr("Notes")]
        public string Notes { get; set; }

        [Attr("InsuranceCompanyID")]
        [ForeignKey("InsuranceCompanies")]
        public int InsuranceCompanyID { get; set; }

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

        [HasMany("authorizationprocedures")]
        public virtual List<AuthorizationProcedures> AuthorizationProcedures { get; set; }
        [HasOne("patient")]
        public virtual Patients Patient { get; set; }
        [HasOne("insurancecompanies")]
        public virtual InsuranceCompanies InsuranceCompanies { get; set; }
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