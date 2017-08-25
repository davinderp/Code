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
    public class Location : Identifiable<int>, IHasMeta
    {
        public Location()
        {
        }
        [Attr("LocationID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LocationID")]
        public override int Id { get; set; }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [Required]
        [Attr("LocationName")]
        [MaxLength(100)]
        public string LocationName { get; set; }

        [Required]
        [Attr("LocationDescription")]
        [MaxLength(1000)]
        public string LocationDescription { get; set; }
        
        [Attr("Address")]
        [StringLength(200)]
        public string Address { get; set; }
        [Attr("City")]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("StateID")]
        [ForeignKey("MasterState")]
        public int StateID { get; set; }

        [Attr("Zip")]
        [StringLength(20)]
        public string Zip { get; set; }
        [Attr("Phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("CountryID")]
        [ForeignKey("MasterCountry")]
        public int CountryID { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Attr("CreatedBy")]
        public int CreatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        //[ForeignKey("Users2")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }        
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        [HasOne("Organization")]
        public virtual Organization Organization { get; set; }
        public virtual MasterCountry MasterCountry { get; set; }
        public virtual MasterState MasterState { get; set; }
        //public virtual User Users1 { get; set; }
        //public virtual User Users2 { get; set; }
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
