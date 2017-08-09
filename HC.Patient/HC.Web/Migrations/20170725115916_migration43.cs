using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight_lbs",
                table: "PatientVitals",
                newName: "WeightLbs");

            migrationBuilder.RenameColumn(
                name: "Height_in",
                table: "PatientVitals",
                newName: "HeightIn");

            migrationBuilder.RenameColumn(
                name: "Height_ft",
                table: "PatientVitals",
                newName: "HeightFt");

            migrationBuilder.RenameColumn(
                name: "BP_systolic",
                table: "PatientVitals",
                newName: "BPSystolic");

            migrationBuilder.RenameColumn(
                name: "BP_diastolic",
                table: "PatientVitals",
                newName: "BPDiastolic");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 861, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 861, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 865, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 856, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 754, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 865, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 861, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeightLbs",
                table: "PatientVitals",
                newName: "Weight_lbs");

            migrationBuilder.RenameColumn(
                name: "HeightIn",
                table: "PatientVitals",
                newName: "Height_in");

            migrationBuilder.RenameColumn(
                name: "HeightFt",
                table: "PatientVitals",
                newName: "Height_ft");

            migrationBuilder.RenameColumn(
                name: "BPSystolic",
                table: "PatientVitals",
                newName: "BP_systolic");

            migrationBuilder.RenameColumn(
                name: "BPDiastolic",
                table: "PatientVitals",
                newName: "BP_diastolic");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 861, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 861, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 865, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 754, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 856, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 758, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 865, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 765, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 760, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 757, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 858, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 763, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 864, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 861, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 761, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 860, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 762, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 862, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 756, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 857, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 764, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 863, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 16, 48, 759, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 29, 15, 859, DateTimeKind.Local));
        }
    }
}
