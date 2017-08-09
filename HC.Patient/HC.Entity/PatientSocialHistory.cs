using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class PatientSocialHistory : Identifiable<int>, IHasMeta
    {
        public PatientSocialHistory()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SocialHistoryId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("AlcohalID")]
        [ForeignKey("MasterAlcohal")]
        public int AlcohalID { get; set; }

        [Attr("Alcohal")]
        public string Alcohal
        {
            get
            {
                try
                {
                    return MasterAlcohal.TypeName;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        [Required]
        [RequiredNumber]
        [Attr("TobaccoID")]
        [ForeignKey("MasterTobacco")]
        public int TobaccoID { get; set; }

        [Attr("Tobacco")]
        public string Tobacco
        {
            get
            {
                try
                {
                    return MasterTobacco.TypeName;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        [Required]
        [RequiredNumber]
        [Attr("DrugID")]
        [ForeignKey("MasterDrug")]
        public int DrugID { get; set; }

        [Attr("Drug")]
        public string Drug
        {
            get
            {
                try
                {
                    return MasterDrug.TypeName;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        [Attr("Occupation")]
        [StringLength(300)]
        public string Occupation { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("TravelID")]
        [ForeignKey("MasterTravel")]
        public int TravelID { get; set; }

        [Attr("Travel")]
        public string Travel
        {
            get
            {
                try
                {
                    return MasterTravel.TypeName;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [ForeignKey("Users")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        //Foreign key's tables
        public virtual Patients Patient { get; set; }
        [HasOne("masteralcohal")]
        public virtual MasterType MasterAlcohal { get; set; }
        [HasOne("mastertobacco")]
        public virtual MasterType MasterTobacco { get; set; }
        [HasOne("masterdrug")]
        public virtual MasterType MasterDrug { get; set; }
        [HasOne("mastertravel")]
        public virtual MasterType MasterTravel { get; set; }
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }
        public Dictionary<string, object> GetMeta(IJsonApiContext context)
        {
            return new Dictionary<string, object> {
                //{ "total-count",  context.PageManager.TotalRecords },
                { "total-pages",  context.PageManager.TotalPages },
                { "page-size",  context.PageManager.PageSize },
                { "current-page",  context.PageManager.CurrentPage },
                { "default-page-size",  context.PageManager.DefaultPageSize },
            };
        }
    }
}