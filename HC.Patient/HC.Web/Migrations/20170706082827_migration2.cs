using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "MasterType",
                newName: "TypeName");

            migrationBuilder.AddColumn<bool>(
                name: "AddClientToCaseLoad",
                table: "ClientPreference",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PatientHomeCommPreferences_fk",
                table: "ClientPreference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientOfficeCommPreferences_fk",
                table: "ClientPreference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProgramStartDate",
                table: "ClientPreference",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Program_fk",
                table: "ClientPreference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReferralDate",
                table: "ClientPreference",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ReferralReason",
                table: "ClientPreference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Referral_fk",
                table: "ClientPreference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceRequested_fk",
                table: "ClientPreference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MasterPatientCommPreferences",
                columns: table => new
                {
                    PatientCommPreferencesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    PatientCommPreferences = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPatientCommPreferences", x => x.PatientCommPreferencesID);
                    table.ForeignKey(
                        name: "FK_MasterPatientCommPreferences_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterProgram",
                columns: table => new
                {
                    ProgramID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ProgramName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterProgram", x => x.ProgramID);
                    table.ForeignKey(
                        name: "FK_MasterProgram_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterReferral",
                columns: table => new
                {
                    ReferralID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ReferralName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterReferral", x => x.ReferralID);
                    table.ForeignKey(
                        name: "FK_MasterReferral_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterService",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ServiceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterService", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_MasterService_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterPatientCommPreferences_DeletedBy_fk",
                table: "MasterPatientCommPreferences",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterProgram_DeletedBy_fk",
                table: "MasterProgram",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterReferral_DeletedBy_fk",
                table: "MasterReferral",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterService_DeletedBy_fk",
                table: "MasterService",
                column: "DeletedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterPatientCommPreferences");

            migrationBuilder.DropTable(
                name: "MasterProgram");

            migrationBuilder.DropTable(
                name: "MasterReferral");

            migrationBuilder.DropTable(
                name: "MasterService");

            migrationBuilder.DropColumn(
                name: "AddClientToCaseLoad",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "PatientHomeCommPreferences_fk",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "PatientOfficeCommPreferences_fk",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "ProgramStartDate",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "Program_fk",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "ReferralDate",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "ReferralReason",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "Referral_fk",
                table: "ClientPreference");

            migrationBuilder.DropColumn(
                name: "ServiceRequested_fk",
                table: "ClientPreference");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "MasterType",
                newName: "StatusName");
        }
    }
}
