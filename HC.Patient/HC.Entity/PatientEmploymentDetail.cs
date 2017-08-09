using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class PatientEmploymentDetail : Identifiable<int>, IHasMeta
    {
        public PatientEmploymentDetail()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientEmplomentID")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [StringLength(100)]
        public string Employer { get; set; }
        [Attr("Occupation")]
        [ForeignKey("MasterOccupation")]        
        public int? Occupation { get; set; }
        [Attr("EmploymentStatus")]
        [ForeignKey("MasterStatus")]
        public int? EmploymentStatus { get; set; }
        [StringLength(20)]
        public string WorkPhone { get; set; }
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
        public MasterOccupation MasterOccupation { get; set; }
        public MasterStatus MasterStatus { get; set; }
        public virtual User Users { get; set; }
        public User Users1 { get; set; }
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