using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterVFCEligibility : Identifiable<int>
    {
        public MasterVFCEligibility()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("VFCID")]
        public override int Id { get; set; }
        [StringLength(10)]
        [Attr("ConceptCode")]
        public string ConceptCode { get; set; }
        [Attr("ConceptName")]
        public string ConceptName { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.ConceptName; } set { this.ConceptName = value; } }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Users1")]
        [Required]
        public int CreatedBy { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
    }
}
