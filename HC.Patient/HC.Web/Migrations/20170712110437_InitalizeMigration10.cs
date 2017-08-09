using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class InitalizeMigration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientVitals",
                columns: table => new
                {
                    PhoneVitalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BMI = table.Column<float>(nullable: false),
                    BMI_Status = table.Column<float>(nullable: false),
                    BP_diastolic = table.Column<int>(nullable: false),
                    BP_systolic = table.Column<int>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    EncounterID_fk = table.Column<int>(nullable: false),
                    HeartRate = table.Column<string>(nullable: true),
                    Height_ft = table.Column<int>(nullable: false),
                    Height_in = table.Column<float>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    PatientID_fk = table.Column<int>(nullable: false),
                    Pulse = table.Column<int>(nullable: false),
                    Respiration = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Weight_kg = table.Column<int>(nullable: false),
                    Weight_lbs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientVitals", x => x.PhoneVitalId);
                    table.ForeignKey(
                        name: "FK_PatientVitals_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientVitals_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientVitals_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientVitals_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientVitals_CreatedBy_fk",
                table: "PatientVitals",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientVitals_DeletedBy_fk",
                table: "PatientVitals",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientVitals_PatientID_fk",
                table: "PatientVitals",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientVitals_UpdatedBy_fk",
                table: "PatientVitals",
                column: "UpdatedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientVitals");
        }
    }
}
