using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration89 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    CountryID = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    LocationDescription = table.Column<string>(maxLength: 1000, nullable: false),
                    LocationName = table.Column<string>(maxLength: 100, nullable: false),
                    OrganizationID = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    StateID = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Zip = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Location_MasterCountry_CountryID",
                        column: x => x.CountryID,
                        principalTable: "MasterCountry",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_MasterState_StateID",
                        column: x => x.StateID,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_CountryID",
                table: "Location",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_OrganizationID",
                table: "Location",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_StateID",
                table: "Location",
                column: "StateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
