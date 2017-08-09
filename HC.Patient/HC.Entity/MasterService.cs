using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class MasterService : Identifiable<int>
    {
        public MasterService()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ServiceID")]
        public override int Id { get; set; }
        public string ServiceName { get; set; }
        [NotMapped]
        public string value { get { return this.ServiceName; } set { this.ServiceName = value; } }
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



