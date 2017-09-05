using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "PatientAllergies");

            migrationBuilder.AddColumn<int>(
                name: "ReactionID",
                table: "PatientAllergies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_ReactionID",
                table: "PatientAllergies",
                column: "ReactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_MasterReaction_ReactionID",
                table: "PatientAllergies",
                column: "ReactionID",
                principalTable: "MasterReaction",
                principalColumn: "ReactionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_MasterReaction_ReactionID",
                table: "PatientAllergies");

            migrationBuilder.DropIndex(
                name: "IX_PatientAllergies_ReactionID",
                table: "PatientAllergies");

            migrationBuilder.DropColumn(
                name: "ReactionID",
                table: "PatientAllergies");

            migrationBuilder.AddColumn<string>(
                name: "Reaction",
                table: "PatientAllergies",
                maxLength: 100,
                nullable: true);
        }
    }
}
