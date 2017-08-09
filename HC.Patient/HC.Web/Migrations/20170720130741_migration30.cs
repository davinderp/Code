using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationShip_fk",
            //    table: "PatientMedicalFamilyHistory");

            migrationBuilder.RenameColumn(
                name: "RelationShip_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "RelationshipID_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_RelationShip_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_RelationshipID_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationshipID_fk",
                table: "PatientMedicalFamilyHistory",
                column: "RelationshipID_fk",
                principalTable: "MasterRelationship",
                principalColumn: "RelationshipID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationshipID_fk",
                table: "PatientMedicalFamilyHistory");

            migrationBuilder.RenameColumn(
                name: "RelationshipID_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "RelationShip_fk");

            migrationBuilder.RenameIndex(
                name: "IX_PatientMedicalFamilyHistory_RelationshipID_fk",
                table: "PatientMedicalFamilyHistory",
                newName: "IX_PatientMedicalFamilyHistory_RelationShip_fk");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationShip_fk",
            //    table: "PatientMedicalFamilyHistory",
            //    column: "RelationShip_fk",
            //    principalTable: "MasterRelationship",
            //    principalColumn: "RelationshipID",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
