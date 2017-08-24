using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class Encounter_CPT : Identifiable<int>, IHasMeta
    {
        public Encounter_CPT()
        {   
        }
        [Required]
        [RequiredNumber]
        [Attr("EncounterId")]
        [ForeignKey("PatientEncounter")]        
        public int EncounterId { get; set; }
        
        [Required]
        [RequiredNumber]
        [Attr("CPTID")]
        [ForeignKey("MasterCPT")]
        public int CPTID { get; set; }
        
        public MasterCPT MasterCPT { get; set; }
        public PatientEncounter PatientEncounter { get; set; }

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