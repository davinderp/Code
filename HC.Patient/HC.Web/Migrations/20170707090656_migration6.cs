using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterState_State_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy_fk",
                table: "PatientPreference");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPhone_fk",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRequested_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Referral_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReferralDate",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "ReceiveSMS",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Program_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProgramStartDate",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "PreferredLanguage_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "AddClientToCaseLoad",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "VisitsAllowedPerYear",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "InsurancePersonSameAsPatient",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CardIssueDate",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "InsuranceType_fk",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "GuardianState_fk",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Occupation_fk",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "State_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expiration",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "DocumentType_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MailingState_fk",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsMailingSame",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "HomeCountry_fk",
                table: "PatientAddress",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MailCountry_fk",
                table: "PatientAddress",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_PhoneNumberTypeId_fk",
                table: "PhoneNumbers",
                column: "PhoneNumberTypeId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Email",
                table: "Patients",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_InsuranceType_fk",
                table: "PatientInsuranceDetails",
                column: "InsuranceType_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_HomeCountry_fk",
                table: "PatientAddress",
                column: "HomeCountry_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_MailCountry_fk",
                table: "PatientAddress",
                column: "MailCountry_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientAddress_MasterCountry_HomeCountry_fk",
            //    table: "PatientAddress",
            //    column: "HomeCountry_fk",
            //    principalTable: "MasterCountry",
            //    principalColumn: "CountryID",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry_fk",
                table: "PatientAddress",
                column: "MailCountry_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState_fk",
                table: "PatientAddress",
                column: "MailingState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy_fk",
                table: "PatientAddress",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments",
                column: "DocumentType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterState_State_fk",
                table: "PatientDocuments",
                column: "State_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                column: "EmploymentStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                table: "PatientEmploymentDetail",
                column: "Occupation_fk",
                principalTable: "MasterOccupation",
                principalColumn: "OccupationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                table: "PatientGuardian",
                column: "GuardianState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                column: "InsurancePlanType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsuranceType_fk",
                table: "PatientInsuranceDetails",
                column: "InsuranceType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientHomeCommPreferences_fk",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferences_fk",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                table: "PatientPreference",
                column: "PreferredLanguage_fk",
                principalTable: "MasterPreferredLanguage",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program_fk",
                table: "PatientPreference",
                column: "Program_fk",
                principalTable: "MasterProgram",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral_fk",
                table: "PatientPreference",
                column: "Referral_fk",
                principalTable: "MasterReferral",
                principalColumn: "ReferralID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                table: "PatientPreference",
                column: "ServiceRequested_fk",
                principalTable: "MasterService",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy_fk",
                table: "PatientPreference",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_MasterType_PhoneNumberTypeId_fk",
                table: "PhoneNumbers",
                column: "PhoneNumberTypeId_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider",
            //    column: "ProviderPhone_fk",
            //    principalTable: "PhoneNumbers",
            //    principalColumn: "PhoneNumberId",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientAddress_MasterCountry_HomeCountry_fk",
            //    table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterState_State_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsuranceType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_MasterType_PhoneNumberTypeId_fk",
                table: "PhoneNumbers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_PhoneNumberTypeId_fk",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Email",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_PatientInsuranceDetails_InsuranceType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropIndex(
                name: "IX_PatientAddress_HomeCountry_fk",
                table: "PatientAddress");

            migrationBuilder.DropIndex(
                name: "IX_PatientAddress_MailCountry_fk",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "InsuranceType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "HomeCountry_fk",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "MailCountry_fk",
                table: "PatientAddress");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPhone_fk",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRequested_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Referral_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReferralDate",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ReceiveSMS",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Program_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProgramStartDate",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PreferredLanguage_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AddClientToCaseLoad",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VisitsAllowedPerYear",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InsurancePersonSameAsPatient",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CardIssueDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuardianState_fk",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Occupation_fk",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "State_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVerified",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expiration",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentType_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MailingState_fk",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMailingSame",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState_fk",
                table: "PatientAddress",
                column: "MailingState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_UpdatedBy_fk",
                table: "PatientAddress",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments",
                column: "DocumentType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterState_State_fk",
                table: "PatientDocuments",
                column: "State_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                column: "EmploymentStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                table: "PatientEmploymentDetail",
                column: "Occupation_fk",
                principalTable: "MasterOccupation",
                principalColumn: "OccupationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                table: "PatientGuardian",
                column: "GuardianState_fk",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                column: "InsurancePlanType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientHomeCommPreferences_fk",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferences_fk",
                principalTable: "MasterPatientCommPreferences",
                principalColumn: "PatientCommPreferencesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                table: "PatientPreference",
                column: "PreferredLanguage_fk",
                principalTable: "MasterPreferredLanguage",
                principalColumn: "LanguageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterProgram_Program_fk",
                table: "PatientPreference",
                column: "Program_fk",
                principalTable: "MasterProgram",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterReferral_Referral_fk",
                table: "PatientPreference",
                column: "Referral_fk",
                principalTable: "MasterReferral",
                principalColumn: "ReferralID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                table: "PatientPreference",
                column: "ServiceRequested_fk",
                principalTable: "MasterService",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_UpdatedBy_fk",
                table: "PatientPreference",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider",
            //    column: "ProviderPhone_fk",
            //    principalTable: "PhoneNumbers",
            //    principalColumn: "PhoneNumberId",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
