using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterState : Identifiable<int>
    {
        public MasterState()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("StateID")]
        public override int Id { get; set; }
        [Attr("StateName")]
        [StringLength(50)]
        public string StateName { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.StateName; } set { this.StateName = value; } }
        [StringLength(2)]
        [Attr("StateAbbr")]
        public string StateAbbr { get; set; }
        [Attr("CountryID")]
        [ForeignKey("MasterCountry")]
        public int? CountryID { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        public virtual User Users { get; set; }

        [HasOne("mastercountry")]
        public virtual MasterCountry MasterCountry { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
    }
}