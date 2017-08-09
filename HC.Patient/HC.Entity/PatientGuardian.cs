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
    public class PatientGuardian : Identifiable<int>, IHasMeta
    {
        public PatientGuardian()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GuardianId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [StringLength(100)]
        public string GuardianFirstName { get; set; }
        [StringLength(100)]
        public string GuardianLastName { get; set; }
        [StringLength(50)]
        public string GuardianMiddleName { get; set; }
        [StringLength(500)]
        public string GuardianAddress1 { get; set; }
        [StringLength(500)]
        public string GuardianAddress2 { get; set; }
        [StringLength(100)]
        public string GuardianCity { get; set; }
        [Attr("GuardianState")]
        [ForeignKey("MasterState")]
        public int? GuardianState { get; set; }
        [StringLength(10)]
        public string GuardianZip { get; set; }
        [StringLength(20)]
        public string GuardianWorkPhone { get; set; }
        [StringLength(20)]
        public string GuardianHomePhone { get; set; }
        [StringLength(20)]
        public string GuardianMobile { get; set; }
        [StringLength(256)]
        public string GuardianEmail { get; set; }
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
        public bool? IsDeleted { get; set; }


        public Patients Patient { get; set; }
        public MasterState MasterState { get; set; }
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