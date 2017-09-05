using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterReaction : Identifiable<int>
    {
        public MasterReaction()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ReactionID")]
        public override int Id { get; set; }
        [Attr("Reaction")]
        public string Reaction { get; set; }
        [NotMapped]
        public string value { get { return this.Reaction; } set { this.Reaction = value; } }
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
