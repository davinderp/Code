using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "UserID",
            //    table: "Clinicians",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clinicians_UserID",
            //    table: "Clinicians",
            //    column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinicians_User_UserID",
                table: "Clinicians",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinicians_User_UserID",
                table: "Clinicians");

            migrationBuilder.DropIndex(
                name: "IX_Clinicians_UserID",
                table: "Clinicians");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Clinicians");
        }
    }
}
