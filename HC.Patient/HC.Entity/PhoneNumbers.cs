using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HC.Patient.Entity
{
    public class PhoneNumbers : Identifiable<int>, IHasMeta
    {
        public PhoneNumbers()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PhoneNumberId")]
        public override int Id { get; set; }
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int? PatientID { get; set; }

        [Attr("DoctorID")]
        [ForeignKey("Doctor")]
        public int? DoctorID { get; set; }
        [StringLength(20)]
        [Attr("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PhoneNumberTypeId")]
        [ForeignKey("MasterType")]
        public int PhoneNumberTypeId { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Required]
        [Attr("CreatedBy")]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }



        [HasOne("Patient")]
        public Patients Patient { get; set; }

        [HasOne("Doctor")]
        public Doctors Doctor { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual MasterType MasterType { get; set; }
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
