using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterImmunization : Identifiable<int>
    {
        public MasterImmunization()
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
        [Column("ImmunizationID")]
        public override int Id { get; set; }
        [StringLength(50)]
        [Attr("CvxCode")]
        public string CvxCode { get; set; }
        [StringLength(50)]
        [Attr("ShortDesc")]
        public string ShortDesc { get; set; }
        [Attr("VaccineName")]
        public string VaccineName { get; set; }
        [NotMapped]
        public string value { get { return this.VaccineName; } set { this.VaccineName = value; } }
        [Attr("Note")]
        public string Note { get; set; }
        [Attr("VaccineStatus")]
        [StringLength(50)]
        public string VaccineStatus { get; set; }
        [Attr("InternalID")]
        public int? InternalID { get; set; }
        [Attr("NonVaccine")]
        public bool? NonVaccine { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }

}
