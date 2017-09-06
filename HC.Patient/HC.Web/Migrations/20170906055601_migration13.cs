using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientCustomLabels",
                columns: table => new
                {
                    PatientCustomLabelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    CustomLabelDataType = table.Column<string>(nullable: false),
                    CustomLabelID = table.Column<int>(nullable: false),
                    CustomLabelValue = table.Column<string>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCustomLabels", x => x.PatientCustomLabelID);
                    table.ForeignKey(
                        name: "FK_PatientCustomLabels_MasterCustomLabels_CustomLabelID",
                        column: x => x.CustomLabelID,
                        principalTable: "MasterCustomLabels",
                        principalColumn: "CustomLabelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientCustomLabels_CustomLabelID",
                table: "PatientCustomLabels",
                column: "CustomLabelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientCustomLabels");
        }
    }
}
