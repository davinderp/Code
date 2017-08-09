using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientSocialHistory",
                columns: table => new
                {
                    SocialHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlcohalID_fk = table.Column<int>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DrugID_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Occupation = table.Column<int>(maxLength: 300, nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    TobaccoID_fk = table.Column<int>(nullable: false),
                    TravelID_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientSocialHistory", x => x.SocialHistoryId);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_MasterType_AlcohalID_fk",
                        column: x => x.AlcohalID_fk,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_MasterType_DrugID_fk",
                        column: x => x.DrugID_fk,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_MasterType_TobaccoID_fk",
                        column: x => x.TobaccoID_fk,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_MasterType_TravelID_fk",
                        column: x => x.TravelID_fk,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientSocialHistory_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_AlcohalID_fk",
                table: "PatientSocialHistory",
                column: "AlcohalID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_CreatedBy_fk",
                table: "PatientSocialHistory",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_DrugID_fk",
                table: "PatientSocialHistory",
                column: "DrugID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_PatientID_fk",
                table: "PatientSocialHistory",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_TobaccoID_fk",
                table: "PatientSocialHistory",
                column: "TobaccoID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_TravelID_fk",
                table: "PatientSocialHistory",
                column: "TravelID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientSocialHistory_UpdatedBy_fk",
                table: "PatientSocialHistory",
                column: "UpdatedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientSocialHistory");
        }
    }
}
