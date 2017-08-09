using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration76 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_User_CreatedBy",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_User_DeletedBy",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_User_UpdatedBy",
                table: "Organization");

            //migrationBuilder.DropIndex(
            //    name: "IX_Organization_CreatedBy",
            //    table: "Organization");

            //migrationBuilder.DropIndex(
            //    name: "IX_Organization_DeletedBy",
            //    table: "Organization");

            //migrationBuilder.DropIndex(
            //    name: "IX_Organization_UpdatedBy",
            //    table: "Organization");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationID",
                table: "User",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_User_OrganizationID",
                table: "User",
                column: "OrganizationID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Organization_OrganizationID",
                table: "User",
                column: "OrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Organization_OrganizationID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_OrganizationID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "OrganizationID",
                table: "User");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_CreatedBy",
                table: "Organization",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_DeletedBy",
                table: "Organization",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_UpdatedBy",
                table: "Organization",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_User_CreatedBy",
                table: "Organization",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_User_DeletedBy",
                table: "Organization",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_User_UpdatedBy",
                table: "Organization",
                column: "UpdatedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
