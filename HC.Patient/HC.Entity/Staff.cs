using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class Staff : Identifiable<int>,IHasMeta
    {
        public Staff()
        {


        }

        [Attr("StaffID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("StaffID")]
        public override int Id { get; set; }
        [Attr("ProviderId")]
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }

        [Required]
        [StringLength(50)]
        [Attr("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Attr("MiddleName")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        [Attr("LastName")]
        public string LastName { get; set; }
        [NotMapped]
        public string value { get { return this.FirstName + this.LastName; } }
        [Required]
        [StringLength(500)]
        [Attr("Address")]
        public string Address { get; set; }

        [Required]
        [Attr("Email")]
        [StringLength(256)]
        public string Email { get; set; }
        [Attr("RoleID")]
        [ForeignKey("UserRoles")]
        public int RoleID { get; set; }
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Required]
        [Attr("DeletedBy")]
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        [Attr("CreatedBy")]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }
        [HasOne("userroles")]
        public virtual UserRoles UserRoles { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        [HasMany("phonenumbers")]
        public virtual List<PhoneNumbers> PhoneNumbers { get; set; }
        public virtual Provider Provider { get; set; }
        public Dictionary<string, object> GetMeta(IJsonApiContext context)
        {
            return new Dictionary<string, object> {
                { "total-pages",  context.PageManager.TotalPages },
                { "page-size",  context.PageManager.PageSize },
                { "current-page",  context.PageManager.CurrentPage },
                { "default-page-size",  context.PageManager.DefaultPageSize },
            };
        }
    }
}
