using HC.Model;
using HC.Patient.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HC.Patient.Model.MasterData
{
    public class MasterDataModel //: Identifiable<int>
    {
        public List<MasterCountry> MasterCountry { get; set; }
        public List<MasterEthnicity> MasterEthnicity { get; set; }
        public List<MasterFundingSource> MasterFundingSource { get; set; }
        public List<MasterOccupation> MasterOccupation { get; set; }
        public List<MasterPreferredLanguage> MasterPreferredLanguage { get; set; }
        public List<MasterRace> MasterRace { get; set; }
        public List<MasterState> MasterState { get; set; }
        public List<MasterStatus> MasterMaritalStatus { get; set; }
        public List<MasterStatus> MasterPatientStatus { get; set; }
        public List<MasterType> MasterSuffix { get; set; }
        public List<MasterRelationship> MasterRelationship { get; set; }
        public List<Provider> Provider { get; set; }
        public List<MasterProgram> MasterProgram { get; set; }
        public List<MasterService> MasterService { get; set; }
        public List<InsuranceCompanies> InsuranceCompanies { get; set; }
        public List<MasterPatientCommPreferences> MasterPatientCommPreferences { get; set; }
        public List<MasterReferral> MasterReferral { get; set; }
        public List<MasterGender> MasterGender { get; set; }
        public List<MasterType> MasterPhoneType { get; set; }
        public List<MasterType> InsurancePlanType { get; set; }
        public List<MasterLocation> MasterLocation { get; set; }
        public List<MasterCPT> MasterCPT { get; set; }
        public List<MasterICD> MasterICD { get; set;}
        //Following are the Immunization tables
        public List<MasterVFCEligibility> MasterVFC { get; set; }
        public List<MasterImmunization> MasterImmunization { get; set; }
        public List<MasterManufacture> MasterManufacture { get; set; }
        public List<MasterAdministrationSite> MasterAdministrationSite { get; set; }
        public List<MasterRouteOfAdministration> MasterRouteOfAdministration { get; set; }
        public List<MasterImmunityStatus> MasterImmunityStatus { get; set; }
        public List<MasterRejectionReason> MasterRejectionReason { get; set; }
        public List<MasterType> MasterSocialHistory { get; set; }
        public List<MasterType> MasterTravelHistory { get; set; }

        public List<MasterType> MasterAddressType { get; set; }

        public List<Clinicians> Clinicians { get; set; }
        public List<AppointmentType> AppointmentType { get; set; }
        // LAB
        public List<MasterType> MasterLabTestType { get; set; }
        public List<MasterLonic> MasterLonic { get; set; }
        public List<MasterLabs> MasterLabs { get; set; }
        public List<MasterType> MasterTimeType { get; set; }
        public List<MasterType> MasterFrequencyType { get; set; }
        public List<MasterType> MasterFrequencyDurationType { get; set; }
        public List<MasterType> MasterAuthorizedProcedure { get; set; }

    }
}
