using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace HC.Patient.Entity
{
    public class User : Identifiable<int>, IHasMeta
    {
        public User()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserID")]
        public override int Id { get; set; }
        //public int UserID { get; set; }
        [Required]
        [ForeignKey("User1")]
        [Attr("CreatedBy")]
        public int CreatedBy { get; set; }
        [Attr("UserName")]
        public string UserName { get; set; }
        [Attr("Password")]
        public string Password { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("UserRoles")]
        [Attr("RoleID")]
        public int RoleID { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
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
        public User User1 { get; set; }
        public UserRoles UserRoles { get; set; }
    }
}
