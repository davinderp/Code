using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterAddressType_AddressTypeID",
                table: "PatientAddress");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Provider",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local),
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Provider",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientVitals",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientSocialHistory",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 762, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 370, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Patients",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientPreference",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientImmunization",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientEncounter",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientDiagnosis",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "AddressTypeID",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "PatientAddress",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterVFCEligibility",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterType",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterStatus",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterState",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterService",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterRouteOfAdministration",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterRelationship",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterRejectionReason",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterReferral",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterRace",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterProgram",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterPreferredLanguage",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterPatientCommPreferences",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterOccupation",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterManufacture",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterLocation",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterImmunization",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterImmunityStatus",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterICD",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterGender",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterFundingSource",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 763, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterEthnicity",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterCPT",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 763, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterCountry",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterAdministrationSite",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MasterAddressType",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "InsuranceCompanies",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterAddressType_AddressTypeID",
                table: "PatientAddress",
                column: "AddressTypeID",
                principalTable: "MasterAddressType",
                principalColumn: "AddressTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterAddressType_AddressTypeID",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientVitals");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientSocialHistory");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientPreference");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientImmunization");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientEncounter");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterVFCEligibility");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterType");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterStatus");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterState");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterService");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterRouteOfAdministration");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterRelationship");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterRejectionReason");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterReferral");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterRace");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterProgram");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterPatientCommPreferences");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterOccupation");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterManufacture");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterLocation");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterImmunization");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterImmunityStatus");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterICD");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterGender");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterFundingSource");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterEthnicity");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterCPT");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterCountry");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterAdministrationSite");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MasterAddressType");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "InsuranceCompanies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 370, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 762, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "AddressTypeID",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 770, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 767, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 763, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 768, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 763, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 769, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 16, 29, 27, 766, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterAddressType_AddressTypeID",
                table: "PatientAddress",
                column: "AddressTypeID",
                principalTable: "MasterAddressType",
                principalColumn: "AddressTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
