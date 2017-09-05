using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authorization_AuthorizationProcedures_AuthorizationProcedureID",
                table: "Authorization");

            migrationBuilder.DropIndex(
                name: "IX_AuthorizationProcedures_AuthorizationId",
                table: "AuthorizationProcedures");

            migrationBuilder.DropIndex(
                name: "IX_Authorization_AuthorizationProcedureID",
                table: "Authorization");

            migrationBuilder.DropColumn(
                name: "AuthorizationProcedureID",
                table: "Authorization");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_AuthorizationId",
                table: "AuthorizationProcedures",
                column: "AuthorizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AuthorizationProcedures_AuthorizationId",
                table: "AuthorizationProcedures");

            migrationBuilder.AddColumn<int>(
                name: "AuthorizationProcedureID",
                table: "Authorization",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_AuthorizationId",
                table: "AuthorizationProcedures",
                column: "AuthorizationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_AuthorizationProcedureID",
                table: "Authorization",
                column: "AuthorizationProcedureID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorization_AuthorizationProcedures_AuthorizationProcedureID",
                table: "Authorization",
                column: "AuthorizationProcedureID",
                principalTable: "AuthorizationProcedures",
                principalColumn: "AuthorizationProcedureId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
