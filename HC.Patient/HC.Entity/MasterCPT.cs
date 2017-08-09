using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterCPT : Identifiable<int>
    {
        public MasterCPT()
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
        [Column("CPTID")]
        public override int Id { get; set; }        
        public string CPTCode { get; set; }
        [NotMapped]
        public string value { get { return this.CPTCode; } set { this.CPTCode = value; } }
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