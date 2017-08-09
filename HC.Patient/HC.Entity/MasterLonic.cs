using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterLonic : Identifiable<int>
    {
        public MasterLonic()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LonicID")]
        public override int Id { get; set; }        
        public string LonicCode { get; set; }
        [NotMapped]
        public string value { get { return this.LonicCode; } set { this.LonicCode = value; } }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }        
        public virtual User Users1 { get; set; }
    }
}