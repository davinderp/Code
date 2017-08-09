using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Data.Migrations
{
    public partial class InitalizeMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_DeletedBy_fk",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy_fk",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy_fk",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_DeletedBy_fk",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_DeletedBy_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_DeletedBy_fk",
                table: "MasterStatus");

            migrationBuilder.AlterColumn<string>(
                name: "StatusType",
                table: "MasterStatus",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "MasterStatus",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterStatus",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterStatus",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterState",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterState",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterRace",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterRace",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterPreferredLanguage",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterPreferredLanguage",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterFundingSource",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterFundingSource",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterEthnicity",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "EthnicityName",
                table: "MasterEthnicity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterEthnicity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterCountry",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterCountry",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_DeletedBy_fk",
                table: "MasterCountry",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy_fk",
                table: "MasterEthnicity",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy_fk",
                table: "MasterFundingSource",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                table: "MasterPreferredLanguage",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_DeletedBy_fk",
                table: "MasterRace",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_DeletedBy_fk",
                table: "MasterState",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_DeletedBy_fk",
                table: "MasterStatus",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterCountry_User_DeletedBy_fk",
                table: "MasterCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy_fk",
                table: "MasterEthnicity");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy_fk",
                table: "MasterFundingSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                table: "MasterPreferredLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterRace_User_DeletedBy_fk",
                table: "MasterRace");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterState_User_DeletedBy_fk",
                table: "MasterState");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterStatus_User_DeletedBy_fk",
                table: "MasterStatus");

            migrationBuilder.AlterColumn<int>(
                name: "StatusType",
                table: "MasterStatus",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusName",
                table: "MasterStatus",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterStatus",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterStatus",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterState",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterState",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterRace",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterRace",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterPreferredLanguage",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterPreferredLanguage",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterFundingSource",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterFundingSource",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterEthnicity",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EthnicityName",
                table: "MasterEthnicity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterEthnicity",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "MasterCountry",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy_fk",
                table: "MasterCountry",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCountry_User_DeletedBy_fk",
                table: "MasterCountry",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEthnicity_User_DeletedBy_fk",
                table: "MasterEthnicity",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterFundingSource_User_DeletedBy_fk",
                table: "MasterFundingSource",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                table: "MasterPreferredLanguage",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterRace_User_DeletedBy_fk",
                table: "MasterRace",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterState_User_DeletedBy_fk",
                table: "MasterState",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterStatus_User_DeletedBy_fk",
                table: "MasterStatus",
                column: "DeletedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
