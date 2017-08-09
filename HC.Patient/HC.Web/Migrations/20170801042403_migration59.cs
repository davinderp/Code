using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration59 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientImmunization_Provider_AdministeredBy",
            //    table: "PatientImmunization");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientImmunization_Provider_OrderBy",
            //    table: "PatientImmunization");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Doctors_AdministeredBy",
                table: "PatientImmunization",
                column: "AdministeredBy",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Doctors_OrderBy",
                table: "PatientImmunization",
                column: "OrderBy",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Doctors_DoctorId",
                table: "PatientEncounter",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            // migrationBuilder.CreateIndex(
            //name: "IX_PhoneNumbers_DoctorID",
            //  table: "PhoneNumbers",
            // column: "DoctorID");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_PhoneNumbers_Doctors_DoctorID",
            //     table: "PhoneNumbers",
            //     column: "DoctorID",
            //     principalTable: "Doctors",
            //     principalColumn: "DoctorID",
            //     onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Doctors_AdministeredBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Doctors_OrderBy",
                table: "PatientImmunization");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Provider_AdministeredBy",
                table: "PatientImmunization",
                column: "AdministeredBy",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Provider_OrderBy",
                table: "PatientImmunization",
                column: "OrderBy",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
