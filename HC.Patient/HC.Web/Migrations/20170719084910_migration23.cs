using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID_fk",
                table: "PhoneNumbers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider");

            //migrationBuilder.DropIndex(
            //    name: "IX_Provider_ProviderPhone_fk",
            //    table: "Provider");

            //migrationBuilder.DropColumn(
            //    name: "ProviderPhone_fk",
            //    table: "Provider");

            migrationBuilder.AlterColumn<int>(
                name: "PatientID_fk",
                table: "PhoneNumbers",
                nullable: true,
                oldClrType: typeof(int));

            //migrationBuilder.AddColumn<int>(
            //    name: "ProviderID_fk",
            //    table: "PhoneNumbers",
            //    nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HL7",
                table: "MasterAdministrationSite",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_PhoneNumbers_ProviderID_fk",
            //    table: "PhoneNumbers",
            //    column: "ProviderID_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID_fk",
                table: "PhoneNumbers",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PhoneNumbers_Provider_ProviderID_fk",
            //    table: "PhoneNumbers",
            //    column: "ProviderID_fk",
            //    principalTable: "Provider",
            //    principalColumn: "ProviderId",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID_fk",
                table: "PhoneNumbers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Provider_ProviderID_fk",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropIndex(
            //    name: "IX_PhoneNumbers_ProviderID_fk",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropColumn(
            //    name: "ProviderID_fk",
            //    table: "PhoneNumbers");

            //migrationBuilder.AddColumn<int>(
            //    name: "ProviderPhone_fk",
            //    table: "Provider",
            //    nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientID_fk",
                table: "PhoneNumbers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HL7",
                table: "MasterAdministrationSite",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Provider_ProviderPhone_fk",
            //    table: "Provider",
            //    column: "ProviderPhone_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Patients_PatientID_fk",
                table: "PhoneNumbers",
                column: "PatientID_fk",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider",
            //    column: "ProviderPhone_fk",
            //    principalTable: "PhoneNumbers",
            //    principalColumn: "PhoneNumberId",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
