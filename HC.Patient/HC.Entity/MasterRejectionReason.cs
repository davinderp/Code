using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterRejectionReason : Identifiable<int>
    {
        public MasterRejectionReason()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RejectionReasonID")]
        public override int Id { get; set; }
        [StringLength(5)]
        [Attr("ReasonCode")]
        public string ReasonCode { get; set; }
        [StringLength(100)]
        [Attr("ReasonDesc")]
        public string ReasonDesc { get; set; }        
        [NotMapped]
        public string value { get { return this.ReasonDesc; } set { this.ReasonDesc = value; } }        
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
    }

}
