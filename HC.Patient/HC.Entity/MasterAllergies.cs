using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterAllergies : Identifiable<int>
    {
        public MasterAllergies()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AllergyID")]
        public override int Id { get; set; }
        [Attr("AllergyType")]
        public string AllergyType { get; set; }
        [NotMapped]
        public string value { get { return this.AllergyType; } set { this.AllergyType = value; } }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        public virtual User Users { get; set; }
       
        public virtual User Users1 { get; set; }
    }

}
