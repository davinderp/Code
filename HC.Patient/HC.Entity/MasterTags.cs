using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterTags : Identifiable<int>
    {
        public MasterTags()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TagID")]
        public override int Id { get; set; }
        [Attr("Tag")]
        [StringLength(100)]
        public string Tag { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.Tag; } set { this.Tag = value; } }        
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users1")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        public virtual User Users1 { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users")]
        public int CreatedBy { get; set; }
        public virtual User Users { get; set; }
    }
}