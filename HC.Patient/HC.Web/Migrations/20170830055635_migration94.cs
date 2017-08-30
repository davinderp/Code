using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration94 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarrierPayerID",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "TPLCode",
                table: "PatientInsuranceDetails");

            migrationBuilder.AddColumn<string>(
                name: "CarrierPayerID",
                table: "InsuranceCompanies",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TPLCode",
                table: "InsuranceCompanies",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarrierPayerID",
                table: "InsuranceCompanies");

            migrationBuilder.DropColumn(
                name: "TPLCode",
                table: "InsuranceCompanies");

            migrationBuilder.AddColumn<string>(
                name: "CarrierPayerID",
                table: "PatientInsuranceDetails",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TPLCode",
                table: "PatientInsuranceDetails",
                maxLength: 20,
                nullable: true);
        }
    }
}
