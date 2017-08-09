using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Weight_lbs",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Weight_kg",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Height_in",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "Height_ft",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "BMI_Status",
                table: "PatientVitals",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "BMI",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<double>(
                name: "Height_cm",
                table: "PatientVitals",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height_cm",
                table: "PatientVitals");

            migrationBuilder.AlterColumn<int>(
                name: "Weight_lbs",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Weight_kg",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Height_in",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Height_ft",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "BMI_Status",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BMI",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
