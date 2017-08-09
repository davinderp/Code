using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientVitals",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientVitals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientInsuranceDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientGuardian",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientEmploymentDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "PatientAddress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_User_CreatedBy_fk",
                table: "PatientAddress",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientGuardian_User_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientPreference_User_CreatedBy_fk",
                table: "PatientPreference",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientVitals_User_CreatedBy_fk",
                table: "PatientVitals",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
