using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration48 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_Country",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_State",
                table: "PatientAddress");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "PatientAddress",
                newName: "StateID");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "PatientAddress",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_State",
                table: "PatientAddress",
                newName: "IX_PatientAddress_StateID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_Country",
                table: "PatientAddress",
                newName: "IX_PatientAddress_CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_CountryID",
                table: "PatientAddress",
                column: "CountryID",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_StateID",
                table: "PatientAddress",
                column: "StateID",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_CountryID",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_StateID",
                table: "PatientAddress");

            migrationBuilder.RenameColumn(
                name: "StateID",
                table: "PatientAddress",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "PatientAddress",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_StateID",
                table: "PatientAddress",
                newName: "IX_PatientAddress_State");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_CountryID",
                table: "PatientAddress",
                newName: "IX_PatientAddress_Country");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_Country",
                table: "PatientAddress",
                column: "Country",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_State",
                table: "PatientAddress",
                column: "State",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
