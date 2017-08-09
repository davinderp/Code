using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterManufacture : Identifiable<int>
    {

        public MasterManufacture()
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
        [Column("ManufactureID")]
        public override int Id { get; set; }
        [StringLength(50)]
        [Attr("MVXCode")]
        public string MVXCode { get; set; }
        [Attr("ManufacturerName")]
        [StringLength(500)]
        public string ManufacturerName { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.ManufacturerName; } set { this.ManufacturerName = value; } }
        [Required]
        [Attr("Notes")]
        public int Notes { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }
}
