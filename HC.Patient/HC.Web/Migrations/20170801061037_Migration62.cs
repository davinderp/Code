using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class Migration62 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "PrimaryProvider",
                table: "Patients",
                newName: "PrimaryDoctor");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PrimaryProvider",
                table: "Patients",
                newName: "IX_Patients_PrimaryDoctor");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_PrimaryDoctor",
                table: "Patients",
                column: "PrimaryDoctor",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_PrimaryDoctor",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "PrimaryDoctor",
                table: "Patients",
                newName: "PrimaryProvider");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PrimaryDoctor",
                table: "Patients",
                newName: "IX_Patients_PrimaryProvider");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider",
                table: "Patients",
                column: "PrimaryProvider",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
