using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterLabs : Identifiable<int>
    {
        public MasterLabs()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LabID")]
        public override int Id { get; set; }
        [Attr("LabName")]
        [StringLength(100)]
        public string LabName { get; set; }
        [NotMapped]
        public string value { get { return this.LabName; } set { this.LabName = value; } }
        [Attr("Address1")]
        [StringLength(500)]
        public string Address1 { get; set; }
        [Attr("Address2")]
        [StringLength(500)]
        public string Address2 { get; set; }
        [Attr("City")]
        [StringLength(100)]
        public string City { get; set; }
        [Attr("StateID")]
        [ForeignKey("MasterState")]
        public int StateID { get; set; }
        [Attr("Zip")]
        [StringLength(20)]
        public string Zip { get; set; }
        [Attr("LabPhone")]
        [StringLength(20)]
        public string LabPhone { get; set; }
        //
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Users1")]
        public int CreatedBy { get; set; }
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        //
        public virtual User Users { get; set; }        
        public virtual User Users1 { get; set; }
        public virtual MasterState MasterState { get; set; }
    }
}