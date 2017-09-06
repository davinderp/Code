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
    public class PatientCustomLabels : Identifiable<int>, IHasMeta
    {
        public PatientCustomLabels()
        {
        }
        [Attr("PatientCustomLabelID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientCustomLabelID")]
        public override int Id { get; set; }

        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patients")]
        public int? PatientID { get; set; }

        [RequiredNumber]
        [Attr("CustomLabelID")]
        [ForeignKey("MasterCustomLabels")]
        public int CustomLabelID { get; set; }

        [Required]
        [Attr("CustomLabelValue")]
        public string CustomLabelValue { get; set; }

        [Required]
        [Attr("CustomLabelDataType")]
        public string CustomLabelDataType { get; set; }
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
        [HasOne("MasterCustomLabels")]
        public virtual MasterCustomLabels MasterCustomLabels { get; set; }
        [HasOne("patient")]
        public virtual Patients Patients { get; set; }
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
