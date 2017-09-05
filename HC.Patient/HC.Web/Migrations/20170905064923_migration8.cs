using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorizationProcedures",
                columns: table => new
                {
                    AuthorizationProcedureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorizationId = table.Column<int>(nullable: false),
                    CPTCodeID = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    IsVerified = table.Column<bool>(nullable: true),
                    TypeID = table.Column<int>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationProcedures", x => x.AuthorizationProcedureId);
                    table.ForeignKey(
                        name: "FK_AuthorizationProcedures_MasterCPT_CPTCodeID",
                        column: x => x.CPTCodeID,
                        principalTable: "MasterCPT",
                        principalColumn: "CPTID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizationProcedures_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorizationProcedures_MasterType_TypeID",
                        column: x => x.TypeID,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorizationProcedures_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authorization",
                columns: table => new
                {
                    AuthorizationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorizationNumber = table.Column<int>(nullable: false),
                    AuthorizationProcedureID = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    EndDate = table.Column<DateTime>(nullable: false),
                    InsuranceCompanyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    IsVerified = table.Column<bool>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PatientID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorization", x => x.AuthorizationId);
                    table.ForeignKey(
                        name: "FK_Authorization_AuthorizationProcedures_AuthorizationProcedureID",
                        column: x => x.AuthorizationProcedureID,
                        principalTable: "AuthorizationProcedures",
                        principalColumn: "AuthorizationProcedureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Authorization_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorization_InsuranceCompanies_InsuranceCompanyID",
                        column: x => x.InsuranceCompanyID,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "InsuranceCompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorization_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authorization_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_AuthorizationProcedureID",
                table: "Authorization",
                column: "AuthorizationProcedureID");

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_CreatedBy",
                table: "Authorization",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_InsuranceCompanyID",
                table: "Authorization",
                column: "InsuranceCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_PatientID",
                table: "Authorization",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_UpdatedBy",
                table: "Authorization",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_AuthorizationId",
                table: "AuthorizationProcedures",
                column: "AuthorizationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_CPTCodeID",
                table: "AuthorizationProcedures",
                column: "CPTCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_CreatedBy",
                table: "AuthorizationProcedures",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_TypeID",
                table: "AuthorizationProcedures",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationProcedures_UpdatedBy",
                table: "AuthorizationProcedures",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationProcedures_Authorization_AuthorizationId",
                table: "AuthorizationProcedures",
                column: "AuthorizationId",
                principalTable: "Authorization",
                principalColumn: "AuthorizationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authorization_AuthorizationProcedures_AuthorizationProcedureID",
                table: "Authorization");

            migrationBuilder.DropTable(
                name: "AuthorizationProcedures");

            migrationBuilder.DropTable(
                name: "Authorization");
        }
    }
}
