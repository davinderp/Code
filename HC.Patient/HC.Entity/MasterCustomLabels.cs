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
    public class MasterCustomLabels : Identifiable<int>, IHasMeta
    {
        public MasterCustomLabels()
        {
        }
        [Attr("CustomLabelID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomLabelID")]
        public override int Id { get; set; }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [Required]
        [Attr("CustomLabelName")]
        [MaxLength(100)]
        public string CustomLabelName { get; set; }

        [Required]
        [Attr("CustomLabelTypeID")]
        [ForeignKey("MasterType")]
        public int CustomLabelTypeID { get; set; }

        //[NotMapped]
        //[Attr("CustomLabelTypeName")]
        //[MaxLength(200)]
        //public string CustomLabelTypeName
        //{
        //    get
        //    {
        //        try
        //        {
        //            return this.MasterType.TypeName;
        //        }
        //        catch (Exception)
        //        {

        //            return null;
        //        }
        //    }
        //    set
        //    {
        //        try
        //        {
        //            this.CustomLabelTypeName = this.MasterType.TypeName;
        //        }
        //        catch (Exception)
        //        {

        //            this.CustomLabelTypeName = null;
        //        }

        //    }
        //}

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
        [HasOne("MasterType")]
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
