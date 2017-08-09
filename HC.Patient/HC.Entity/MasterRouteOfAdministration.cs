using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterRouteOfAdministration : Identifiable<int>
    {
        public MasterRouteOfAdministration()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RouteOfAdministrationID")]
        public override int Id { get; set; }
        [StringLength(10)]
        [Attr("FDANCI")]
        public string FDANCI { get; set; }
        [Attr("HL7")]
        [StringLength(10)]
        public string HL7 { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.HL7 + this.Description; } set { this.HL7 = value; } }
        [Attr("Description")]
        [StringLength(100)]
        public string Description { get; set; }
        [Attr("Definition")]
        [StringLength(500)]
        public string Definition { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Users1")]
        [Required]
        public int CreatedBy { get; set; }
        public virtual User Users1 { get; set; }
    }
}
