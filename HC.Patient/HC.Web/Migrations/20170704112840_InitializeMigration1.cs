using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class InitializeMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_Patient_PatientID_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_Patient_PatientID_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_Patient_PatientID_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_Patient_PatientID_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterStatus_ClientStatus_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_User_CreatedBy_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterType_EmergencyContactRelationship_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterEthnicity_Ethnicity_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterGender_Gender_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterStatus_MaritalStatus_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Provider_PrimaryProvider_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterRace_Race_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterRace_SecondaryRace_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_MasterType_Suffix_fk",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_User_UpdatedBy_fk",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_UpdatedBy_fk",
                table: "Patients",
                newName: "IX_Patients_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Suffix_fk",
                table: "Patients",
                newName: "IX_Patients_Suffix_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_SecondaryRace_fk",
                table: "Patients",
                newName: "IX_Patients_SecondaryRace_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Race_fk",
                table: "Patients",
                newName: "IX_Patients_Race_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_PrimaryProvider_fk",
                table: "Patients",
                newName: "IX_Patients_PrimaryProvider_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_MaritalStatus_fk",
                table: "Patients",
                newName: "IX_Patients_MaritalStatus_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Gender_fk",
                table: "Patients",
                newName: "IX_Patients_Gender_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Ethnicity_fk",
                table: "Patients",
                newName: "IX_Patients_Ethnicity_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_EmergencyContactRelationship_fk",
                table: "Patients",
                newName: "IX_Patients_EmergencyContactRelationship_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_CreatedBy_fk",
                table: "Patients",
                newName: "IX_Patients_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_ClientStatus_fk",
                table: "Patients",
                newName: "IX_Patients_ClientStatus_fk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "PatientID");

            migrationBuilder.CreateTable(
                name: "ClientPreference",
                columns: table => new
                {
                    ClientPreferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    PreferredLanguage_fk = table.Column<int>(nullable: false),
                    ReceiveSMS = table.Column<bool>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPreference", x => x.ClientPreferenceID);
                    table.ForeignKey(
                        name: "FK_ClientPreference_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientPreference_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                        column: x => x.PreferredLanguage_fk,
                        principalTable: "MasterPreferredLanguage",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientPreference_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    HomeAddress1 = table.Column<string>(maxLength: 200, nullable: true),
                    HomeAddress2 = table.Column<string>(maxLength: 200, nullable: true),
                    HomeCity = table.Column<string>(maxLength: 100, nullable: true),
                    HomePhone = table.Column<string>(maxLength: 20, nullable: true),
                    HomeState_fk = table.Column<int>(nullable: false),
                    HomeZip = table.Column<string>(maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsMailingSame = table.Column<bool>(nullable: false),
                    MailingAddress1 = table.Column<string>(maxLength: 200, nullable: true),
                    MailingAddress2 = table.Column<string>(maxLength: 200, nullable: true),
                    MailingCity = table.Column<string>(maxLength: 100, nullable: true),
                    MailingPhone = table.Column<string>(maxLength: 20, nullable: true),
                    MailingState_fk = table.Column<int>(nullable: false),
                    MailingZip = table.Column<string>(maxLength: 20, nullable: true),
                    PatientID_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAddress", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_PatientAddress_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAddress_MasterState_HomeState_fk",
                        column: x => x.HomeState_fk,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAddress_MasterState_MailingState_fk",
                        column: x => x.MailingState_fk,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAddress_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAddress_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreference_CreatedBy_fk",
                table: "ClientPreference",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreference_PatientID_fk",
                table: "ClientPreference",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreference_PreferredLanguage_fk",
                table: "ClientPreference",
                column: "PreferredLanguage_fk");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPreference_UpdatedBy_fk",
                table: "ClientPreference",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_HomeState_fk",
                table: "PatientAddress",
                column: "HomeState_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_MailingState_fk",
                table: "PatientAddress",
                column: "MailingState_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_PatientID_fk",
                table: "PatientAddress",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_UpdatedBy_fk",
                table: "PatientAddress",
                column: "UpdatedBy_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_Patients_PatientID_fk",
                table: "PatientDocuments",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_Patients_PatientID_fk",
                table: "PatientEmploymentDetail",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_Patients_PatientID_fk",
                table: "PatientGuardian",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_Patients_PatientID_fk",
                table: "PatientInsuranceDetails",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_ClientStatus_fk",
                table: "Patients",
                column: "ClientStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients",
                column: "EmergencyContactRelationship_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
                table: "Patients",
                column: "Ethnicity_fk",
                principalTable: "MasterEthnicity",
                principalColumn: "EthnicityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterGender_Gender_fk",
                table: "Patients",
                column: "Gender_fk",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients",
                column: "MaritalStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider_fk",
                table: "Patients",
                column: "PrimaryProvider_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_Race_fk",
                table: "Patients",
                column: "Race_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients",
                column: "SecondaryRace_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients",
                column: "Suffix_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_Patients_PatientID_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_Patients_PatientID_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_Patients_PatientID_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_Patients_PatientID_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_ClientStatus_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterGender_Gender_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_Race_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "ClientPreference");

            migrationBuilder.DropTable(
                name: "PatientAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_UpdatedBy_fk",
                table: "Patient",
                newName: "IX_Patient_UpdatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Suffix_fk",
                table: "Patient",
                newName: "IX_Patient_Suffix_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_SecondaryRace_fk",
                table: "Patient",
                newName: "IX_Patient_SecondaryRace_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Race_fk",
                table: "Patient",
                newName: "IX_Patient_Race_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PrimaryProvider_fk",
                table: "Patient",
                newName: "IX_Patient_PrimaryProvider_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_MaritalStatus_fk",
                table: "Patient",
                newName: "IX_Patient_MaritalStatus_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Gender_fk",
                table: "Patient",
                newName: "IX_Patient_Gender_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Ethnicity_fk",
                table: "Patient",
                newName: "IX_Patient_Ethnicity_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_EmergencyContactRelationship_fk",
                table: "Patient",
                newName: "IX_Patient_EmergencyContactRelationship_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_CreatedBy_fk",
                table: "Patient",
                newName: "IX_Patient_CreatedBy_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ClientStatus_fk",
                table: "Patient",
                newName: "IX_Patient_ClientStatus_fk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_Patient_PatientID_fk",
                table: "PatientDocuments",
                column: "PatientID_fk",
                principalTable: "Patient",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_Patient_PatientID_fk",
                table: "PatientEmploymentDetail",
                column: "PatientID_fk",
                principalTable: "Patient",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_Patient_PatientID_fk",
                table: "PatientGuardian",
                column: "PatientID_fk",
                principalTable: "Patient",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_Patient_PatientID_fk",
                table: "PatientInsuranceDetails",
                column: "PatientID_fk",
                principalTable: "Patient",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterStatus_ClientStatus_fk",
                table: "Patient",
                column: "ClientStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_User_CreatedBy_fk",
                table: "Patient",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterType_EmergencyContactRelationship_fk",
                table: "Patient",
                column: "EmergencyContactRelationship_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterEthnicity_Ethnicity_fk",
                table: "Patient",
                column: "Ethnicity_fk",
                principalTable: "MasterEthnicity",
                principalColumn: "EthnicityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterGender_Gender_fk",
                table: "Patient",
                column: "Gender_fk",
                principalTable: "MasterGender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterStatus_MaritalStatus_fk",
                table: "Patient",
                column: "MaritalStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Provider_PrimaryProvider_fk",
                table: "Patient",
                column: "PrimaryProvider_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterRace_Race_fk",
                table: "Patient",
                column: "Race_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterRace_SecondaryRace_fk",
                table: "Patient",
                column: "SecondaryRace_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_MasterType_Suffix_fk",
                table: "Patient",
                column: "Suffix_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_User_UpdatedBy_fk",
                table: "Patient",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
