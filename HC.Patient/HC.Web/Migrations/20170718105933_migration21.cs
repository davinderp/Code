using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternalID",
                table: "MasterRejectionReason");

            migrationBuilder.DropColumn(
                name: "NonVaccine",
                table: "MasterRejectionReason");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "MasterRejectionReason");

            migrationBuilder.DropColumn(
                name: "VaccineStatus",
                table: "MasterRejectionReason");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InternalID",
                table: "MasterRejectionReason",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NonVaccine",
                table: "MasterRejectionReason",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "MasterRejectionReason",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VaccineStatus",
                table: "MasterRejectionReason",
                maxLength: 50,
                nullable: true);
        }
    }
}
