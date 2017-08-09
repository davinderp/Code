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
    public class PatientDocuments : Identifiable<int>, IHasMeta
    {
        public PatientDocuments()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientDocumentId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Attr("DocumentType")]
        [ForeignKey("MasterType")]
        public int? DocumentType { get; set; }
        [StringLength(100)]
        public String DocumentName { get; set; }
        [StringLength(50)]
        public String DocumentNumber { get; set; }
        [Attr("State")]
        [ForeignKey("MasterState")]
        public int? State { get; set; }
        public DateTime? Expiration { get; set; }        
        public string UploadPath { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Users")]
        [Required]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        public bool? IsVerified { get; set; }
        public bool? IsDeleted { get; set; }



        public Patients Patient { get; set; }
        public MasterType MasterType { get; set; }
        public MasterState MasterState { get; set; }
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