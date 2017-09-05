using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterAllergies",
                columns: table => new
                {
                    AllergyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllergyType = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAllergies", x => x.AllergyID);
                    table.ForeignKey(
                        name: "FK_MasterAllergies_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterAllergies_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientAllergies",
                columns: table => new
                {
                    PatientAllergyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Allergen = table.Column<string>(maxLength: 100, nullable: true),
                    AllergyType = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    IsVerified = table.Column<bool>(nullable: true),
                    PatientID = table.Column<int>(nullable: false),
                    Reaction = table.Column<string>(maxLength: 100, nullable: true),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAllergies", x => x.PatientAllergyId);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_MasterAllergies_AllergyType",
                        column: x => x.AllergyType,
                        principalTable: "MasterAllergies",
                        principalColumn: "AllergyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientAllergies_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterAllergies_CreatedBy",
                table: "MasterAllergies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MasterAllergies_DeletedBy",
                table: "MasterAllergies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_AllergyType",
                table: "PatientAllergies",
                column: "AllergyType");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_CreatedBy",
                table: "PatientAllergies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_PatientID",
                table: "PatientAllergies",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAllergies_UpdatedBy",
                table: "PatientAllergies",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientAllergies");

            migrationBuilder.DropTable(
                name: "MasterAllergies");
        }
    }
}
