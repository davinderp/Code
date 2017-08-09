using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration72 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointment_AppointmentTypeID",
                table: "PatientAppointment",
                column: "AppointmentTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointment_AppointmentType_AppointmentTypeID",
                table: "PatientAppointment",
                column: "AppointmentTypeID",
                principalTable: "AppointmentType",
                principalColumn: "AppointmentTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointment_AppointmentType_AppointmentTypeID",
                table: "PatientAppointment");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointment_AppointmentTypeID",
                table: "PatientAppointment");
        }
    }
}
