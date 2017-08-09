using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterPatientCommPreferences : Identifiable<int>
    {
        public MasterPatientCommPreferences()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientCommPreferencesID")]
        public override int Id { get; set; }
        //public int LanguageID { get; set; }
        public string PatientCommPreferences { get; set; }
        [NotMapped]
        public string value { get { return this.PatientCommPreferences; } set { this.PatientCommPreferences = value; } }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Users1")]
        [Required]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
    }
}