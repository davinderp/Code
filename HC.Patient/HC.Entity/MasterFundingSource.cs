using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class MasterFundingSource : Identifiable<int>
    {
        public MasterFundingSource()
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
        [Column("FundingSourceID")]
        public override int Id { get; set; }
        //public int FundingSourceID { get; set; }
        public string FundingSource { get; set; }
        [Required]
        [RequiredDate]
        public DateTime StartDate { get; set; }
        [Required]
        [RequiredDate]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("Users")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }
        public virtual User Users { get; set; }
    }
}