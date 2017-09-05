using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "PatientGuardian");

            migrationBuilder.AddColumn<int>(
                name: "RelationshipID",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PatientGuardian_RelationshipID",
                table: "PatientGuardian",
                column: "RelationshipID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_MasterRelationship_RelationshipID",
                table: "PatientGuardian",
                column: "RelationshipID",
                principalTable: "MasterRelationship",
                principalColumn: "RelationshipID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_MasterRelationship_RelationshipID",
                table: "PatientGuardian");

            migrationBuilder.DropIndex(
                name: "IX_PatientGuardian_RelationshipID",
                table: "PatientGuardian");

            migrationBuilder.DropColumn(
                name: "RelationshipID",
                table: "PatientGuardian");

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "PatientGuardian",
                nullable: true);
        }
    }
}
