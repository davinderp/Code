using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterEthnicity : Identifiable<int>
    {
        public MasterEthnicity()
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
        [Column("EthnicityID")]
        public override int Id { get; set; }
        [Attr("EthnicityName")]
        public string EthnicityName { get; set; }
        [NotMapped]
        public string value { get { return this.EthnicityName; } set { this.EthnicityName = value; } }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }
}