using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration88 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encounter_CPT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPTID = table.Column<int>(nullable: false),
                    EncounterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encounter_CPT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Encounter_CPT_MasterCPT_CPTID",
                        column: x => x.CPTID,
                        principalTable: "MasterCPT",
                        principalColumn: "CPTID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Encounter_CPT_PatientEncounter_EncounterId",
                        column: x => x.EncounterId,
                        principalTable: "PatientEncounter",
                        principalColumn: "PatientEncounterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Encounter_CPT_CPTID",
                table: "Encounter_CPT",
                column: "CPTID");

            migrationBuilder.CreateIndex(
                name: "IX_Encounter_CPT_EncounterId",
                table: "Encounter_CPT",
                column: "EncounterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encounter_CPT");
        }
    }
}
