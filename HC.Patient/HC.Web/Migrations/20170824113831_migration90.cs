using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Patients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_LocationID",
                table: "Patients",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Location_LocationID",
                table: "Patients",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Location_LocationID",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_LocationID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Patients");
        }
    }
}
