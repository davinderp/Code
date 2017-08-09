using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterImmunityStatus : Identifiable<int>
    {
        public MasterImmunityStatus()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ImmunityStatusID")]
        public override int Id { get; set; }
        [StringLength(10)]
        [Attr("ConceptCode")]
        public string ConceptCode { get; set; }
        [Attr("ConceptName")]
        public string ConceptName { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.ConceptName; } set { this.ConceptName = value; } }
        [StringLength(300)]
        [Attr("Defination")]
        public string Defination { get; set; }
        [Attr("HL7Code")]
        [StringLength(50)]
        public string HL7Code { get; set; }
        public int? NIP004 { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }
}
