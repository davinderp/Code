using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JsonApiDotNetCore.Services;

namespace HC.Patient.Entity
{
    public class UserFavourites : Identifiable<int>, IHasMeta
    {
        public UserFavourites()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Attr("FavouritesID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FavouritesID")]
        public override int Id { get; set; }
        
        [Required]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [Required]
        [Attr("UserID")]
        [ForeignKey("Users")]
        public int UserID { get; set; }

        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Attr("CreatedBy")]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("patient")]
        public virtual Patients Patient { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }


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
