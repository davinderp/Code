using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterCPT",
                columns: table => new
                {
                    CPTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPTCode = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCPT", x => x.CPTID);
                    table.ForeignKey(
                        name: "FK_MasterCPT_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterICD",
                columns: table => new
                {
                    ICDID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CodeType = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterICD", x => x.ICDID);
                    table.ForeignKey(
                        name: "FK_MasterICD_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterLocation",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLocation", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_MasterLocation_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnosis",
                columns: table => new
                {
                    PatientDiagnosisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ICDID_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnosis", x => x.PatientDiagnosisId);
                    table.ForeignKey(
                        name: "FK_PatientDiagnosis_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnosis_MasterICD_ICDID_fk",
                        column: x => x.ICDID_fk,
                        principalTable: "MasterICD",
                        principalColumn: "ICDID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnosis_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientDiagnosis_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientEncounter",
                columns: table => new
                {
                    PatientEncounterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assessment = table.Column<string>(nullable: true),
                    CPTID_fk = table.Column<int>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LocationID_fk = table.Column<int>(nullable: false),
                    Objective = table.Column<string>(nullable: true),
                    PatientID_fk = table.Column<int>(nullable: false),
                    Plans = table.Column<string>(nullable: true),
                    ProviderId_fk = table.Column<int>(nullable: false),
                    Subjective = table.Column<string>(nullable: true),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    VisitDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientEncounter", x => x.PatientEncounterId);
                    table.ForeignKey(
                        name: "FK_PatientEncounter_MasterCPT_CPTID_fk",
                        column: x => x.CPTID_fk,
                        principalTable: "MasterCPT",
                        principalColumn: "CPTID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEncounter_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEncounter_MasterLocation_LocationID_fk",
                        column: x => x.LocationID_fk,
                        principalTable: "MasterLocation",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEncounter_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientEncounter_Provider_ProviderId_fk",
                        column: x => x.ProviderId_fk,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEncounter_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterCPT_DeletedBy_fk",
                table: "MasterCPT",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterICD_DeletedBy_fk",
                table: "MasterICD",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLocation_DeletedBy_fk",
                table: "MasterLocation",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnosis_CreatedBy_fk",
                table: "PatientDiagnosis",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnosis_ICDID_fk",
                table: "PatientDiagnosis",
                column: "ICDID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnosis_PatientID_fk",
                table: "PatientDiagnosis",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnosis_UpdatedBy_fk",
                table: "PatientDiagnosis",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_CPTID_fk",
                table: "PatientEncounter",
                column: "CPTID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_CreatedBy_fk",
                table: "PatientEncounter",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_LocationID_fk",
                table: "PatientEncounter",
                column: "LocationID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_PatientID_fk",
                table: "PatientEncounter",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_ProviderId_fk",
                table: "PatientEncounter",
                column: "ProviderId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_UpdatedBy_fk",
                table: "PatientEncounter",
                column: "UpdatedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientDiagnosis");

            migrationBuilder.DropTable(
                name: "PatientEncounter");

            migrationBuilder.DropTable(
                name: "MasterICD");

            migrationBuilder.DropTable(
                name: "MasterCPT");

            migrationBuilder.DropTable(
                name: "MasterLocation");
        }
    }
}
