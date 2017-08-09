using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientSocialHistory",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientSocialHistory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientPreference",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientPreference",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientImmunization",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientImmunization",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientEncounter",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientEncounter",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientDiagnosis",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientDiagnosis",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy_fk",
                table: "PatientAddress",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientAddress",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_DeletedBy_fk",
                table: "PatientSocialHistory",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DeletedBy_fk",
                table: "Patients",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_DeletedBy_fk",
                table: "PatientPreference",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_DeletedBy_fk",
                table: "PatientInsuranceDetails",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_DeletedBy_fk",
                table: "PatientImmunization",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_DeletedBy_fk",
                table: "PatientEncounter",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnosis_DeletedBy_fk",
                table: "PatientDiagnosis",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_DeletedBy_fk",
                table: "PatientAddress",
                column: "DeletedBy_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_DeletedBy_fk",
                table: "PatientAddress",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_User_DeletedBy_fk",
                table: "PatientDiagnosis",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_User_DeletedBy_fk",
                table: "PatientEncounter",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_User_DeletedBy_fk",
                table: "PatientImmunization",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_DeletedBy_fk",
                table: "PatientInsuranceDetails",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_DeletedBy_fk",
                table: "PatientPreference",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_DeletedBy_fk",
                table: "Patients",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientSocialHistory_User_DeletedBy_fk",
                table: "PatientSocialHistory",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_DeletedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_User_DeletedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_User_DeletedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_User_DeletedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_DeletedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_DeletedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_DeletedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientSocialHistory_User_DeletedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropIndex(
                name: "IX_PatientSocialHistory_DeletedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DeletedBy_fk",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_PatientPreference_DeletedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropIndex(
                name: "IX_PatientInsuranceDetails_DeletedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropIndex(
                name: "IX_PatientImmunization_DeletedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropIndex(
                name: "IX_PatientEncounter_DeletedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropIndex(
                name: "IX_PatientDiagnosis_DeletedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropIndex(
                name: "IX_PatientAddress_DeletedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientSocialHistory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientSocialHistory");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientPreference");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientImmunization");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientImmunization");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientEncounter");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientEncounter");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "DeletedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientAddress");
        }
    }
}
