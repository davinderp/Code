using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientEncounter_Provider_ProviderId",
            //    table: "PatientEncounter");

            //migrationBuilder.RenameColumn(
            //    name: "ProviderId",
            //    table: "PatientEncounter",
            //    newName: "DoctorId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PatientEncounter_ProviderId",
            //    table: "PatientEncounter",
            //    newName: "IX_PatientEncounter_DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Doctors_DoctorId",
                table: "PatientEncounter",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Doctors_DoctorId",
                table: "PatientEncounter");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "PatientEncounter",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_DoctorId",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Provider_ProviderId",
                table: "PatientEncounter",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
