using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID_fk",
                table: "MasterState",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterState_CountryID_fk",
                table: "MasterState",
                column: "CountryID_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_MasterCountry_CountryID_fk",
                table: "MasterState",
                column: "CountryID_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_MasterCountry_CountryID_fk",
                table: "MasterState");

            migrationBuilder.DropIndex(
                name: "IX_MasterState_CountryID_fk",
                table: "MasterState");

            migrationBuilder.DropColumn(
                name: "CountryID_fk",
                table: "MasterState");
        }
    }
}
