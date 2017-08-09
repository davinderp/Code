using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration38 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy_fk",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_User_DeletedBy_fk",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy_fk",
                table: "MasterAdministrationSite");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterAdministrationSite_User_DeletedBy_fk",
                table: "MasterAdministrationSite");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_CreatedBy_fk",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_DeletedBy_fk",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCPT_User_CreatedBy_fk",
                table: "MasterCPT");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCPT_User_DeletedBy_fk",
                table: "MasterCPT");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy_fk",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy_fk",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy_fk",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy_fk",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterGender_User_CreatedBy_fk",
                table: "MasterGender");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterGender_User_DeletedBy_fk",
                table: "MasterGender");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterICD_User_CreatedBy_fk",
                table: "MasterICD");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterICD_User_DeletedBy_fk",
                table: "MasterICD");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy_fk",
                table: "MasterImmunityStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunityStatus_User_DeletedBy_fk",
                table: "MasterImmunityStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy_fk",
                table: "MasterImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunization_User_DeletedBy_fk",
                table: "MasterImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLocation_User_CreatedBy_fk",
                table: "MasterLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLocation_User_DeletedBy_fk",
                table: "MasterLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy_fk",
                table: "MasterManufacture");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterManufacture_User_DeletedBy_fk",
                table: "MasterManufacture");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy_fk",
                table: "MasterOccupation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterOccupation_User_DeletedBy_fk",
                table: "MasterOccupation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy_fk",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPatientCommPreferences_User_DeletedBy_fk",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy_fk",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterProgram_User_CreatedBy_fk",
                table: "MasterProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterProgram_User_DeletedBy_fk",
                table: "MasterProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_CreatedBy_fk",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_DeletedBy_fk",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterReferral_User_CreatedBy_fk",
                table: "MasterReferral");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterReferral_User_DeletedBy_fk",
                table: "MasterReferral");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy_fk",
                table: "MasterRejectionReason");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRejectionReason_User_DeletedBy_fk",
                table: "MasterRejectionReason");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy_fk",
                table: "MasterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRelationship_User_DeletedBy_fk",
                table: "MasterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy_fk",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRouteOfAdministration_User_DeletedBy_fk",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterService_User_CreatedBy_fk",
                table: "MasterService");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterService_User_DeletedBy_fk",
                table: "MasterService");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_MasterCountry_CountryID_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_CreatedBy_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_DeletedBy_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_CreatedBy_fk",
                table: "MasterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_DeletedBy_fk",
                table: "MasterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterType_User_CreatedBy_fk",
                table: "MasterType");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterType_User_DeletedBy_fk",
                table: "MasterType");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy_fk",
                table: "MasterVFCEligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterVFCEligibility_User_DeletedBy_fk",
                table: "MasterVFCEligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_DeletedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_HomeCountry_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_HomeState_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_Patients_PatientID_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_CreatedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_DeletedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_MasterICD_ICDID_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_Patients_PatientID_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_UpdatedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_Patients_PatientID_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterState_State_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_Patients_PatientID_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_UpdatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_MasterCPT_CPTID_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_CreatedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_DeletedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_MasterLocation_LocationID_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Patients_PatientID_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Provider_ProviderId_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_UpdatedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_Patients_PatientID_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_UpdatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Provider_AdministeredBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_DeletedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterImmunization_Immunization_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_Manufacture_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Provider_OrderBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Patients_PatientID_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_UpdatedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_DeletedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_InsuranceCompanies_InsuranceCompany_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsuranceType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_Patients_PatientID_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_UpdatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_DeletedBy_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_Patients_PatientID_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationshipID_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_UpdatedBy_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_DeletedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_Patients_PatientID_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterCountry_Citizenship_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_ClientStatus_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_DeletedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
            //    table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterGender_Gender_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Patients_Provider_PrimaryProvider_fk",
            //    table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_Race_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_AlcohalID_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_DeletedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_DrugID_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_Patients_PatientID_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TobaccoID_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TravelID_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_UpdatedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_DeletedBy_fk",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_Patients_PatientID_fk",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_UpdatedBy_fk",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy_fk",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_User_DeletedBy_fk",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID_fk",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_MasterType_PhoneNumberTypeId_fk",
                table: "PhoneNumbers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Provider_ProviderID_fk",
            //    table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_CreatedBy_fk",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_DeletedBy_fk",
                table: "Provider");

            migrationBuilder.DropTable(
                name: "PatientPastIllness");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PrimaryProvider_fk",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "Provider",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "Provider",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Provider_DeletedBy_fk",
                table: "Provider",
                newName: "IX_Provider_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Provider_CreatedBy_fk",
                table: "Provider",
                newName: "IX_Provider_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ProviderID_fk",
                table: "PhoneNumbers",
                newName: "ProviderID");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberTypeId_fk",
                table: "PhoneNumbers",
                newName: "PhoneNumberTypeId");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PhoneNumbers",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PhoneNumbers",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PhoneNumbers",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ProviderID_fk",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PhoneNumberTypeId_fk",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PhoneNumberTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PatientID_fk",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_DeletedBy_fk",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_CreatedBy_fk",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientVitals",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientVitals",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "EncounterID_fk",
                table: "PatientVitals",
                newName: "EncounterID");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientVitals",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientVitals",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_UpdatedBy_fk",
                table: "PatientVitals",
                newName: "IX_PatientVitals_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_PatientID_fk",
                table: "PatientVitals",
                newName: "IX_PatientVitals_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_DeletedBy_fk",
                table: "PatientVitals",
                newName: "IX_PatientVitals_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_CreatedBy_fk",
                table: "PatientVitals",
                newName: "IX_PatientVitals_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientSocialHistory",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "TravelID_fk",
                table: "PatientSocialHistory",
                newName: "TravelID");

            migrationBuilder.RenameColumn(
                name: "TobaccoID_fk",
                table: "PatientSocialHistory",
                newName: "TobaccoID");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientSocialHistory",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "DrugID_fk",
                table: "PatientSocialHistory",
                newName: "DrugID");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientSocialHistory",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientSocialHistory",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "AlcohalID_fk",
                table: "PatientSocialHistory",
                newName: "AlcohalID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_UpdatedBy_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_TravelID_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_TravelID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_TobaccoID_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_TobaccoID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_PatientID_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_DrugID_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_DrugID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_DeletedBy_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_CreatedBy_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_AlcohalID_fk",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_AlcohalID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "Patients",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Suffix_fk",
                table: "Patients",
                newName: "Suffix");

            migrationBuilder.RenameColumn(
                name: "SecondaryRace_fk",
                table: "Patients",
                newName: "SecondaryRace1Id");

            migrationBuilder.RenameColumn(
                name: "Race_fk",
                table: "Patients",
                newName: "Race");

            migrationBuilder.RenameColumn(
                name: "PrimaryProvider_fk",
                table: "Patients",
                newName: "SecondaryRace");

            migrationBuilder.RenameColumn(
                name: "MaritalStatus_fk",
                table: "Patients",
                newName: "PrimaryProvider");

            migrationBuilder.RenameColumn(
                name: "Gender_fk",
                table: "Patients",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Ethnicity_fk",
                table: "Patients",
                newName: "MaritalStatus");

            migrationBuilder.RenameColumn(
                name: "EmergencyContactRelationship_fk",
                table: "Patients",
                newName: "Ethnicity");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "Patients",
                newName: "EmergencyContactRelationship");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "Patients",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ClientStatus_fk",
                table: "Patients",
                newName: "ClientStatus");

            migrationBuilder.RenameColumn(
                name: "Citizenship_fk",
                table: "Patients",
                newName: "DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_UpdatedBy_fk",
                table: "Patients",
                newName: "IX_Patients_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Suffix_fk",
                table: "Patients",
                newName: "IX_Patients_Suffix");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_SecondaryRace_fk",
                table: "Patients",
                newName: "IX_Patients_SecondaryRace1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Race_fk",
                table: "Patients",
                newName: "IX_Patients_Race");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_MaritalStatus_fk",
                table: "Patients",
                newName: "IX_Patients_PrimaryProvider");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Gender_fk",
                table: "Patients",
                newName: "IX_Patients_Gender");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Ethnicity_fk",
                table: "Patients",
                newName: "IX_Patients_MaritalStatus");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_EmergencyContactRelationship_fk",
                table: "Patients",
                newName: "IX_Patients_Ethnicity");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_DeletedBy_fk",
                table: "Patients",
                newName: "IX_Patients_EmergencyContactRelationship");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_CreatedBy_fk",
                table: "Patients",
                newName: "IX_Patients_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ClientStatus_fk",
                table: "Patients",
                newName: "IX_Patients_ClientStatus");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Citizenship_fk",
                table: "Patients",
                newName: "IX_Patients_DeletedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientPreference",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "ServiceRequested_fk",
                table: "PatientPreference",
                newName: "ServiceRequested");

            migrationBuilder.RenameColumn(
                name: "Referral_fk",
                table: "PatientPreference",
                newName: "Referral");

            migrationBuilder.RenameColumn(
                name: "Program_fk",
                table: "PatientPreference",
                newName: "Program");

            migrationBuilder.RenameColumn(
                name: "PreferredLanguage_fk",
                table: "PatientPreference",
                newName: "PreferredLanguage");

            migrationBuilder.RenameColumn(
                name: "PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                newName: "PatientOfficeCommPreferences");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientPreference",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                newName: "PatientHomeCommPreferences");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientPreference",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_UpdatedBy_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_ServiceRequested_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_ServiceRequested");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_Referral_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_Referral");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_Program_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_Program");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PreferredLanguage_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PreferredLanguage");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientOfficeCommPreferences");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientID_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientHomeCommPreferences");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_DeletedBy_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_CreatedBy_fk",
                table: "PatientPreference",
                newName: "IX_PatientPreference_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "RelationshipID_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "RelationshipID");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "Gender_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Disease_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "Disease");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_UpdatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_RelationshipID_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_RelationshipID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_PatientID_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_Gender_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_Gender");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_Disease_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_Disease");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_DeletedBy_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientInsuranceDetails",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientInsuranceDetails",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "InsuranceType_fk",
                table: "PatientInsuranceDetails",
                newName: "InsuranceType");

            migrationBuilder.RenameColumn(
                name: "InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                newName: "InsurancePlanType");

            migrationBuilder.RenameColumn(
                name: "InsuranceCompany_fk",
                table: "PatientInsuranceDetails",
                newName: "InsuranceCompany");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientInsuranceDetails",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_UpdatedBy_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_PatientID_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsuranceType_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsuranceType");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsurancePlanType");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsuranceCompany_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsuranceCompany");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_DeletedBy_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "VFC_Eligibility_fk",
                table: "PatientImmunization",
                newName: "VFC_Eligibility");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientImmunization",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "RouteOfAdministration_fk",
                table: "PatientImmunization",
                newName: "RouteOfAdministration");

            migrationBuilder.RenameColumn(
                name: "RejectionReason_fk",
                table: "PatientImmunization",
                newName: "RejectionReason");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientImmunization",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "OrderBy_fk",
                table: "PatientImmunization",
                newName: "OrderBy");

            migrationBuilder.RenameColumn(
                name: "Manufacture_fk",
                table: "PatientImmunization",
                newName: "Manufacture");

            migrationBuilder.RenameColumn(
                name: "Immunization_fk",
                table: "PatientImmunization",
                newName: "Immunization");

            migrationBuilder.RenameColumn(
                name: "ImmunityStatus_fk",
                table: "PatientImmunization",
                newName: "ImmunityStatus");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientImmunization",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientImmunization",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "AdministrationSite_fk",
                table: "PatientImmunization",
                newName: "AdministrationSite");

            migrationBuilder.RenameColumn(
                name: "AdministeredBy_fk",
                table: "PatientImmunization",
                newName: "AdministeredBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_VFC_Eligibility_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_VFC_Eligibility");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_UpdatedBy_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RouteOfAdministration_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RouteOfAdministration");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RejectionReason_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RejectionReason");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_PatientID_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_OrderBy_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_OrderBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_Manufacture_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_Manufacture");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_Immunization_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_Immunization");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_ImmunityStatus_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_ImmunityStatus");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_DeletedBy_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_CreatedBy_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_AdministrationSite_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_AdministrationSite");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_AdministeredBy_fk",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_AdministeredBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientGuardian",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientGuardian",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "GuardianState_fk",
                table: "PatientGuardian",
                newName: "GuardianState");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_UpdatedBy_fk",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_PatientID_fk",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_GuardianState_fk",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_GuardianState");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_CreatedBy_fk",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientEncounter",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "ProviderId_fk",
                table: "PatientEncounter",
                newName: "ProviderId");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientEncounter",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "LocationID_fk",
                table: "PatientEncounter",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientEncounter",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientEncounter",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CPTID_fk",
                table: "PatientEncounter",
                newName: "CPTID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_UpdatedBy_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_ProviderId_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_PatientID_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_LocationID_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_DeletedBy_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_CreatedBy_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_CPTID_fk",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_CPTID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientEmploymentDetail",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientEmploymentDetail",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "Occupation_fk",
                table: "PatientEmploymentDetail",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                newName: "EmploymentStatus");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_UpdatedBy_fk",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_PatientID_fk",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_Occupation_fk",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_Occupation");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_EmploymentStatus");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientDocuments",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "State_fk",
                table: "PatientDocuments",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientDocuments",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "DocumentType_fk",
                table: "PatientDocuments",
                newName: "DocumentType");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_UpdatedBy_fk",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_State_fk",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_State");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_PatientID_fk",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_DocumentType_fk",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_DocumentType");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_CreatedBy_fk",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientDiagnosis",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientDiagnosis",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "ICDID_fk",
                table: "PatientDiagnosis",
                newName: "ICDID");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientDiagnosis",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientDiagnosis",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_UpdatedBy_fk",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_PatientID_fk",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_ICDID_fk",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_ICDID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_DeletedBy_fk",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_CreatedBy_fk",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy_fk",
                table: "PatientAddress",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "PatientID_fk",
                table: "PatientAddress",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "MailingState_fk",
                table: "PatientAddress",
                newName: "MailingState");

            migrationBuilder.RenameColumn(
                name: "MailCountry_fk",
                table: "PatientAddress",
                newName: "MailCountry");

            migrationBuilder.RenameColumn(
                name: "HomeState_fk",
                table: "PatientAddress",
                newName: "HomeState");

            migrationBuilder.RenameColumn(
                name: "HomeCountry_fk",
                table: "PatientAddress",
                newName: "HomeCountry");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "PatientAddress",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_UpdatedBy_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_UpdatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_PatientID_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MailingState_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MailingState");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MailCountry_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MailCountry");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_HomeState_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_HomeState");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_HomeCountry_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_HomeCountry");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_DeletedBy_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_CreatedBy_fk",
                table: "PatientAddress",
                newName: "IX_PatientAddress_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterVFCEligibility",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterVFCEligibility",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterVFCEligibility_DeletedBy_fk",
                table: "MasterVFCEligibility",
                newName: "IX_MasterVFCEligibility_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterVFCEligibility_CreatedBy_fk",
                table: "MasterVFCEligibility",
                newName: "IX_MasterVFCEligibility_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterType",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterType",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterType_DeletedBy_fk",
                table: "MasterType",
                newName: "IX_MasterType_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterType_CreatedBy_fk",
                table: "MasterType",
                newName: "IX_MasterType_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterStatus",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterStatus",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterStatus_DeletedBy_fk",
                table: "MasterStatus",
                newName: "IX_MasterStatus_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterStatus_CreatedBy_fk",
                table: "MasterStatus",
                newName: "IX_MasterStatus_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterState",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterState",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CountryID_fk",
                table: "MasterState",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_MasterState_DeletedBy_fk",
                table: "MasterState",
                newName: "IX_MasterState_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterState_CreatedBy_fk",
                table: "MasterState",
                newName: "IX_MasterState_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterState_CountryID_fk",
                table: "MasterState",
                newName: "IX_MasterState_CountryID");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterService",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterService",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterService_DeletedBy_fk",
                table: "MasterService",
                newName: "IX_MasterService_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterService_CreatedBy_fk",
                table: "MasterService",
                newName: "IX_MasterService_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterRouteOfAdministration",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRouteOfAdministration_DeletedBy_fk",
                table: "MasterRouteOfAdministration",
                newName: "IX_MasterRouteOfAdministration_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRouteOfAdministration_CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                newName: "IX_MasterRouteOfAdministration_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterRelationship",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterRelationship",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRelationship_DeletedBy_fk",
                table: "MasterRelationship",
                newName: "IX_MasterRelationship_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRelationship_CreatedBy_fk",
                table: "MasterRelationship",
                newName: "IX_MasterRelationship_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterRejectionReason",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterRejectionReason",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRejectionReason_DeletedBy_fk",
                table: "MasterRejectionReason",
                newName: "IX_MasterRejectionReason_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRejectionReason_CreatedBy_fk",
                table: "MasterRejectionReason",
                newName: "IX_MasterRejectionReason_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterReferral",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterReferral",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterReferral_DeletedBy_fk",
                table: "MasterReferral",
                newName: "IX_MasterReferral_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterReferral_CreatedBy_fk",
                table: "MasterReferral",
                newName: "IX_MasterReferral_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterRace",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterRace",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRace_DeletedBy_fk",
                table: "MasterRace",
                newName: "IX_MasterRace_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRace_CreatedBy_fk",
                table: "MasterRace",
                newName: "IX_MasterRace_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterProgram",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterProgram",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterProgram_DeletedBy_fk",
                table: "MasterProgram",
                newName: "IX_MasterProgram_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterProgram_CreatedBy_fk",
                table: "MasterProgram",
                newName: "IX_MasterProgram_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterPreferredLanguage",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterPreferredLanguage",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPreferredLanguage_DeletedBy_fk",
                table: "MasterPreferredLanguage",
                newName: "IX_MasterPreferredLanguage_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPreferredLanguage_CreatedBy_fk",
                table: "MasterPreferredLanguage",
                newName: "IX_MasterPreferredLanguage_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterPatientCommPreferences",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPatientCommPreferences_DeletedBy_fk",
                table: "MasterPatientCommPreferences",
                newName: "IX_MasterPatientCommPreferences_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPatientCommPreferences_CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                newName: "IX_MasterPatientCommPreferences_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterOccupation",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterOccupation",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterOccupation_DeletedBy_fk",
                table: "MasterOccupation",
                newName: "IX_MasterOccupation_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterOccupation_CreatedBy_fk",
                table: "MasterOccupation",
                newName: "IX_MasterOccupation_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterManufacture",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterManufacture",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterManufacture_DeletedBy_fk",
                table: "MasterManufacture",
                newName: "IX_MasterManufacture_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterManufacture_CreatedBy_fk",
                table: "MasterManufacture",
                newName: "IX_MasterManufacture_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterLocation",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterLocation",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterLocation_DeletedBy_fk",
                table: "MasterLocation",
                newName: "IX_MasterLocation_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterLocation_CreatedBy_fk",
                table: "MasterLocation",
                newName: "IX_MasterLocation_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterImmunization",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterImmunization",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunization_DeletedBy_fk",
                table: "MasterImmunization",
                newName: "IX_MasterImmunization_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunization_CreatedBy_fk",
                table: "MasterImmunization",
                newName: "IX_MasterImmunization_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterImmunityStatus",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterImmunityStatus",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunityStatus_DeletedBy_fk",
                table: "MasterImmunityStatus",
                newName: "IX_MasterImmunityStatus_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunityStatus_CreatedBy_fk",
                table: "MasterImmunityStatus",
                newName: "IX_MasterImmunityStatus_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterICD",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterICD",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterICD_DeletedBy_fk",
                table: "MasterICD",
                newName: "IX_MasterICD_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterICD_CreatedBy_fk",
                table: "MasterICD",
                newName: "IX_MasterICD_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterGender",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterGender",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterGender_DeletedBy_fk",
                table: "MasterGender",
                newName: "IX_MasterGender_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterGender_CreatedBy_fk",
                table: "MasterGender",
                newName: "IX_MasterGender_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterFundingSource",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterFundingSource",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterFundingSource_DeletedBy_fk",
                table: "MasterFundingSource",
                newName: "IX_MasterFundingSource_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterFundingSource_CreatedBy_fk",
                table: "MasterFundingSource",
                newName: "IX_MasterFundingSource_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterEthnicity",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterEthnicity",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterEthnicity_DeletedBy_fk",
                table: "MasterEthnicity",
                newName: "IX_MasterEthnicity_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterEthnicity_CreatedBy_fk",
                table: "MasterEthnicity",
                newName: "IX_MasterEthnicity_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterCPT",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterCPT",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCPT_DeletedBy_fk",
                table: "MasterCPT",
                newName: "IX_MasterCPT_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCPT_CreatedBy_fk",
                table: "MasterCPT",
                newName: "IX_MasterCPT_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterCountry",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterCountry",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCountry_DeletedBy_fk",
                table: "MasterCountry",
                newName: "IX_MasterCountry_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCountry_CreatedBy_fk",
                table: "MasterCountry",
                newName: "IX_MasterCountry_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "MasterAdministrationSite",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "MasterAdministrationSite",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterAdministrationSite_DeletedBy_fk",
                table: "MasterAdministrationSite",
                newName: "IX_MasterAdministrationSite_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MasterAdministrationSite_CreatedBy_fk",
                table: "MasterAdministrationSite",
                newName: "IX_MasterAdministrationSite_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "DeletedBy_fk",
                table: "InsuranceCompanies",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy_fk",
                table: "InsuranceCompanies",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_InsuranceCompanies_DeletedBy_fk",
                table: "InsuranceCompanies",
                newName: "IX_InsuranceCompanies_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_InsuranceCompanies_CreatedBy_fk",
                table: "InsuranceCompanies",
                newName: "IX_InsuranceCompanies_CreatedBy");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 999, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 999, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 994, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "Citizenship",
                table: "Patients",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 999, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Citizenship",
                table: "Patients",
                column: "Citizenship");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy",
                table: "InsuranceCompanies",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_User_DeletedBy",
                table: "InsuranceCompanies",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy",
                table: "MasterAdministrationSite",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterAdministrationSite_User_DeletedBy",
                table: "MasterAdministrationSite",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_CreatedBy",
                table: "MasterCountry",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_DeletedBy",
                table: "MasterCountry",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCPT_User_CreatedBy",
                table: "MasterCPT",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCPT_User_DeletedBy",
                table: "MasterCPT",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy",
                table: "MasterEthnicity",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy",
                table: "MasterEthnicity",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy",
                table: "MasterFundingSource",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy",
                table: "MasterFundingSource",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterGender_User_CreatedBy",
                table: "MasterGender",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterGender_User_DeletedBy",
                table: "MasterGender",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterICD_User_CreatedBy",
                table: "MasterICD",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterICD_User_DeletedBy",
                table: "MasterICD",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy",
                table: "MasterImmunityStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunityStatus_User_DeletedBy",
                table: "MasterImmunityStatus",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy",
                table: "MasterImmunization",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunization_User_DeletedBy",
                table: "MasterImmunization",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLocation_User_CreatedBy",
                table: "MasterLocation",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLocation_User_DeletedBy",
                table: "MasterLocation",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy",
                table: "MasterManufacture",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterManufacture_User_DeletedBy",
                table: "MasterManufacture",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy",
                table: "MasterOccupation",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterOccupation_User_DeletedBy",
                table: "MasterOccupation",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy",
                table: "MasterPatientCommPreferences",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPatientCommPreferences_User_DeletedBy",
                table: "MasterPatientCommPreferences",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy",
                table: "MasterPreferredLanguage",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy",
                table: "MasterPreferredLanguage",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterProgram_User_CreatedBy",
                table: "MasterProgram",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterProgram_User_DeletedBy",
                table: "MasterProgram",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_CreatedBy",
                table: "MasterRace",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_DeletedBy",
                table: "MasterRace",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterReferral_User_CreatedBy",
                table: "MasterReferral",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterReferral_User_DeletedBy",
                table: "MasterReferral",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy",
                table: "MasterRejectionReason",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRejectionReason_User_DeletedBy",
                table: "MasterRejectionReason",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy",
                table: "MasterRelationship",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRelationship_User_DeletedBy",
                table: "MasterRelationship",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy",
                table: "MasterRouteOfAdministration",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRouteOfAdministration_User_DeletedBy",
                table: "MasterRouteOfAdministration",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterService_User_CreatedBy",
                table: "MasterService",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterService_User_DeletedBy",
                table: "MasterService",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_MasterCountry_CountryID",
                table: "MasterState",
                column: "CountryID",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_CreatedBy",
                table: "MasterState",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_DeletedBy",
                table: "MasterState",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_CreatedBy",
                table: "MasterStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_DeletedBy",
                table: "MasterStatus",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterType_User_CreatedBy",
                table: "MasterType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterType_User_DeletedBy",
                table: "MasterType",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy",
                table: "MasterVFCEligibility",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterVFCEligibility_User_DeletedBy",
                table: "MasterVFCEligibility",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy",
                table: "PatientAddress",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_DeletedBy",
                table: "PatientAddress",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_HomeCountry",
                table: "PatientAddress",
                column: "HomeCountry",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_HomeState",
                table: "PatientAddress",
                column: "HomeState",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry",
                table: "PatientAddress",
                column: "MailCountry",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState",
                table: "PatientAddress",
                column: "MailingState",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_Patients_PatientID",
                table: "PatientAddress",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy",
                table: "PatientAddress",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_CreatedBy",
                table: "PatientDiagnosis",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_DeletedBy",
                table: "PatientDiagnosis",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_MasterICD_ICDID",
                table: "PatientDiagnosis",
                column: "ICDID",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_Patients_PatientID",
                table: "PatientDiagnosis",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_UpdatedBy",
                table: "PatientDiagnosis",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy",
                table: "PatientDocuments",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType",
                table: "PatientDocuments",
                column: "DocumentType",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_Patients_PatientID",
                table: "PatientDocuments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterState_State",
                table: "PatientDocuments",
                column: "State",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy",
                table: "PatientDocuments",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy",
                table: "PatientEmploymentDetail",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus",
                table: "PatientEmploymentDetail",
                column: "EmploymentStatus",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation",
                table: "PatientEmploymentDetail",
                column: "Occupation",
                principalTable: "MasterOccupation",
                principalColumn: "OccupationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_Patients_PatientID",
                table: "PatientEmploymentDetail",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_UpdatedBy",
                table: "PatientEmploymentDetail",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_MasterCPT_CPTID",
                table: "PatientEncounter",
                column: "CPTID",
                principalTable: "MasterCPT",
                principalColumn: "CPTID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_CreatedBy",
                table: "PatientEncounter",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_DeletedBy",
                table: "PatientEncounter",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_MasterLocation_LocationID",
                table: "PatientEncounter",
                column: "LocationID",
                principalTable: "MasterLocation",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Patients_PatientID",
                table: "PatientEncounter",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Provider_ProviderId",
                table: "PatientEncounter",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_UpdatedBy",
                table: "PatientEncounter",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy",
                table: "PatientGuardian",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState",
                table: "PatientGuardian",
                column: "GuardianState",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_Patients_PatientID",
                table: "PatientGuardian",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_UpdatedBy",
                table: "PatientGuardian",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Provider_AdministeredBy",
                table: "PatientImmunization",
                column: "AdministeredBy",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite",
                table: "PatientImmunization",
                column: "AdministrationSite",
                principalTable: "MasterAdministrationSite",
                principalColumn: "AdministrationSiteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy",
                table: "PatientImmunization",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_DeletedBy",
                table: "PatientImmunization",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus",
                table: "PatientImmunization",
                column: "ImmunityStatus",
                principalTable: "MasterImmunityStatus",
                principalColumn: "ImmunityStatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterImmunization_Immunization",
                table: "PatientImmunization",
                column: "Immunization",
                principalTable: "MasterImmunization",
                principalColumn: "ImmunizationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_Manufacture",
                table: "PatientImmunization",
                column: "Manufacture",
                principalTable: "MasterManufacture",
                principalColumn: "ManufactureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Provider_OrderBy",
                table: "PatientImmunization",
                column: "OrderBy",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Patients_PatientID",
                table: "PatientImmunization",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason",
                table: "PatientImmunization",
                column: "RejectionReason",
                principalTable: "MasterRejectionReason",
                principalColumn: "RejectionReasonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration",
                table: "PatientImmunization",
                column: "RouteOfAdministration",
                principalTable: "MasterRouteOfAdministration",
                principalColumn: "RouteOfAdministrationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_UpdatedBy",
                table: "PatientImmunization",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility",
                table: "PatientImmunization",
                column: "VFC_Eligibility",
                principalTable: "MasterVFCEligibility",
                principalColumn: "VFCID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy",
                table: "PatientInsuranceDetails",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_DeletedBy",
                table: "PatientInsuranceDetails",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_InsuranceCompanies_InsuranceCompany",
                table: "PatientInsuranceDetails",
                column: "InsuranceCompany",
                principalTable: "InsuranceCompanies",
                principalColumn: "InsuranceCompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType",
                table: "PatientInsuranceDetails",
                column: "InsurancePlanType",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsuranceType",
                table: "PatientInsuranceDetails",
                column: "InsuranceType",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_Patients_PatientID",
                table: "PatientInsuranceDetails",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_UpdatedBy",
                table: "PatientInsuranceDetails",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy",
                table: "PatientMedicalFamilyHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_DeletedBy",
                table: "PatientMedicalFamilyHistory",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease",
                table: "PatientMedicalFamilyHistory",
                column: "Disease",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender",
                table: "PatientMedicalFamilyHistory",
                column: "Gender",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_Patients_PatientID",
                table: "PatientMedicalFamilyHistory",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationshipID",
                table: "PatientMedicalFamilyHistory",
                column: "RelationshipID",
                principalTable: "MasterRelationship",
                principalColumn: "RelationshipID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_UpdatedBy",
                table: "PatientMedicalFamilyHistory",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy",
                table: "PatientPreference",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_DeletedBy",
                table: "PatientPreference",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences",
                table: "PatientPreference",
                column: "PatientHomeCommPreferences",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_Patients_PatientID",
                table: "PatientPreference",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferences",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage",
                table: "PatientPreference",
                column: "PreferredLanguage",
                principalTable: "MasterPreferredLanguage",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program",
                table: "PatientPreference",
                column: "Program",
                principalTable: "MasterProgram",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral",
                table: "PatientPreference",
                column: "Referral",
                principalTable: "MasterReferral",
                principalColumn: "ReferralID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested",
                table: "PatientPreference",
                column: "ServiceRequested",
                principalTable: "MasterService",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy",
                table: "PatientPreference",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterCountry_Citizenship",
                table: "Patients",
                column: "Citizenship",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_ClientStatus",
                table: "Patients",
                column: "ClientStatus",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy",
                table: "Patients",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_DeletedBy",
                table: "Patients",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship",
                table: "Patients",
                column: "EmergencyContactRelationship",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Patients_MasterEthnicity_Ethnicity",
            //    table: "Patients",
            //    column: "Ethnicity",
            //    principalTable: "MasterEthnicity",
            //    principalColumn: "EthnicityID",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterGender_Gender",
                table: "Patients",
                column: "Gender",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus",
                table: "Patients",
                column: "MaritalStatus",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Patients_Provider_PrimaryProvider",
            //    table: "Patients",
            //    column: "PrimaryProvider",
            //    principalTable: "Provider",
            //    principalColumn: "ProviderId",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_Race",
                table: "Patients",
                column: "Race",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace1Id",
                table: "Patients",
                column: "SecondaryRace1Id",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_Suffix",
                table: "Patients",
                column: "Suffix",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_UpdatedBy",
                table: "Patients",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_AlcohalID",
                table: "PatientSocialHistory",
                column: "AlcohalID",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy",
                table: "PatientSocialHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_DeletedBy",
                table: "PatientSocialHistory",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_DrugID",
                table: "PatientSocialHistory",
                column: "DrugID",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_Patients_PatientID",
                table: "PatientSocialHistory",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TobaccoID",
                table: "PatientSocialHistory",
                column: "TobaccoID",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TravelID",
                table: "PatientSocialHistory",
                column: "TravelID",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_UpdatedBy",
                table: "PatientSocialHistory",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_CreatedBy",
                table: "PatientVitals",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_DeletedBy",
                table: "PatientVitals",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_Patients_PatientID",
                table: "PatientVitals",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_UpdatedBy",
                table: "PatientVitals",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy",
                table: "PhoneNumbers",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_User_DeletedBy",
                table: "PhoneNumbers",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID",
                table: "PhoneNumbers",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_MasterType_PhoneNumberTypeId",
                table: "PhoneNumbers",
                column: "PhoneNumberTypeId",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Provider_ProviderID",
                table: "PhoneNumbers",
                column: "ProviderID",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_CreatedBy",
                table: "Provider",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_DeletedBy",
                table: "Provider",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_User_DeletedBy",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy",
                table: "MasterAdministrationSite");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterAdministrationSite_User_DeletedBy",
                table: "MasterAdministrationSite");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_CreatedBy",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_DeletedBy",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCPT_User_CreatedBy",
                table: "MasterCPT");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCPT_User_DeletedBy",
                table: "MasterCPT");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterGender_User_CreatedBy",
                table: "MasterGender");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterGender_User_DeletedBy",
                table: "MasterGender");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterICD_User_CreatedBy",
                table: "MasterICD");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterICD_User_DeletedBy",
                table: "MasterICD");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy",
                table: "MasterImmunityStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunityStatus_User_DeletedBy",
                table: "MasterImmunityStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy",
                table: "MasterImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunization_User_DeletedBy",
                table: "MasterImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLocation_User_CreatedBy",
                table: "MasterLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLocation_User_DeletedBy",
                table: "MasterLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy",
                table: "MasterManufacture");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterManufacture_User_DeletedBy",
                table: "MasterManufacture");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy",
                table: "MasterOccupation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterOccupation_User_DeletedBy",
                table: "MasterOccupation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPatientCommPreferences_User_DeletedBy",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterProgram_User_CreatedBy",
                table: "MasterProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterProgram_User_DeletedBy",
                table: "MasterProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_CreatedBy",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_DeletedBy",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterReferral_User_CreatedBy",
                table: "MasterReferral");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterReferral_User_DeletedBy",
                table: "MasterReferral");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy",
                table: "MasterRejectionReason");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRejectionReason_User_DeletedBy",
                table: "MasterRejectionReason");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy",
                table: "MasterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRelationship_User_DeletedBy",
                table: "MasterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRouteOfAdministration_User_DeletedBy",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterService_User_CreatedBy",
                table: "MasterService");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterService_User_DeletedBy",
                table: "MasterService");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_MasterCountry_CountryID",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_CreatedBy",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_DeletedBy",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_CreatedBy",
                table: "MasterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_DeletedBy",
                table: "MasterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterType_User_CreatedBy",
                table: "MasterType");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterType_User_DeletedBy",
                table: "MasterType");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy",
                table: "MasterVFCEligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterVFCEligibility_User_DeletedBy",
                table: "MasterVFCEligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_DeletedBy",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_HomeCountry",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_HomeState",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_Patients_PatientID",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_CreatedBy",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_DeletedBy",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_MasterICD_ICDID",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_Patients_PatientID",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_UpdatedBy",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_Patients_PatientID",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterState_State",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_Patients_PatientID",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_UpdatedBy",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_MasterCPT_CPTID",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_CreatedBy",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_DeletedBy",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_MasterLocation_LocationID",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Patients_PatientID",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Provider_ProviderId",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_UpdatedBy",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_Patients_PatientID",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_UpdatedBy",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Provider_AdministeredBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_DeletedBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterImmunization_Immunization",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_Manufacture",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Provider_OrderBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Patients_PatientID",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_UpdatedBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_DeletedBy",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_InsuranceCompanies_InsuranceCompany",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsuranceType",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_Patients_PatientID",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_UpdatedBy",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_DeletedBy",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_Patients_PatientID",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationshipID",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_UpdatedBy",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_DeletedBy",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_Patients_PatientID",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterCountry_Citizenship",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_ClientStatus",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_DeletedBy",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship",
                table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Patients_MasterEthnicity_Ethnicity",
            //    table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterGender_Gender",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus",
                table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Patients_Provider_PrimaryProvider",
            //    table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_Race",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace1Id",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_Suffix",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_UpdatedBy",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_AlcohalID",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_DeletedBy",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_DrugID",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_Patients_PatientID",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TobaccoID",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TravelID",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_UpdatedBy",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_CreatedBy",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_DeletedBy",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_Patients_PatientID",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_UpdatedBy",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_User_DeletedBy",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_MasterType_PhoneNumberTypeId",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Provider_ProviderID",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_CreatedBy",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_DeletedBy",
                table: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Citizenship",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Citizenship",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Provider",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Provider",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Provider_DeletedBy",
                table: "Provider",
                newName: "IX_Provider_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Provider_CreatedBy",
                table: "Provider",
                newName: "IX_Provider_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "ProviderID",
                table: "PhoneNumbers",
                newName: "ProviderID_fk");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberTypeId",
                table: "PhoneNumbers",
                newName: "PhoneNumberTypeId_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PhoneNumbers",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PhoneNumbers",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PhoneNumbers",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ProviderID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ProviderID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PhoneNumberTypeId",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PhoneNumberTypeId_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PatientID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_DeletedBy",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_CreatedBy",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientVitals",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientVitals",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "EncounterID",
                table: "PatientVitals",
                newName: "EncounterID_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientVitals",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientVitals",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_UpdatedBy",
                table: "PatientVitals",
                newName: "IX_PatientVitals_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_PatientID",
                table: "PatientVitals",
                newName: "IX_PatientVitals_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_DeletedBy",
                table: "PatientVitals",
                newName: "IX_PatientVitals_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientVitals_CreatedBy",
                table: "PatientVitals",
                newName: "IX_PatientVitals_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientSocialHistory",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "TravelID",
                table: "PatientSocialHistory",
                newName: "TravelID_fk");

            migrationBuilder.RenameColumn(
                name: "TobaccoID",
                table: "PatientSocialHistory",
                newName: "TobaccoID_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientSocialHistory",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "DrugID",
                table: "PatientSocialHistory",
                newName: "DrugID_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientSocialHistory",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientSocialHistory",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "AlcohalID",
                table: "PatientSocialHistory",
                newName: "AlcohalID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_UpdatedBy",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_TravelID",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_TravelID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_TobaccoID",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_TobaccoID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_PatientID",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_DrugID",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_DrugID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_DeletedBy",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_CreatedBy",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientSocialHistory_AlcohalID",
                table: "PatientSocialHistory",
                newName: "IX_PatientSocialHistory_AlcohalID_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Patients",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "Suffix",
                table: "Patients",
                newName: "Suffix_fk");

            migrationBuilder.RenameColumn(
                name: "SecondaryRace1Id",
                table: "Patients",
                newName: "SecondaryRace_fk");

            migrationBuilder.RenameColumn(
                name: "SecondaryRace",
                table: "Patients",
                newName: "PrimaryProvider_fk");

            migrationBuilder.RenameColumn(
                name: "Race",
                table: "Patients",
                newName: "Race_fk");

            migrationBuilder.RenameColumn(
                name: "PrimaryProvider",
                table: "Patients",
                newName: "MaritalStatus_fk");

            migrationBuilder.RenameColumn(
                name: "MaritalStatus",
                table: "Patients",
                newName: "Ethnicity_fk");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Patients",
                newName: "Gender_fk");

            migrationBuilder.RenameColumn(
                name: "Ethnicity",
                table: "Patients",
                newName: "EmergencyContactRelationship_fk");

            migrationBuilder.RenameColumn(
                name: "EmergencyContactRelationship",
                table: "Patients",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Patients",
                newName: "Citizenship_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Patients",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "ClientStatus",
                table: "Patients",
                newName: "ClientStatus_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_UpdatedBy",
                table: "Patients",
                newName: "IX_Patients_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Suffix",
                table: "Patients",
                newName: "IX_Patients_Suffix_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_SecondaryRace1Id",
                table: "Patients",
                newName: "IX_Patients_SecondaryRace_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Race",
                table: "Patients",
                newName: "IX_Patients_Race_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PrimaryProvider",
                table: "Patients",
                newName: "IX_Patients_MaritalStatus_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_MaritalStatus",
                table: "Patients",
                newName: "IX_Patients_Ethnicity_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Gender",
                table: "Patients",
                newName: "IX_Patients_Gender_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Ethnicity",
                table: "Patients",
                newName: "IX_Patients_EmergencyContactRelationship_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_EmergencyContactRelationship",
                table: "Patients",
                newName: "IX_Patients_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_DeletedBy",
                table: "Patients",
                newName: "IX_Patients_Citizenship_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_CreatedBy",
                table: "Patients",
                newName: "IX_Patients_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ClientStatus",
                table: "Patients",
                newName: "IX_Patients_ClientStatus_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientPreference",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "ServiceRequested",
                table: "PatientPreference",
                newName: "ServiceRequested_fk");

            migrationBuilder.RenameColumn(
                name: "Referral",
                table: "PatientPreference",
                newName: "Referral_fk");

            migrationBuilder.RenameColumn(
                name: "Program",
                table: "PatientPreference",
                newName: "Program_fk");

            migrationBuilder.RenameColumn(
                name: "PreferredLanguage",
                table: "PatientPreference",
                newName: "PreferredLanguage_fk");

            migrationBuilder.RenameColumn(
                name: "PatientOfficeCommPreferences",
                table: "PatientPreference",
                newName: "PatientOfficeCommPreferences_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientPreference",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "PatientHomeCommPreferences",
                table: "PatientPreference",
                newName: "PatientHomeCommPreferences_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientPreference",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientPreference",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_UpdatedBy",
                table: "PatientPreference",
                newName: "IX_PatientPreference_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_ServiceRequested",
                table: "PatientPreference",
                newName: "IX_PatientPreference_ServiceRequested_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_Referral",
                table: "PatientPreference",
                newName: "IX_PatientPreference_Referral_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_Program",
                table: "PatientPreference",
                newName: "IX_PatientPreference_Program_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PreferredLanguage",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PreferredLanguage_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientOfficeCommPreferences",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientOfficeCommPreferences_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientID",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientHomeCommPreferences",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientHomeCommPreferences_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_DeletedBy",
                table: "PatientPreference",
                newName: "IX_PatientPreference_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_CreatedBy",
                table: "PatientPreference",
                newName: "IX_PatientPreference_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientMedicalFamilyHistory",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "RelationshipID",
                table: "PatientMedicalFamilyHistory",
                newName: "RelationshipID_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientMedicalFamilyHistory",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "PatientMedicalFamilyHistory",
                newName: "Gender_fk");

            migrationBuilder.RenameColumn(
                name: "Disease",
                table: "PatientMedicalFamilyHistory",
                newName: "Disease_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientMedicalFamilyHistory",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientMedicalFamilyHistory",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_UpdatedBy",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_RelationshipID",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_RelationshipID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_PatientID",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_Gender",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_Gender_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_Disease",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_Disease_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_DeletedBy",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_CreatedBy",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientInsuranceDetails",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientInsuranceDetails",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "InsuranceType",
                table: "PatientInsuranceDetails",
                newName: "InsuranceType_fk");

            migrationBuilder.RenameColumn(
                name: "InsurancePlanType",
                table: "PatientInsuranceDetails",
                newName: "InsurancePlanType_fk");

            migrationBuilder.RenameColumn(
                name: "InsuranceCompany",
                table: "PatientInsuranceDetails",
                newName: "InsuranceCompany_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientInsuranceDetails",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientInsuranceDetails",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_UpdatedBy",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_PatientID",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsuranceType",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsuranceType_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsurancePlanType",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsurancePlanType_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsuranceCompany",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsuranceCompany_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_DeletedBy",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_CreatedBy",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "VFC_Eligibility",
                table: "PatientImmunization",
                newName: "VFC_Eligibility_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientImmunization",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "RouteOfAdministration",
                table: "PatientImmunization",
                newName: "RouteOfAdministration_fk");

            migrationBuilder.RenameColumn(
                name: "RejectionReason",
                table: "PatientImmunization",
                newName: "RejectionReason_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientImmunization",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "OrderBy",
                table: "PatientImmunization",
                newName: "OrderBy_fk");

            migrationBuilder.RenameColumn(
                name: "Manufacture",
                table: "PatientImmunization",
                newName: "Manufacture_fk");

            migrationBuilder.RenameColumn(
                name: "Immunization",
                table: "PatientImmunization",
                newName: "Immunization_fk");

            migrationBuilder.RenameColumn(
                name: "ImmunityStatus",
                table: "PatientImmunization",
                newName: "ImmunityStatus_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientImmunization",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientImmunization",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "AdministrationSite",
                table: "PatientImmunization",
                newName: "AdministrationSite_fk");

            migrationBuilder.RenameColumn(
                name: "AdministeredBy",
                table: "PatientImmunization",
                newName: "AdministeredBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_VFC_Eligibility",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_VFC_Eligibility_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_UpdatedBy",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RouteOfAdministration",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RouteOfAdministration_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RejectionReason",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RejectionReason_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_PatientID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_OrderBy",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_OrderBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_Manufacture",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_Manufacture_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_Immunization",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_Immunization_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_ImmunityStatus",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_ImmunityStatus_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_DeletedBy",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_CreatedBy",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_AdministrationSite",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_AdministrationSite_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_AdministeredBy",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_AdministeredBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientGuardian",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientGuardian",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "GuardianState",
                table: "PatientGuardian",
                newName: "GuardianState_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientGuardian",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_UpdatedBy",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_PatientID",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_GuardianState",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_GuardianState_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientGuardian_CreatedBy",
                table: "PatientGuardian",
                newName: "IX_PatientGuardian_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientEncounter",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "PatientEncounter",
                newName: "ProviderId_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientEncounter",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "PatientEncounter",
                newName: "LocationID_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientEncounter",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientEncounter",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CPTID",
                table: "PatientEncounter",
                newName: "CPTID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_UpdatedBy",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_ProviderId",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_ProviderId_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_PatientID",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_LocationID",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_LocationID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_DeletedBy",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_CreatedBy",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_CPTID",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_CPTID_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientEmploymentDetail",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientEmploymentDetail",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "PatientEmploymentDetail",
                newName: "Occupation_fk");

            migrationBuilder.RenameColumn(
                name: "EmploymentStatus",
                table: "PatientEmploymentDetail",
                newName: "EmploymentStatus_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientEmploymentDetail",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_UpdatedBy",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_PatientID",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_Occupation",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_Occupation_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_EmploymentStatus",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_EmploymentStatus_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEmploymentDetail_CreatedBy",
                table: "PatientEmploymentDetail",
                newName: "IX_PatientEmploymentDetail_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientDocuments",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "PatientDocuments",
                newName: "State_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientDocuments",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "DocumentType",
                table: "PatientDocuments",
                newName: "DocumentType_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientDocuments",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_UpdatedBy",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_State",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_State_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_PatientID",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_DocumentType",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_DocumentType_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDocuments_CreatedBy",
                table: "PatientDocuments",
                newName: "IX_PatientDocuments_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientDiagnosis",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientDiagnosis",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "ICDID",
                table: "PatientDiagnosis",
                newName: "ICDID_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientDiagnosis",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientDiagnosis",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_UpdatedBy",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_PatientID",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_ICDID",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_ICDID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_DeletedBy",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_CreatedBy",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PatientAddress",
                newName: "UpdatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientAddress",
                newName: "PatientID_fk");

            migrationBuilder.RenameColumn(
                name: "MailingState",
                table: "PatientAddress",
                newName: "MailingState_fk");

            migrationBuilder.RenameColumn(
                name: "MailCountry",
                table: "PatientAddress",
                newName: "MailCountry_fk");

            migrationBuilder.RenameColumn(
                name: "HomeState",
                table: "PatientAddress",
                newName: "HomeState_fk");

            migrationBuilder.RenameColumn(
                name: "HomeCountry",
                table: "PatientAddress",
                newName: "HomeCountry_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "PatientAddress",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PatientAddress",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_UpdatedBy",
                table: "PatientAddress",
                newName: "IX_PatientAddress_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_PatientID",
                table: "PatientAddress",
                newName: "IX_PatientAddress_PatientID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MailingState",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MailingState_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MailCountry",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MailCountry_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_HomeState",
                table: "PatientAddress",
                newName: "IX_PatientAddress_HomeState_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_HomeCountry",
                table: "PatientAddress",
                newName: "IX_PatientAddress_HomeCountry_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_DeletedBy",
                table: "PatientAddress",
                newName: "IX_PatientAddress_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_CreatedBy",
                table: "PatientAddress",
                newName: "IX_PatientAddress_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterVFCEligibility",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterVFCEligibility",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterVFCEligibility_DeletedBy",
                table: "MasterVFCEligibility",
                newName: "IX_MasterVFCEligibility_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterVFCEligibility_CreatedBy",
                table: "MasterVFCEligibility",
                newName: "IX_MasterVFCEligibility_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterType",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterType",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterType_DeletedBy",
                table: "MasterType",
                newName: "IX_MasterType_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterType_CreatedBy",
                table: "MasterType",
                newName: "IX_MasterType_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterStatus",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterStatus",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterStatus_DeletedBy",
                table: "MasterStatus",
                newName: "IX_MasterStatus_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterStatus_CreatedBy",
                table: "MasterStatus",
                newName: "IX_MasterStatus_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterState",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterState",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "MasterState",
                newName: "CountryID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterState_DeletedBy",
                table: "MasterState",
                newName: "IX_MasterState_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterState_CreatedBy",
                table: "MasterState",
                newName: "IX_MasterState_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterState_CountryID",
                table: "MasterState",
                newName: "IX_MasterState_CountryID_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterService",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterService",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterService_DeletedBy",
                table: "MasterService",
                newName: "IX_MasterService_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterService_CreatedBy",
                table: "MasterService",
                newName: "IX_MasterService_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterRouteOfAdministration",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterRouteOfAdministration",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRouteOfAdministration_DeletedBy",
                table: "MasterRouteOfAdministration",
                newName: "IX_MasterRouteOfAdministration_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRouteOfAdministration_CreatedBy",
                table: "MasterRouteOfAdministration",
                newName: "IX_MasterRouteOfAdministration_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterRelationship",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterRelationship",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRelationship_DeletedBy",
                table: "MasterRelationship",
                newName: "IX_MasterRelationship_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRelationship_CreatedBy",
                table: "MasterRelationship",
                newName: "IX_MasterRelationship_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterRejectionReason",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterRejectionReason",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRejectionReason_DeletedBy",
                table: "MasterRejectionReason",
                newName: "IX_MasterRejectionReason_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRejectionReason_CreatedBy",
                table: "MasterRejectionReason",
                newName: "IX_MasterRejectionReason_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterReferral",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterReferral",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterReferral_DeletedBy",
                table: "MasterReferral",
                newName: "IX_MasterReferral_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterReferral_CreatedBy",
                table: "MasterReferral",
                newName: "IX_MasterReferral_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterRace",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterRace",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRace_DeletedBy",
                table: "MasterRace",
                newName: "IX_MasterRace_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterRace_CreatedBy",
                table: "MasterRace",
                newName: "IX_MasterRace_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterProgram",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterProgram",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterProgram_DeletedBy",
                table: "MasterProgram",
                newName: "IX_MasterProgram_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterProgram_CreatedBy",
                table: "MasterProgram",
                newName: "IX_MasterProgram_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterPreferredLanguage",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterPreferredLanguage",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPreferredLanguage_DeletedBy",
                table: "MasterPreferredLanguage",
                newName: "IX_MasterPreferredLanguage_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPreferredLanguage_CreatedBy",
                table: "MasterPreferredLanguage",
                newName: "IX_MasterPreferredLanguage_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterPatientCommPreferences",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterPatientCommPreferences",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPatientCommPreferences_DeletedBy",
                table: "MasterPatientCommPreferences",
                newName: "IX_MasterPatientCommPreferences_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterPatientCommPreferences_CreatedBy",
                table: "MasterPatientCommPreferences",
                newName: "IX_MasterPatientCommPreferences_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterOccupation",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterOccupation",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterOccupation_DeletedBy",
                table: "MasterOccupation",
                newName: "IX_MasterOccupation_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterOccupation_CreatedBy",
                table: "MasterOccupation",
                newName: "IX_MasterOccupation_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterManufacture",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterManufacture",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterManufacture_DeletedBy",
                table: "MasterManufacture",
                newName: "IX_MasterManufacture_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterManufacture_CreatedBy",
                table: "MasterManufacture",
                newName: "IX_MasterManufacture_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterLocation",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterLocation",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterLocation_DeletedBy",
                table: "MasterLocation",
                newName: "IX_MasterLocation_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterLocation_CreatedBy",
                table: "MasterLocation",
                newName: "IX_MasterLocation_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterImmunization",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterImmunization",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunization_DeletedBy",
                table: "MasterImmunization",
                newName: "IX_MasterImmunization_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunization_CreatedBy",
                table: "MasterImmunization",
                newName: "IX_MasterImmunization_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterImmunityStatus",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterImmunityStatus",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunityStatus_DeletedBy",
                table: "MasterImmunityStatus",
                newName: "IX_MasterImmunityStatus_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterImmunityStatus_CreatedBy",
                table: "MasterImmunityStatus",
                newName: "IX_MasterImmunityStatus_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterICD",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterICD",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterICD_DeletedBy",
                table: "MasterICD",
                newName: "IX_MasterICD_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterICD_CreatedBy",
                table: "MasterICD",
                newName: "IX_MasterICD_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterGender",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterGender",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterGender_DeletedBy",
                table: "MasterGender",
                newName: "IX_MasterGender_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterGender_CreatedBy",
                table: "MasterGender",
                newName: "IX_MasterGender_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterFundingSource",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterFundingSource",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterFundingSource_DeletedBy",
                table: "MasterFundingSource",
                newName: "IX_MasterFundingSource_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterFundingSource_CreatedBy",
                table: "MasterFundingSource",
                newName: "IX_MasterFundingSource_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterEthnicity",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterEthnicity",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterEthnicity_DeletedBy",
                table: "MasterEthnicity",
                newName: "IX_MasterEthnicity_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterEthnicity_CreatedBy",
                table: "MasterEthnicity",
                newName: "IX_MasterEthnicity_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterCPT",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterCPT",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCPT_DeletedBy",
                table: "MasterCPT",
                newName: "IX_MasterCPT_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCPT_CreatedBy",
                table: "MasterCPT",
                newName: "IX_MasterCPT_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterCountry",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterCountry",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCountry_DeletedBy",
                table: "MasterCountry",
                newName: "IX_MasterCountry_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterCountry_CreatedBy",
                table: "MasterCountry",
                newName: "IX_MasterCountry_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "MasterAdministrationSite",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MasterAdministrationSite",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterAdministrationSite_DeletedBy",
                table: "MasterAdministrationSite",
                newName: "IX_MasterAdministrationSite_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_MasterAdministrationSite_CreatedBy",
                table: "MasterAdministrationSite",
                newName: "IX_MasterAdministrationSite_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "InsuranceCompanies",
                newName: "DeletedBy_fk");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "InsuranceCompanies",
                newName: "CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_InsuranceCompanies_DeletedBy",
                table: "InsuranceCompanies",
                newName: "IX_InsuranceCompanies_DeletedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_InsuranceCompanies_CreatedBy",
                table: "InsuranceCompanies",
                newName: "IX_InsuranceCompanies_CreatedBy_fk");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 999, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 999, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 994, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 2, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 996, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 999, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 998, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 995, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 18, 1, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 24, 17, 997, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "PatientPastIllness",
                columns: table => new
                {
                    PastIllnessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DiagnosisDate = table.Column<DateTime>(nullable: false),
                    Illness = table.Column<string>(maxLength: 300, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    PatientID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPastIllness", x => x.PastIllnessId);
                    table.ForeignKey(
                        name: "FK_PatientPastIllness_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPastIllness_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPastIllness_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPastIllness_MasterStatus_Status",
                        column: x => x.Status,
                        principalTable: "MasterStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPastIllness_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PrimaryProvider_fk",
                table: "Patients",
                column: "PrimaryProvider_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPastIllness_CreatedBy",
                table: "PatientPastIllness",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPastIllness_DeletedBy",
                table: "PatientPastIllness",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPastIllness_PatientID",
                table: "PatientPastIllness",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPastIllness_Status",
                table: "PatientPastIllness",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPastIllness_UpdatedBy",
                table: "PatientPastIllness",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy_fk",
                table: "InsuranceCompanies",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_User_DeletedBy_fk",
                table: "InsuranceCompanies",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy_fk",
                table: "MasterAdministrationSite",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterAdministrationSite_User_DeletedBy_fk",
                table: "MasterAdministrationSite",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_CreatedBy_fk",
                table: "MasterCountry",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_DeletedBy_fk",
                table: "MasterCountry",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCPT_User_CreatedBy_fk",
                table: "MasterCPT",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCPT_User_DeletedBy_fk",
                table: "MasterCPT",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy_fk",
                table: "MasterEthnicity",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy_fk",
                table: "MasterEthnicity",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy_fk",
                table: "MasterFundingSource",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy_fk",
                table: "MasterFundingSource",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterGender_User_CreatedBy_fk",
                table: "MasterGender",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterGender_User_DeletedBy_fk",
                table: "MasterGender",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterICD_User_CreatedBy_fk",
                table: "MasterICD",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterICD_User_DeletedBy_fk",
                table: "MasterICD",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy_fk",
                table: "MasterImmunityStatus",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunityStatus_User_DeletedBy_fk",
                table: "MasterImmunityStatus",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy_fk",
                table: "MasterImmunization",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunization_User_DeletedBy_fk",
                table: "MasterImmunization",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLocation_User_CreatedBy_fk",
                table: "MasterLocation",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLocation_User_DeletedBy_fk",
                table: "MasterLocation",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy_fk",
                table: "MasterManufacture",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterManufacture_User_DeletedBy_fk",
                table: "MasterManufacture",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy_fk",
                table: "MasterOccupation",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterOccupation_User_DeletedBy_fk",
                table: "MasterOccupation",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPatientCommPreferences_User_DeletedBy_fk",
                table: "MasterPatientCommPreferences",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy_fk",
                table: "MasterPreferredLanguage",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                table: "MasterPreferredLanguage",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterProgram_User_CreatedBy_fk",
                table: "MasterProgram",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterProgram_User_DeletedBy_fk",
                table: "MasterProgram",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_CreatedBy_fk",
                table: "MasterRace",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_DeletedBy_fk",
                table: "MasterRace",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterReferral_User_CreatedBy_fk",
                table: "MasterReferral",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterReferral_User_DeletedBy_fk",
                table: "MasterReferral",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy_fk",
                table: "MasterRejectionReason",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRejectionReason_User_DeletedBy_fk",
                table: "MasterRejectionReason",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy_fk",
                table: "MasterRelationship",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRelationship_User_DeletedBy_fk",
                table: "MasterRelationship",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRouteOfAdministration_User_DeletedBy_fk",
                table: "MasterRouteOfAdministration",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterService_User_CreatedBy_fk",
                table: "MasterService",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterService_User_DeletedBy_fk",
                table: "MasterService",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_MasterCountry_CountryID_fk",
                table: "MasterState",
                column: "CountryID_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_CreatedBy_fk",
                table: "MasterState",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_DeletedBy_fk",
                table: "MasterState",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_CreatedBy_fk",
                table: "MasterStatus",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_DeletedBy_fk",
                table: "MasterStatus",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterType_User_CreatedBy_fk",
                table: "MasterType",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterType_User_DeletedBy_fk",
                table: "MasterType",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy_fk",
                table: "MasterVFCEligibility",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterVFCEligibility_User_DeletedBy_fk",
                table: "MasterVFCEligibility",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_DeletedBy_fk",
                table: "PatientAddress",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_HomeCountry_fk",
                table: "PatientAddress",
                column: "HomeCountry_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_HomeState_fk",
                table: "PatientAddress",
                column: "HomeState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry_fk",
                table: "PatientAddress",
                column: "MailCountry_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState_fk",
                table: "PatientAddress",
                column: "MailingState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_Patients_PatientID_fk",
                table: "PatientAddress",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy_fk",
                table: "PatientAddress",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_CreatedBy_fk",
                table: "PatientDiagnosis",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_DeletedBy_fk",
                table: "PatientDiagnosis",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_MasterICD_ICDID_fk",
                table: "PatientDiagnosis",
                column: "ICDID_fk",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_Patients_PatientID_fk",
                table: "PatientDiagnosis",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_UpdatedBy_fk",
                table: "PatientDiagnosis",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments",
                column: "DocumentType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_Patients_PatientID_fk",
                table: "PatientDocuments",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterState_State_fk",
                table: "PatientDocuments",
                column: "State_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                column: "EmploymentStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                table: "PatientEmploymentDetail",
                column: "Occupation_fk",
                principalTable: "MasterOccupation",
                principalColumn: "OccupationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_Patients_PatientID_fk",
                table: "PatientEmploymentDetail",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_UpdatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_MasterCPT_CPTID_fk",
                table: "PatientEncounter",
                column: "CPTID_fk",
                principalTable: "MasterCPT",
                principalColumn: "CPTID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_CreatedBy_fk",
                table: "PatientEncounter",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_DeletedBy_fk",
                table: "PatientEncounter",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_MasterLocation_LocationID_fk",
                table: "PatientEncounter",
                column: "LocationID_fk",
                principalTable: "MasterLocation",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Patients_PatientID_fk",
                table: "PatientEncounter",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Provider_ProviderId_fk",
                table: "PatientEncounter",
                column: "ProviderId_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_UpdatedBy_fk",
                table: "PatientEncounter",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                table: "PatientGuardian",
                column: "GuardianState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_Patients_PatientID_fk",
                table: "PatientGuardian",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_UpdatedBy_fk",
                table: "PatientGuardian",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Provider_AdministeredBy_fk",
                table: "PatientImmunization",
                column: "AdministeredBy_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite_fk",
                table: "PatientImmunization",
                column: "AdministrationSite_fk",
                principalTable: "MasterAdministrationSite",
                principalColumn: "AdministrationSiteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy_fk",
                table: "PatientImmunization",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_DeletedBy_fk",
                table: "PatientImmunization",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus_fk",
                table: "PatientImmunization",
                column: "ImmunityStatus_fk",
                principalTable: "MasterImmunityStatus",
                principalColumn: "ImmunityStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterImmunization_Immunization_fk",
                table: "PatientImmunization",
                column: "Immunization_fk",
                principalTable: "MasterImmunization",
                principalColumn: "ImmunizationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_Manufacture_fk",
                table: "PatientImmunization",
                column: "Manufacture_fk",
                principalTable: "MasterManufacture",
                principalColumn: "ManufactureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Provider_OrderBy_fk",
                table: "PatientImmunization",
                column: "OrderBy_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Patients_PatientID_fk",
                table: "PatientImmunization",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason_fk",
                table: "PatientImmunization",
                column: "RejectionReason_fk",
                principalTable: "MasterRejectionReason",
                principalColumn: "RejectionReasonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration_fk",
                table: "PatientImmunization",
                column: "RouteOfAdministration_fk",
                principalTable: "MasterRouteOfAdministration",
                principalColumn: "RouteOfAdministrationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_UpdatedBy_fk",
                table: "PatientImmunization",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility_fk",
                table: "PatientImmunization",
                column: "VFC_Eligibility_fk",
                principalTable: "MasterVFCEligibility",
                principalColumn: "VFCID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_DeletedBy_fk",
                table: "PatientInsuranceDetails",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_InsuranceCompanies_InsuranceCompany_fk",
                table: "PatientInsuranceDetails",
                column: "InsuranceCompany_fk",
                principalTable: "InsuranceCompanies",
                principalColumn: "InsuranceCompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                column: "InsurancePlanType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsuranceType_fk",
                table: "PatientInsuranceDetails",
                column: "InsuranceType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_Patients_PatientID_fk",
                table: "PatientInsuranceDetails",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_UpdatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_DeletedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease_fk",
                table: "PatientMedicalFamilyHistory",
                column: "Disease_fk",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender_fk",
                table: "PatientMedicalFamilyHistory",
                column: "Gender_fk",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_Patients_PatientID_fk",
                table: "PatientMedicalFamilyHistory",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationshipID_fk",
                table: "PatientMedicalFamilyHistory",
                column: "RelationshipID_fk",
                principalTable: "MasterRelationship",
                principalColumn: "RelationshipID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_UpdatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_DeletedBy_fk",
                table: "PatientPreference",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientHomeCommPreferences_fk",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_Patients_PatientID_fk",
                table: "PatientPreference",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferences_fk",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                table: "PatientPreference",
                column: "PreferredLanguage_fk",
                principalTable: "MasterPreferredLanguage",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program_fk",
                table: "PatientPreference",
                column: "Program_fk",
                principalTable: "MasterProgram",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral_fk",
                table: "PatientPreference",
                column: "Referral_fk",
                principalTable: "MasterReferral",
                principalColumn: "ReferralID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                table: "PatientPreference",
                column: "ServiceRequested_fk",
                principalTable: "MasterService",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy_fk",
                table: "PatientPreference",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterCountry_Citizenship_fk",
                table: "Patients",
                column: "Citizenship_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_ClientStatus_fk",
                table: "Patients",
                column: "ClientStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_DeletedBy_fk",
                table: "Patients",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients",
                column: "EmergencyContactRelationship_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
            //    table: "Patients",
            //    column: "Ethnicity_fk",
            //    principalTable: "MasterEthnicity",
            //    principalColumn: "EthnicityID",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterGender_Gender_fk",
                table: "Patients",
                column: "Gender_fk",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients",
                column: "MaritalStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Patients_Provider_PrimaryProvider_fk",
            //    table: "Patients",
            //    column: "PrimaryProvider_fk",
            //    principalTable: "Provider",
            //    principalColumn: "ProviderId",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_Race_fk",
                table: "Patients",
                column: "Race_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients",
                column: "SecondaryRace_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients",
                column: "Suffix_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_AlcohalID_fk",
                table: "PatientSocialHistory",
                column: "AlcohalID_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                table: "PatientSocialHistory",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_DeletedBy_fk",
                table: "PatientSocialHistory",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_DrugID_fk",
                table: "PatientSocialHistory",
                column: "DrugID_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_Patients_PatientID_fk",
                table: "PatientSocialHistory",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TobaccoID_fk",
                table: "PatientSocialHistory",
                column: "TobaccoID_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_MasterType_TravelID_fk",
                table: "PatientSocialHistory",
                column: "TravelID_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_UpdatedBy_fk",
                table: "PatientSocialHistory",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_DeletedBy_fk",
                table: "PatientVitals",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_Patients_PatientID_fk",
                table: "PatientVitals",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_UpdatedBy_fk",
                table: "PatientVitals",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy_fk",
                table: "PhoneNumbers",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_User_DeletedBy_fk",
                table: "PhoneNumbers",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID_fk",
                table: "PhoneNumbers",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_MasterType_PhoneNumberTypeId_fk",
                table: "PhoneNumbers",
                column: "PhoneNumberTypeId_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Provider_ProviderID_fk",
                table: "PhoneNumbers",
                column: "ProviderID_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_CreatedBy_fk",
                table: "Provider",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_DeletedBy_fk",
                table: "Provider",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
