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
            migrationBuilder.CreateTable(
                name: "MasterCustomLabels",
                columns: table => new
                {
                    CustomLabelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomLabelName = table.Column<string>(maxLength: 100, nullable: false),
                    CustomLabelTypeID = table.Column<int>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    OrganizationID = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCustomLabels", x => x.CustomLabelID);
                    table.ForeignKey(
                        name: "FK_MasterCustomLabels_MasterType_CustomLabelTypeID",
                        column: x => x.CustomLabelTypeID,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterCustomLabels_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterCustomLabels_CustomLabelTypeID",
                table: "MasterCustomLabels",
                column: "CustomLabelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterCustomLabels_OrganizationID",
                table: "MasterCustomLabels",
                column: "OrganizationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterCustomLabels");
        }
    }
}
