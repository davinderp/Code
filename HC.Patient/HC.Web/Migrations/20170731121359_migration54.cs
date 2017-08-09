using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Provider_ProviderID",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Provider_User_DeletedBy",
            //    table: "Provider");

            migrationBuilder.RenameColumn(
                name: "ProviderID",
                table: "PhoneNumbers",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ProviderID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ProviderId");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderName",
                table: "Provider",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderEmail",
                table: "Provider",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderAddress",
                table: "Provider",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "DeletedBy",
            //    table: "Provider",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SSN",
                table: "Patients",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MRN",
                table: "Patients",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Provider_ProviderId",
                table: "PhoneNumbers",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Provider_User_DeletedBy",
            //    table: "Provider",
            //    column: "DeletedBy",
            //    principalTable: "User",
            //    principalColumn: "UserID",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Provider_ProviderId",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Provider_User_DeletedBy",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "PhoneNumbers");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "PhoneNumbers",
                newName: "ProviderID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ProviderId",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ProviderID");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderName",
                table: "Provider",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderEmail",
                table: "Provider",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderAddress",
                table: "Provider",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SSN",
                table: "Patients",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "MRN",
                table: "Patients",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Provider_ProviderID",
                table: "PhoneNumbers",
                column: "ProviderID",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_User_DeletedBy",
                table: "Provider",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
