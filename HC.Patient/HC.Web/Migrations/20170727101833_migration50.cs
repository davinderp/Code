using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "PatientMedicalFamilyHistory",
                newName: "GenderID");

            migrationBuilder.RenameColumn(
                name: "Disease",
                table: "PatientMedicalFamilyHistory",
                newName: "DiseaseID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_Gender",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_GenderID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_Disease",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_DiseaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_DiseaseID",
                table: "PatientMedicalFamilyHistory",
                column: "DiseaseID",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_GenderID",
                table: "PatientMedicalFamilyHistory",
                column: "GenderID",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_DiseaseID",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_GenderID",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.RenameColumn(
                name: "GenderID",
                table: "PatientMedicalFamilyHistory",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "DiseaseID",
                table: "PatientMedicalFamilyHistory",
                newName: "Disease");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_GenderID",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_Gender");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_DiseaseID",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_Disease");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease",
                table: "PatientMedicalFamilyHistory",
                column: "Disease",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender",
                table: "PatientMedicalFamilyHistory",
                column: "Gender",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
