using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterRace : Identifiable<int>
    {
        public MasterRace()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RaceID")]
        [Attr("RaceID")]
        public override int Id { get; set; }
        //public int RaceID { get; set; }
        [Attr("RaceName")]
        public string RaceName { get; set; }
        [NotMapped]
        public string value { get { return this.RaceName; } set { this.RaceName = value; } }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        [Attr("Users")]
        public virtual User Users { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Users1")]
        [Required]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
    }
}