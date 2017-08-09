using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Suffix_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SecondaryRace_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PrimaryProvider_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatus_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Ethnicity_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmergencyContactRelationship_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients",
                column: "EmergencyContactRelationship_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
                table: "Patients",
                column: "Ethnicity_fk",
                principalTable: "MasterEthnicity",
                principalColumn: "EthnicityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients",
                column: "MaritalStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider_fk",
                table: "Patients",
                column: "PrimaryProvider_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients",
                column: "SecondaryRace_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients",
                column: "Suffix_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Suffix_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SecondaryRace_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrimaryProvider_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatus_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ethnicity_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmergencyContactRelationship_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy_fk",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_CreatedBy_fk",
                table: "Patients",
                column: "CreatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_EmergencyContactRelationship_fk",
                table: "Patients",
                column: "EmergencyContactRelationship_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterEthnicity_Ethnicity_fk",
                table: "Patients",
                column: "Ethnicity_fk",
                principalTable: "MasterEthnicity",
                principalColumn: "EthnicityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterStatus_MaritalStatus_fk",
                table: "Patients",
                column: "MaritalStatus_fk",
                principalTable: "MasterStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provider_PrimaryProvider_fk",
                table: "Patients",
                column: "PrimaryProvider_fk",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterRace_SecondaryRace_fk",
                table: "Patients",
                column: "SecondaryRace_fk",
                principalTable: "MasterRace",
                principalColumn: "RaceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterType_Suffix_fk",
                table: "Patients",
                column: "Suffix_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_User_UpdatedBy_fk",
                table: "Patients",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
