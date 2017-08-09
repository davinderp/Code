using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientPreference");

            migrationBuilder.CreateTable(
                name: "PatientPreference",
                columns: table => new
                {
                    PatientPreferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddClientToCaseLoad = table.Column<bool>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    PatientHomeCommPreferences_fk = table.Column<int>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    PatientOfficeCommPreferences_fk = table.Column<int>(nullable: false),
                    PreferredLanguage_fk = table.Column<int>(nullable: false),
                    ProgramStartDate = table.Column<DateTime>(nullable: false),
                    Program_fk = table.Column<int>(nullable: false),
                    ReceiveSMS = table.Column<bool>(nullable: false),
                    ReferralDate = table.Column<DateTime>(nullable: false),
                    ReferralReason = table.Column<int>(nullable: false),
                    Referral_fk = table.Column<int>(nullable: false),
                    ServiceRequested_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPreference", x => x.PatientPreferenceID);
                    table.ForeignKey(
                        name: "FK_PatientPreference_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_MasterPatientCommPreferences_PatientHomeCommPreferences_fk",
                        column: x => x.PatientHomeCommPreferences_fk,
                        principalTable: "MasterPatientCommPreferences",
                        principalColumn: "PatientCommPreferencesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_MasterPatientCommPreferences_PatientOfficeCommPreferences_fk",
                        column: x => x.PatientOfficeCommPreferences_fk,
                        principalTable: "MasterPatientCommPreferences",
                        principalColumn: "PatientCommPreferencesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                        column: x => x.PreferredLanguage_fk,
                        principalTable: "MasterPreferredLanguage",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_MasterProgram_Program_fk",
                        column: x => x.Program_fk,
                        principalTable: "MasterProgram",
                        principalColumn: "ProgramID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_MasterReferral_Referral_fk",
                        column: x => x.Referral_fk,
                        principalTable: "MasterReferral",
                        principalColumn: "ReferralID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_MasterService_ServiceRequested_fk",
                        column: x => x.ServiceRequested_fk,
                        principalTable: "MasterService",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPreference_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_PatientHomeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientHomeCommPreferences_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_PatientID_fk",
                table: "PatientPreference",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_PatientOfficeCommPreferences_fk",
                table: "PatientPreference",
                column: "PatientOfficeCommPreferences_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_PreferredLanguage_fk",
                table: "PatientPreference",
                column: "PreferredLanguage_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_Program_fk",
                table: "PatientPreference",
                column: "Program_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_Referral_fk",
                table: "PatientPreference",
                column: "Referral_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_ServiceRequested_fk",
                table: "PatientPreference",
                column: "ServiceRequested_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPreference_UpdatedBy_fk",
                table: "PatientPreference",
                column: "UpdatedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientPreference");

            migrationBuilder.CreateTable(
                name: "ClientPreference",
                columns: table => new
                {
                    ClientPreferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddClientToCaseLoad = table.Column<bool>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    PatientHomeCommPreferences_fk = table.Column<int>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    PatientOfficeCommPreferences_fk = table.Column<int>(nullable: false),
                    PreferredLanguage_fk = table.Column<int>(nullable: false),
                    ProgramStartDate = table.Column<DateTime>(nullable: false),
                    Program_fk = table.Column<int>(nullable: false),
                    ReceiveSMS = table.Column<bool>(nullable: false),
                    ReferralDate = table.Column<DateTime>(nullable: false),
                    ReferralReason = table.Column<int>(nullable: false),
                    Referral_fk = table.Column<int>(nullable: false),
                    ServiceRequested_fk = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientPreference_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientPreference_MasterPreferredLanguage_PreferredLanguage_fk",
                        column: x => x.PreferredLanguage_fk,
                        principalTable: "MasterPreferredLanguage",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientPreference_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
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
        }
    }
}
