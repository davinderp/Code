using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "value",
                table: "MasterCPT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MasterRelationship",
                columns: table => new
                {
                    RelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    RelationshipName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterRelationship", x => x.RelationshipID);
                    table.ForeignKey(
                        name: "FK_MasterRelationship_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicalFamilyHistory",
                columns: table => new
                {
                    MedicalFamilyHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeOfDiagnosis = table.Column<int>(nullable: true),
                    CauseOfDeath = table.Column<string>(nullable: true),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    DateOfDeath = table.Column<DateTime>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    Disease_fk = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    Gender_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    PatientID_fk = table.Column<int>(nullable: false),
                    RelationShip_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicalFamilyHistory", x => x.MedicalFamilyHistoryId);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_MasterICD_Disease_fk",
                        column: x => x.Disease_fk,
                        principalTable: "MasterICD",
                        principalColumn: "ICDID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_MasterGender_Gender_fk",
                        column: x => x.Gender_fk,
                        principalTable: "MasterGender",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_MasterRelationship_RelationShip_fk",
                        column: x => x.RelationShip_fk,
                        principalTable: "MasterRelationship",
                        principalColumn: "RelationshipID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicalFamilyHistory_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterRelationship_DeletedBy_fk",
                table: "MasterRelationship",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_CreatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_DeletedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_Disease_fk",
                table: "PatientMedicalFamilyHistory",
                column: "Disease_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_Gender_fk",
                table: "PatientMedicalFamilyHistory",
                column: "Gender_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_PatientID_fk",
                table: "PatientMedicalFamilyHistory",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_RelationShip_fk",
                table: "PatientMedicalFamilyHistory",
                column: "RelationShip_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalFamilyHistory_UpdatedBy_fk",
                table: "PatientMedicalFamilyHistory",
                column: "UpdatedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientMedicalFamilyHistory");

            migrationBuilder.DropTable(
                name: "MasterRelationship");

            migrationBuilder.DropColumn(
                name: "value",
                table: "MasterCPT");
        }
    }
}
