using JsonApiDotNetCore.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterPreferredLanguage : Identifiable<int>
    {
        public MasterPreferredLanguage()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LanguageID")]
        public override int Id { get; set; }
        //public int LanguageID { get; set; }
        [Attr("Language")]
        public string Language { get; set; }
        [NotMapped]
        public string value { get { return this.Language; } set { this.Language = value; } }
        public string Code { get; set; }
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