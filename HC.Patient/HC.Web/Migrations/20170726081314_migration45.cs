using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 725, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 733, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 658, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 777, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 725, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 730, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 724, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 724, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 730, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 724, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 730, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 725, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 733, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 778, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 721, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 778, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "PatientPastIllness",
                columns: table => new
                {
                    PastIllnessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientPastIllness");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 725, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 733, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 777, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 658, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 725, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 730, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 724, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 724, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 730, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 724, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 730, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 725, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 733, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 723, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 732, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 727, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 779, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 778, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 722, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 729, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 778, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 721, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 731, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 17, 46, 57, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 26, 13, 43, 13, 726, DateTimeKind.Local));
        }
    }
}
