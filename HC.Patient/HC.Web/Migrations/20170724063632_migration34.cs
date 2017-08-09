using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy_fk",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy_fk",
                table: "MasterAdministrationSite");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_CreatedBy_fk",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCPT_User_CreatedBy_fk",
                table: "MasterCPT");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy_fk",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy_fk",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterGender_User_CreatedBy_fk",
                table: "MasterGender");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterICD_User_CreatedBy_fk",
                table: "MasterICD");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy_fk",
                table: "MasterImmunityStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy_fk",
                table: "MasterImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLocation_User_CreatedBy_fk",
                table: "MasterLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy_fk",
                table: "MasterManufacture");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy_fk",
                table: "MasterOccupation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy_fk",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy_fk",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterProgram_User_CreatedBy_fk",
                table: "MasterProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_CreatedBy_fk",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterReferral_User_CreatedBy_fk",
                table: "MasterReferral");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy_fk",
                table: "MasterRejectionReason");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy_fk",
                table: "MasterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy_fk",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterService_User_CreatedBy_fk",
                table: "MasterService");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_CreatedBy_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_CreatedBy_fk",
                table: "MasterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterType_User_CreatedBy_fk",
                table: "MasterType");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy_fk",
                table: "MasterVFCEligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_CreatedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_CreatedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy_fk",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_CreatedBy_fk",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_CreatedBy_fk",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PhoneNumbers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 697, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientSocialHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 690, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 417, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientImmunization",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEncounter",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDiagnosis",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterVFCEligibility",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterType",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterStatus",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterState",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterService",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 697, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 446, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRelationship",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRejectionReason",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterReferral",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRace",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterProgram",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterPreferredLanguage",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterOccupation",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterManufacture",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterLocation",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterImmunization",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterImmunityStatus",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterICD",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterGender",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterFundingSource",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterEthnicity",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterCPT",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 439, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterCountry",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterAdministrationSite",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "InsuranceCompanies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy_fk",
                table: "InsuranceCompanies",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy_fk",
                table: "MasterAdministrationSite",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_CreatedBy_fk",
                table: "MasterCountry",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCPT_User_CreatedBy_fk",
                table: "MasterCPT",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy_fk",
                table: "MasterEthnicity",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy_fk",
                table: "MasterFundingSource",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterGender_User_CreatedBy_fk",
                table: "MasterGender",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterICD_User_CreatedBy_fk",
                table: "MasterICD",
                column: "CreatedBy_fk",
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
                name: "FK_MasterImmunization_User_CreatedBy_fk",
                table: "MasterImmunization",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLocation_User_CreatedBy_fk",
                table: "MasterLocation",
                column: "CreatedBy_fk",
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
                name: "FK_MasterOccupation_User_CreatedBy_fk",
                table: "MasterOccupation",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy_fk",
                table: "MasterPreferredLanguage",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterProgram_User_CreatedBy_fk",
                table: "MasterProgram",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_CreatedBy_fk",
                table: "MasterRace",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterReferral_User_CreatedBy_fk",
                table: "MasterReferral",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy_fk",
                table: "MasterRejectionReason",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy_fk",
                table: "MasterRelationship",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterService_User_CreatedBy_fk",
                table: "MasterService",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_CreatedBy_fk",
                table: "MasterState",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_CreatedBy_fk",
                table: "MasterStatus",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterType_User_CreatedBy_fk",
                table: "MasterType",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy_fk",
                table: "MasterVFCEligibility",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
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
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
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
                name: "FK_PatientEncounter_User_CreatedBy_fk",
                table: "PatientEncounter",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy_fk",
                table: "PatientImmunization",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                table: "PatientSocialHistory",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy_fk",
                table: "PhoneNumbers",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_CreatedBy_fk",
                table: "Provider",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_CreatedBy_fk",
                table: "User",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy_fk",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy_fk",
                table: "MasterAdministrationSite");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_CreatedBy_fk",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterCPT_User_CreatedBy_fk",
                table: "MasterCPT");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy_fk",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy_fk",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterGender_User_CreatedBy_fk",
                table: "MasterGender");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterICD_User_CreatedBy_fk",
                table: "MasterICD");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy_fk",
                table: "MasterImmunityStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy_fk",
                table: "MasterImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLocation_User_CreatedBy_fk",
                table: "MasterLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy_fk",
                table: "MasterManufacture");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy_fk",
                table: "MasterOccupation");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy_fk",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy_fk",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterProgram_User_CreatedBy_fk",
                table: "MasterProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_CreatedBy_fk",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterReferral_User_CreatedBy_fk",
                table: "MasterReferral");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy_fk",
                table: "MasterRejectionReason");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy_fk",
                table: "MasterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy_fk",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterService_User_CreatedBy_fk",
                table: "MasterService");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_CreatedBy_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_CreatedBy_fk",
                table: "MasterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterType_User_CreatedBy_fk",
                table: "MasterType");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy_fk",
                table: "MasterVFCEligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_CreatedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_CreatedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy_fk",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_CreatedBy_fk",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_CreatedBy_fk",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PhoneNumbers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientVitals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 697, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientSocialHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 417, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 690, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientImmunization",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEncounter",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDiagnosis",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterVFCEligibility",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterType",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterStatus",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterState",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterService",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 446, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 697, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRelationship",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRejectionReason",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterReferral",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterRace",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterProgram",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterPreferredLanguage",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 441, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterOccupation",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterManufacture",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterLocation",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 444, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterImmunization",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterImmunityStatus",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterICD",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 694, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterGender",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterFundingSource",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 440, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterEthnicity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 443, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 695, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterCPT",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 439, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterCountry",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 445, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 696, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "MasterAdministrationSite",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: true,
                defaultValue: new DateTime(2017, 7, 21, 16, 33, 34, 442, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 12, 6, 31, 693, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "InsuranceCompanies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_User_CreatedBy_fk",
                table: "InsuranceCompanies",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterAdministrationSite_User_CreatedBy_fk",
                table: "MasterAdministrationSite",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_CreatedBy_fk",
                table: "MasterCountry",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCPT_User_CreatedBy_fk",
                table: "MasterCPT",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_CreatedBy_fk",
                table: "MasterEthnicity",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_CreatedBy_fk",
                table: "MasterFundingSource",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterGender_User_CreatedBy_fk",
                table: "MasterGender",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterICD_User_CreatedBy_fk",
                table: "MasterICD",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunityStatus_User_CreatedBy_fk",
                table: "MasterImmunityStatus",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterImmunization_User_CreatedBy_fk",
                table: "MasterImmunization",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLocation_User_CreatedBy_fk",
                table: "MasterLocation",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterManufacture_User_CreatedBy_fk",
                table: "MasterManufacture",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterOccupation_User_CreatedBy_fk",
                table: "MasterOccupation",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPatientCommPreferences_User_CreatedBy_fk",
                table: "MasterPatientCommPreferences",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_CreatedBy_fk",
                table: "MasterPreferredLanguage",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterProgram_User_CreatedBy_fk",
                table: "MasterProgram",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_CreatedBy_fk",
                table: "MasterRace",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterReferral_User_CreatedBy_fk",
                table: "MasterReferral",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRejectionReason_User_CreatedBy_fk",
                table: "MasterRejectionReason",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRelationship_User_CreatedBy_fk",
                table: "MasterRelationship",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRouteOfAdministration_User_CreatedBy_fk",
                table: "MasterRouteOfAdministration",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterService_User_CreatedBy_fk",
                table: "MasterService",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_CreatedBy_fk",
                table: "MasterState",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_CreatedBy_fk",
                table: "MasterStatus",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterType_User_CreatedBy_fk",
                table: "MasterType",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterVFCEligibility_User_CreatedBy_fk",
                table: "MasterVFCEligibility",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
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
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
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
                name: "FK_PatientEncounter_User_CreatedBy_fk",
                table: "PatientEncounter",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_CreatedBy_fk",
                table: "PatientImmunization",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                table: "PatientSocialHistory",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_User_CreatedBy_fk",
                table: "PhoneNumbers",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_CreatedBy_fk",
                table: "Provider",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_CreatedBy_fk",
                table: "User",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
