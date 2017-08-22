using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration84 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrganizationConnectionstring_OrganizationID",
                table: "OrganizationConnectionstring");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    DeletedBy = table.Column<int>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    OrganizationID = table.Column<int>(nullable: false, defaultValue: 1),
                    ProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_StaffId",
                table: "PhoneNumbers",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationConnectionstring_OrganizationID",
                table: "OrganizationConnectionstring",
                column: "OrganizationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CreatedBy",
                table: "Staff",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DeletedBy",
                table: "Staff",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrganizationID",
                table: "Staff",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ProviderId",
                table: "Staff",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Staff_StaffId",
                table: "PhoneNumbers",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Staff_StaffId",
                table: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_StaffId",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationConnectionstring_OrganizationID",
                table: "OrganizationConnectionstring");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "PhoneNumbers");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationConnectionstring_OrganizationID",
                table: "OrganizationConnectionstring",
                column: "OrganizationID");
        }
    }
}
