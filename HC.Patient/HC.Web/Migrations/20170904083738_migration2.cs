using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_MasterAllergies_AllergyType",
                table: "PatientAllergies");

            migrationBuilder.RenameColumn(
                name: "AllergyType",
                table: "PatientAllergies",
                newName: "AllergyTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAllergies_AllergyType",
                table: "PatientAllergies",
                newName: "IX_PatientAllergies_AllergyTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_MasterAllergies_AllergyTypeID",
                table: "PatientAllergies",
                column: "AllergyTypeID",
                principalTable: "MasterAllergies",
                principalColumn: "AllergyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_MasterAllergies_AllergyTypeID",
                table: "PatientAllergies");

            migrationBuilder.RenameColumn(
                name: "AllergyTypeID",
                table: "PatientAllergies",
                newName: "AllergyType");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAllergies_AllergyTypeID",
                table: "PatientAllergies",
                newName: "IX_PatientAllergies_AllergyType");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_MasterAllergies_AllergyType",
                table: "PatientAllergies",
                column: "AllergyType",
                principalTable: "MasterAllergies",
                principalColumn: "AllergyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
