using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration47 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 563, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPastIllness",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 572, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 572, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 565, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 565, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 568, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 568, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 565, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 564, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 564, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 563, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPastIllness",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 572, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 572, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 565, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 565, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 568, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 571, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 568, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 565, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 564, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 569, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 564, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 570, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 15, 12, 42, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");
        }
    }
}
