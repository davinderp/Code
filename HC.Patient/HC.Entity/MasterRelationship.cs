using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterRelationship : Identifiable<int>
    {
        public MasterRelationship()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RelationshipID")]
        [Attr("RelationshipID")]
        public override int Id { get; set; }
        [Attr("RelationshipName")]
        public string RelationshipName { get; set; }
        [NotMapped]
        public string value { get { return this.RelationshipName; } set { this.RelationshipName = value; } }
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
        [Required]
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
    }
}