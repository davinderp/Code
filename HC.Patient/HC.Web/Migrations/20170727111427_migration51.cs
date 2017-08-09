using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPastIllness_MasterStatus_Status",
                table: "PatientPastIllness");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PatientPastIllness",
                newName: "StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPastIllness_Status",
                table: "PatientPastIllness",
                newName: "IX_PatientPastIllness_StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPastIllness_MasterStatus_StatusID",
                table: "PatientPastIllness",
                column: "StatusID",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPastIllness_MasterStatus_StatusID",
                table: "PatientPastIllness");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "PatientPastIllness",
                newName: "Status");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPastIllness_StatusID",
                table: "PatientPastIllness",
                newName: "IX_PatientPastIllness_Status");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPastIllness_MasterStatus_Status",
                table: "PatientPastIllness",
                column: "Status",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
