using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterICD : Identifiable<int>
    {
        public MasterICD()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users1")]
        [Attr("CreatedBy")]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ICDID")]
        public override int Id { get; set; }
        [Attr("Code")]
        public string Code { get; set; }
        [Attr("CodeType")]
        public string CodeType { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return "(" + this.Code + ") " + this.Description; } }
        [Attr("Description")]
        public string Description { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }
}