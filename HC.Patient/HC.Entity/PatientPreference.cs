using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class PatientPreference : Identifiable<int>, IHasMeta
    {
        public PatientPreference()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientPreferenceID")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Attr("ReceiveSMS")]
        public bool? ReceiveSMS { get; set; }
        [Attr("PreferredLanguageID")]
        [ForeignKey("MasterPreferredLanguage")]
        public int? PreferredLanguageID { get; set; }

        [Attr("ServiceRequestedID")]
        [ForeignKey("MasterService")]
        public int? ServiceRequestedID { get; set; }


        [Attr("PatientHomeCommPreferencesID")]
        [ForeignKey("MasterPatientCommPreferences")]
        public int? PatientHomeCommPreferencesID { get; set; }

        [Attr("PatientOfficeCommPreferencesID")]
        [ForeignKey("MasterPatientCommPreferences1")]
        public int? PatientOfficeCommPreferencesID { get; set; }

        [Attr("AddClientToCaseLoad")]
        public bool? AddClientToCaseLoad { get; set; }

        [Attr("IsActive")]
        public bool IsActive { get; set; }
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


        [HasOne("patient")]
        public virtual Patients Patient { get; set; }
        public virtual MasterPreferredLanguage MasterPreferredLanguage { get; set; }
        [HasOne("users")]
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }

        public virtual MasterService MasterService { get; set; }
        public virtual MasterPatientCommPreferences MasterPatientCommPreferences { get; set; }
        public virtual MasterPatientCommPreferences MasterPatientCommPreferences1 { get; set; }

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
