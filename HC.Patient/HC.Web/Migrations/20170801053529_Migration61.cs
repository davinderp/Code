using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class Migration61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ProviderId",
                table: "Doctors",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Provider_ProviderId",
                table: "Doctors",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Provider_ProviderId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_ProviderId",
                table: "Doctors");
        }
    }
}
