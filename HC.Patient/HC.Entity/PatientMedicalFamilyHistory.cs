using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HC.Patient.Entity
{
    public class PatientMedicalFamilyHistory : Identifiable<int>,IHasMeta
    {
        public PatientMedicalFamilyHistory()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Attr("MedicalFamilyHistoryId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MedicalFamilyHistoryId")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]        
        public int PatientID { get; set; }
        [Required]
        [Attr("FirstName")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Attr("LastName")]
        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        [Attr("GenderID")]
        [Required]
        [RequiredNumber]
        [ForeignKey("MasterGender")]
        public int GenderID { get; set; }
        [Attr("Gender")]
        public string Gender1
        {
            get
            {
                try
                {
                    return MasterGender.Gender;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        [Required]
        [RequiredDate]
        [Attr("DOB")]
        public DateTime DOB { get; set; }
        [Attr("RelationshipID")]
        [ForeignKey("MasterRelationship")]
        [Required]
        [RequiredNumber]
        public int RelationshipID { get; set; }

        [Attr("RelationshipName")]
        public string RelationshipName
        {
            get
            {
                try
                {
                    return MasterRelationship.RelationshipName;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        [Attr("AgeOfDiagnosis")]
        public int? AgeOfDiagnosis { get; set; }
        [Attr("DiseaseID")]
        [Required]
        [RequiredNumber]
        [ForeignKey("MasterICD")]
        public int DiseaseID { get; set; }

        [Attr("Disease")]
        public string Disease1
        {
            get
            {
                try
                {
                    return MasterICD.Code;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        [Attr("DateOfDeath")]
        public DateTime? DateOfDeath { get; set; }
        [Attr("CauseOfDeath")]
        public string CauseOfDeath { get; set; }
        [Attr("Observation")]
        public string Observation { get; set; }
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

        /// <summary>
        /// Following are the relation of the table
        /// </summary>
        [HasOne("patient")]
        public Patients Patient { get; set; }
        [HasOne("mastergender")]
        public virtual MasterGender MasterGender { get; set; }
        [HasOne("masterrelationship")]
        public virtual MasterRelationship MasterRelationship { get; set; }
        [HasOne("mastericd")]
        public virtual MasterICD MasterICD { get; set; }
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
