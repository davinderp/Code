using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration86 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Staff",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleID",
                table: "Staff",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_UserRoles_RoleID",
                table: "Staff",
                column: "RoleID",
                principalTable: "UserRoles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_UserRoles_RoleID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_RoleID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Staff");
        }
    }
}
