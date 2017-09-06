using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "PatientCustomLabels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientCustomLabels_PatientID",
                table: "PatientCustomLabels",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientCustomLabels_Patients_PatientID",
                table: "PatientCustomLabels",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientCustomLabels_Patients_PatientID",
                table: "PatientCustomLabels");

            migrationBuilder.DropIndex(
                name: "IX_PatientCustomLabels_PatientID",
                table: "PatientCustomLabels");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "PatientCustomLabels");
        }
    }
}
