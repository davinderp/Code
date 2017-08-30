using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class InsuranceCompanies : Identifiable<int>, IHasMeta
    {
        public InsuranceCompanies()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("InsuranceCompanyId")]
        public override int Id  { get; set; }
        [Attr("CompanyName")]
        public string CompanyName { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.CompanyName; } set { this.CompanyName = value; } }
        [Attr("CompanyAddress")]
        public string CompanyAddress { get; set; }
        [Attr("CompanyPhone")]
        public string CompanyPhone { get; set; }
        [Attr("CompanyEmail")]
        public string CompanyEmail { get; set; }
        [StringLength(20)]
        [Attr("CarrierPayerID")]
        public string CarrierPayerID { get; set; }
        [StringLength(20)]
        [Attr("TPLCode")]
        public string TPLCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }
        public virtual User Users { get; set; }
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