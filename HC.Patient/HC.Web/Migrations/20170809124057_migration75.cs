using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration75 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationID",
                table: "UserRoles",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationID",
                table: "Provider",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationID",
                table: "Patients",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationID",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_OrganizationID",
                table: "UserRoles",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_OrganizationID",
                table: "Provider",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_OrganizationID",
                table: "Patients",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompanies_OrganizationID",
                table: "InsuranceCompanies",
                column: "OrganizationID");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceCompanies_Organization_OrganizationID",
                table: "InsuranceCompanies",
                column: "OrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Organization_OrganizationID",
                table: "Patients",
                column: "OrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_Organization_OrganizationID",
                table: "Provider",
                column: "OrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Organization_OrganizationID",
                table: "UserRoles",
                column: "OrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompanies_Organization_OrganizationID",
                table: "InsuranceCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Organization_OrganizationID",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_Organization_OrganizationID",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Organization_OrganizationID",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_OrganizationID",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Provider_OrganizationID",
                table: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_Patients_OrganizationID",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceCompanies_OrganizationID",
                table: "InsuranceCompanies");

            migrationBuilder.DropColumn(
                name: "OrganizationID",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "OrganizationID",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "OrganizationID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OrganizationID",
                table: "InsuranceCompanies");
        }
    }
}
