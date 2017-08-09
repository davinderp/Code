using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Data.Migrations
{
    public partial class InitalizeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "MasterCountry",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCountry", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_MasterCountry_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterEthnicity",
                columns: table => new
                {
                    EthnicityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    EthnicityName = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterEthnicity", x => x.EthnicityID);
                    table.ForeignKey(
                        name: "FK_MasterEthnicity_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterFundingSource",
                columns: table => new
                {
                    FundingSourceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    FundingSource = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFundingSource", x => x.FundingSourceID);
                    table.ForeignKey(
                        name: "FK_MasterFundingSource_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterPreferredLanguage",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPreferredLanguage", x => x.LanguageID);
                    table.ForeignKey(
                        name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterRace",
                columns: table => new
                {
                    RaceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    RaceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterRace", x => x.RaceID);
                    table.ForeignKey(
                        name: "FK_MasterRace_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterState",
                columns: table => new
                {
                    StateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterState", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_MasterState_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StatusName = table.Column<int>(nullable: false),
                    StatusType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterStatus", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_MasterStatus_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientBasicInformation",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Citizenship_fk = table.Column<int>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    DrivingLicenceExpiryDate = table.Column<DateTime>(nullable: false),
                    DrivingLicenceNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmergencyContactName = table.Column<string>(nullable: true),
                    EmergencyContactPhone = table.Column<string>(nullable: true),
                    EmergencyContactRelationship = table.Column<string>(nullable: true),
                    Ethnicity_fk = table.Column<int>(nullable: false),
                    EyeColor = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    FundSourceEnd = table.Column<DateTime>(nullable: false),
                    FundSourceStart = table.Column<DateTime>(nullable: false),
                    FundSource_fk = table.Column<int>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    HairColor = table.Column<string>(nullable: true),
                    HomeAddress1 = table.Column<string>(nullable: true),
                    HomeAddress2 = table.Column<string>(nullable: true),
                    HomeCity = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeState_fk = table.Column<int>(nullable: false),
                    HomeZip = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    MedicaidNum = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PatientNo = table.Column<string>(nullable: true),
                    PreferredLanguage_fk = table.Column<int>(nullable: false),
                    Race_fk = table.Column<int>(nullable: false),
                    ReceiveSMS = table.Column<bool>(nullable: false),
                    ReferralDate = table.Column<DateTime>(nullable: false),
                    ReferralReason = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true),
                    SecondaryRace_fk = table.Column<int>(nullable: false),
                    Service = table.Column<string>(nullable: true),
                    Siblings = table.Column<string>(nullable: true),
                    Status_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientBasicInformation", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterCountry_Citizenship_fk",
                        column: x => x.Citizenship_fk,
                        principalTable: "MasterCountry",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterEthnicity_Ethnicity_fk",
                        column: x => x.Ethnicity_fk,
                        principalTable: "MasterEthnicity",
                        principalColumn: "EthnicityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterFundingSource_FundSource_fk",
                        column: x => x.FundSource_fk,
                        principalTable: "MasterFundingSource",
                        principalColumn: "FundingSourceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterState_HomeState_fk",
                        column: x => x.HomeState_fk,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterPreferredLanguage_PreferredLanguage_fk",
                        column: x => x.PreferredLanguage_fk,
                        principalTable: "MasterPreferredLanguage",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterRace_Race_fk",
                        column: x => x.Race_fk,
                        principalTable: "MasterRace",
                        principalColumn: "RaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterRace_SecondaryRace_fk",
                        column: x => x.SecondaryRace_fk,
                        principalTable: "MasterRace",
                        principalColumn: "RaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_MasterStatus_Status_fk",
                        column: x => x.Status_fk,
                        principalTable: "MasterStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientBasicInformation_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterCountry_DeletedBy_fk",
                table: "MasterCountry",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEthnicity_DeletedBy_fk",
                table: "MasterEthnicity",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterFundingSource_DeletedBy_fk",
                table: "MasterFundingSource",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPreferredLanguage_DeletedBy_fk",
                table: "MasterPreferredLanguage",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterRace_DeletedBy_fk",
                table: "MasterRace",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterState_DeletedBy_fk",
                table: "MasterState",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterStatus_DeletedBy_fk",
                table: "MasterStatus",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_Citizenship_fk",
                table: "PatientBasicInformation",
                column: "Citizenship_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_CreatedBy_fk",
                table: "PatientBasicInformation",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_Ethnicity_fk",
                table: "PatientBasicInformation",
                column: "Ethnicity_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_FundSource_fk",
                table: "PatientBasicInformation",
                column: "FundSource_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_HomeState_fk",
                table: "PatientBasicInformation",
                column: "HomeState_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_PreferredLanguage_fk",
                table: "PatientBasicInformation",
                column: "PreferredLanguage_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_Race_fk",
                table: "PatientBasicInformation",
                column: "Race_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_SecondaryRace_fk",
                table: "PatientBasicInformation",
                column: "SecondaryRace_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_Status_fk",
                table: "PatientBasicInformation",
                column: "Status_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientBasicInformation_UpdatedBy_fk",
                table: "PatientBasicInformation",
                column: "UpdatedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientBasicInformation");

            migrationBuilder.DropTable(
                name: "MasterCountry");

            migrationBuilder.DropTable(
                name: "MasterEthnicity");

            migrationBuilder.DropTable(
                name: "MasterFundingSource");

            migrationBuilder.DropTable(
                name: "MasterState");

            migrationBuilder.DropTable(
                name: "MasterPreferredLanguage");

            migrationBuilder.DropTable(
                name: "MasterRace");

            migrationBuilder.DropTable(
                name: "MasterStatus");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
