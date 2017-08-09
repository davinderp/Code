using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "PatientPreference");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PatientMedicalFamilyHistory",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "VaccineLotNumber",
                table: "PatientImmunization",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientGuardian",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientEmploymentDetail",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PatientDocuments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientGuardian");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PatientDocuments");

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "PatientPreference",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PatientMedicalFamilyHistory",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VaccineLotNumber",
                table: "PatientImmunization",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
