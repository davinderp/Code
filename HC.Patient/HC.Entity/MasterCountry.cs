using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterCountry : Identifiable<int>
    {
        public MasterCountry()
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
        [Column("CountryID")]
        public override int Id { get; set; }
        public string CountryName { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [NotMapped]
        public string value { get { return this.CountryName; } set { this.CountryName = value; } }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        public virtual User Users { get; set; }

        //[NotMapped]
        //[HasMany("masterstate")]
        //public virtual List<MasterState> MasterState { get; set; }
    }

}