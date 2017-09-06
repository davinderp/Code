using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientID",
                table: "Patients",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ICDID",
                table: "Patients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RenderingClinicianID",
                table: "Patients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MasterTags",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    Tag = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterTags", x => x.TagID);
                    table.ForeignKey(
                        name: "FK_MasterTags_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterTags_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientTags",
                columns: table => new
                {
                    PatientTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    OrganizationID = table.Column<int>(nullable: false, defaultValue: 1),
                    PatientID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTags", x => x.PatientTagID);
                    table.ForeignKey(
                        name: "FK_PatientTags_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientTags_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientTags_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientTags_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientTags_MasterTags_TagID",
                        column: x => x.TagID,
                        principalTable: "MasterTags",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ICDID",
                table: "Patients",
                column: "ICDID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RenderingClinicianID",
                table: "Patients",
                column: "RenderingClinicianID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterTags_CreatedBy",
                table: "MasterTags",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MasterTags_DeletedBy",
                table: "MasterTags",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTags_CreatedBy",
                table: "PatientTags",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTags_DeletedBy",
                table: "PatientTags",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTags_OrganizationID",
                table: "PatientTags",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTags_PatientID",
                table: "PatientTags",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTags_TagID",
                table: "PatientTags",
                column: "TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterICD_ICDID",
                table: "Patients",
                column: "ICDID",
                principalTable: "MasterICD",
                principalColumn: "ICDID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Clinicians_RenderingClinicianID",
                table: "Patients",
                column: "RenderingClinicianID",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterICD_ICDID",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Clinicians_RenderingClinicianID",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "PatientTags");

            migrationBuilder.DropTable(
                name: "MasterTags");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ICDID",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_RenderingClinicianID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ICDID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "RenderingClinicianID",
                table: "Patients");
        }
    }
}
