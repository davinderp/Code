using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterStatus : Identifiable<int>
    {
        public MasterStatus()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("StatusID")]
        public override int Id { get; set; }        
        public string StatusName { get; set; }
        [NotMapped]
        public string value { get { return this.StatusName; } set { this.StatusName = value; } }
        public string Type { get; set; }
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