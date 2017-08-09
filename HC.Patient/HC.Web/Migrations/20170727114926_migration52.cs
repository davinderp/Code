using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration52 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested",
                table: "PatientPreference");

            migrationBuilder.RenameColumn(
                name: "ServiceRequested",
                table: "PatientPreference",
                newName: "ServiceRequestedID");

            migrationBuilder.RenameColumn(
                name: "PreferredLanguage",
                table: "PatientPreference",
                newName: "PreferredLanguageID");

            migrationBuilder.RenameColumn(
                name: "PatientOfficeCommPreferences",
                table: "PatientPreference",
                newName: "PatientOfficeCommPreferencesID");

            migrationBuilder.RenameColumn(
                name: "PatientHomeCommPreferences",
                table: "PatientPreference",
                newName: "PatientHomeCommPreferencesID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_ServiceRequested",
                table: "PatientPreference",
                newName: "IX_PatientPreference_ServiceRequestedID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PreferredLanguage",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PreferredLanguageID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientOfficeCommPreferences",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientOfficeCommPreferencesID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientHomeCommPreferences",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientHomeCommPreferencesID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferencesID",
                table: "PatientPreference",
                column: "PatientHomeCommPreferencesID",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferencesID",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferencesID",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguageID",
                table: "PatientPreference",
                column: "PreferredLanguageID",
                principalTable: "MasterPreferredLanguage",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequestedID",
                table: "PatientPreference",
                column: "ServiceRequestedID",
                principalTable: "MasterService",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferencesID",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferencesID",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguageID",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequestedID",
                table: "PatientPreference");

            migrationBuilder.RenameColumn(
                name: "ServiceRequestedID",
                table: "PatientPreference",
                newName: "ServiceRequested");

            migrationBuilder.RenameColumn(
                name: "PreferredLanguageID",
                table: "PatientPreference",
                newName: "PreferredLanguage");

            migrationBuilder.RenameColumn(
                name: "PatientOfficeCommPreferencesID",
                table: "PatientPreference",
                newName: "PatientOfficeCommPreferences");

            migrationBuilder.RenameColumn(
                name: "PatientHomeCommPreferencesID",
                table: "PatientPreference",
                newName: "PatientHomeCommPreferences");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_ServiceRequestedID",
                table: "PatientPreference",
                newName: "IX_PatientPreference_ServiceRequested");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PreferredLanguageID",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PreferredLanguage");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientOfficeCommPreferencesID",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientOfficeCommPreferences");

            migrationBuilder.RenameIndex(
                name: "IX_PatientPreference_PatientHomeCommPreferencesID",
                table: "PatientPreference",
                newName: "IX_PatientPreference_PatientHomeCommPreferences");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences",
                table: "PatientPreference",
                column: "PatientHomeCommPreferences",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferences",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage",
                table: "PatientPreference",
                column: "PreferredLanguage",
                principalTable: "MasterPreferredLanguage",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested",
                table: "PatientPreference",
                column: "ServiceRequested",
                principalTable: "MasterService",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
