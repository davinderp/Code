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
    public class Patients : Identifiable<int>, IHasMeta
    {
        public Patients()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
            this.ClientStatus = 2;
        }

        [Attr("PatientID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PatientID")]
        public override int Id { get; set; }
        [Required]
        [Attr("MRN")]
        [StringLength(50)]
        public string MRN { get; set; }
        [Attr("Title")]
        [StringLength(10)]
        public string Title { get; set; }        
        [Attr("FirstName")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Attr("MiddleName")]
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Attr("LastName")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Attr("Suffix")]
        [ForeignKey("MasterType")]
        public int? Suffix { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("Gender")]
        [ForeignKey("MasterGender")]
        public int Gender { get; set; }
        [Attr("GenderValue")]
        [NotMapped]
        public string GenderValue
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

            set { }
        }
        [Required]
        [RequiredDate]
        [Attr("DOB")]
        public DateTime DOB { get; set; }
        [Required]
        [Attr("SSN")]
        [StringLength(20)]        
        public string SSN { get; set; }
        [Attr("Email")]
        [StringLength(200)]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }        
        [Attr("MaritalStatus")]
        [ForeignKey("MasterStatus")]
        public int? MaritalStatus { get; set; }
        [RequiredNumber]
        [Required]
        [Attr("Race")]
        [ForeignKey("MasterRace")]
        public int Race { get; set; }
        [Attr("SecondaryRace")]
        [ForeignKey("SecondaryRace")]
        public int? SecondaryRace { get; set; }
        [Attr("Ethnicity")]
        [ForeignKey("MasterEthnicity")]
        public int? Ethnicity { get; set; }           
        [Attr("ClientStatus")]
        [ForeignKey("MasterStatus1")]
        public int ClientStatus { get; set; }
        [Attr("PrimaryClinician")]
        [ForeignKey("Clinician")]
        public int? PrimaryClinician { get; set; }

        
        [Attr("EmergencyContactFirstName")]
        [StringLength(100)]
        public string EmergencyContactFirstName { get; set; }
        [Attr("EmergencyContactLastName")]
        [StringLength(100)]
        public string EmergencyContactLastName { get; set; }
        [Attr("EmergencyContactPhone")]
        [StringLength(20)]
        public string EmergencyContactPhone { get; set; }
        [Attr("EmergencyContactRelationship")]
        [ForeignKey("MasterType1")]
        public int? EmergencyContactRelationship { get; set; }
        [Attr("PhotoPath")]
        public string PhotoPath { get; set; }
        [NotMapped]
        [Attr("PhotoBase64")]
        public string PhotoBase64 { get; set; }
        [Attr("PhotoThumbnailPath")]
        public string PhotoThumbnailPath { get; set; }

        [ForeignKey("MasterCountry")]
        public int? Citizenship { get; set; }

        [Attr("Referral")]
        [ForeignKey("MasterReferral")]
        public int? Referral { get; set; }

        [Attr("ReferralReason")]
        public string ReferralReason { get; set; }

        [Attr("ReferralDate")]
        public DateTime? ReferralDate { get; set; }

        [Attr("Program")]
        [ForeignKey("MasterProgram")]
        public int? Program { get; set; }

        [Attr("ProgramStartDate")]
        public DateTime? ProgramStartDate { get; set; }
        [Attr("LocationID")]
        [ForeignKey("Location")]
        public int LocationID { get; set; }

        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        [Attr("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }



        [Attr("FromDate")]
        [NotMapped]
        public DateTime FromDate
        {
            get
            {
                try
                {
                    return this.CreatedDate;
                }
                catch (Exception)
                {

                    return DateTime.Now;
                }
            }
        }

        [Attr("ToDate")]
        [NotMapped]
        public DateTime ToDate
        {
            get
            {
                try
                {
                    return this.CreatedDate;
                }
                catch (Exception)
                {

                    return DateTime.Now;
                }
            }            
        }

        [Attr("FromDOB")]
        [NotMapped]
        public DateTime FromDOB
        {
            get
            {
                try
                {
                    return this.DOB;
                }
                catch (Exception)
                {

                    return DateTime.Now;
                }
            }            
        }

        [Attr("ToDOB")]
        [NotMapped]
        public DateTime ToDOB
        {
            get
            {
                try
                {
                    return this.DOB;
                }
                catch (Exception)
                {

                    return DateTime.Now;
                }
            }           
        }


        [ForeignKey("Users")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        public bool IsVerified { get; set; }

        [Attr("ClinicianName")]
        [NotMapped]
        public string ClinicianName
        {
            get
            {
                try
                {
                    return Clinician.FirstName +" "+ Clinician.LastName;
                }
                catch (Exception)
                {

                    return null;
                }
            }           
        }

        [Attr("PatientInsurance")]
        [NotMapped]
        public string PatientInsurance
        {
            get
            {
                try
                {
                    return PatientInsuranceDetails.FirstOrDefault().InsurancePlanName;
                }
                catch (Exception)
                {

                    return null;
                }
            }
           
        }

        [Attr("PatientNumber")]
        [NotMapped]
        public string PatientNumber
        {
            get
            {
                try
                {
                    return PhoneNumbers.FirstOrDefault().PhoneNumber;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        [Required]
        [Attr("OrganizationID")]
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }

        [HasOne("organization")]
        public virtual Organization Organization { get; set; }
        /// <summary>
        /// following tables are used for relationship
        /// </summary>
        public virtual MasterType MasterType { get; set; }
        [HasOne("mastergender")]
        public virtual MasterGender MasterGender { get; set; }
        public virtual MasterStatus MasterStatus { get; set; }

        [HasOne("masterrace")]
        public virtual MasterRace MasterRace { get; set; }
        public virtual MasterRace SecondaryRace1 { get; set; }
        public virtual MasterEthnicity MasterEthnicity { get; set; }
        public virtual MasterStatus MasterStatus1 { get; set; }
        [HasOne("Clinician")]
        public virtual Clinicians Clinician { get; set; }
        public virtual MasterType MasterType1 { get; set; }
        public virtual MasterCountry MasterCountry { get; set; }
        [HasOne("users")]
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }
        [HasOne("masterreferral")]
        public virtual MasterReferral MasterReferral { get; set; }

        [HasMany("patientaddress")]
        public virtual List<PatientAddress> PatientAddress { get; set; }
        [HasMany("patientmedicalfamilyhistory")]
        public virtual List<PatientMedicalFamilyHistory> PatientMedicalFamilyHistory { get; set; }
        [HasMany("patientinsurancedetails")]
        public virtual List<PatientInsuranceDetails> PatientInsuranceDetails { get; set; }
        [HasMany("phonenumbers")]
        public virtual List<PhoneNumbers> PhoneNumbers { get; set; }
        [HasMany("patientpreference")]
        public virtual List<PatientPreference> PatientPreference { get; set; }
        public virtual MasterProgram MasterProgram { get; set; }

        public virtual Location Location { get; set; }

        [Attr("Address")]
        [NotMapped]
        public string Address
        {
            get
            {
                try
                {
                    if (PatientAddress != null && PatientAddress.FirstOrDefault() != null)
                    {
                        return PatientAddress.FirstOrDefault().Address1 + " " + PatientAddress.FirstOrDefault().City + ", " + PatientAddress.FirstOrDefault().Zip + ", " + PatientAddress.FirstOrDefault().StateID;
                    }
                    return string.Empty;
                }
                catch (Exception)
                {

                    return string.Empty;
                }
            }
        }
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
