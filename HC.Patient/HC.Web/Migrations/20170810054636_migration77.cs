using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration77 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrganizationName",
                table: "OrganizationConnectionstring",
                newName: "OrganizationDBName");

            migrationBuilder.RenameColumn(
                name: "OrganizationDescription",
                table: "OrganizationConnectionstring",
                newName: "OrganizationDBConnectionstring");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrganizationDBName",
                table: "OrganizationConnectionstring",
                newName: "OrganizationName");

            migrationBuilder.RenameColumn(
                name: "OrganizationDBConnectionstring",
                table: "OrganizationConnectionstring",
                newName: "OrganizationDescription");
        }
    }
}
