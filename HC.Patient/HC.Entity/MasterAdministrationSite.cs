using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterAdministrationSite : Identifiable<int>
    {
        public MasterAdministrationSite()
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
        [Column("AdministrationSiteID")]
        public override int Id { get; set; }
        [StringLength(50)]
        [Attr("SNOMED")]
        public string SNOMED { get; set; }
        [Attr("HL7")]
        //[StringLength(10)]
        public string HL7 { get; set; }
        [NotMapped]
        [Attr("value")]
        public string value { get { return this.HL7 + this.Description; } set { this.HL7 = value; } }
        [Attr("Description")]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }
}
