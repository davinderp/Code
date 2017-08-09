using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration39 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_HomeCountry",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_HomeState",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState",
                table: "PatientAddress");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_User_User_CreatedBy_fk",
            //    table: "User");

            migrationBuilder.DropColumn(
                name: "HomeAddress1",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "HomeAddress2",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "HomeCity",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "HomePhone",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "HomeZip",
                table: "PatientAddress");

            //migrationBuilder.RenameColumn(
            //    name: "CreatedBy_fk",
            //    table: "User",
            //    newName: "CreatedBy");

            //migrationBuilder.RenameIndex(
            //    name: "IX_User_CreatedBy_fk",
            //    table: "User",
            //    newName: "IX_User_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MailingZip",
                table: "PatientAddress",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "MailingState",
                table: "PatientAddress",
                newName: "MasterState1Id");

            migrationBuilder.RenameColumn(
                name: "MailingPhone",
                table: "PatientAddress",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "MailingCity",
                table: "PatientAddress",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "MailingAddress2",
                table: "PatientAddress",
                newName: "Address2");

            migrationBuilder.RenameColumn(
                name: "MailingAddress1",
                table: "PatientAddress",
                newName: "Address1");

            migrationBuilder.RenameColumn(
                name: "MailCountry",
                table: "PatientAddress",
                newName: "MasterCountry1Id");

            migrationBuilder.RenameColumn(
                name: "HomeState",
                table: "PatientAddress",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "HomeCountry",
                table: "PatientAddress",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MailingState",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MasterState1Id");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MailCountry",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MasterCountry1Id");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_HomeState",
                table: "PatientAddress",
                newName: "IX_PatientAddress_State");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_HomeCountry",
                table: "PatientAddress",
                newName: "IX_PatientAddress_Country");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "CreatedDate",
            //    table: "User",
            //    nullable: false,
            //    defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
            //    oldClrType: typeof(DateTime),
            //    oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 370, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 780, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "AddressTypeID",
                table: "PatientAddress",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "MasterAddressType",
                columns: table => new
                {
                    AddressTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressTypeName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAddressType", x => x.AddressTypeID);
                    table.ForeignKey(
                        name: "FK_MasterAddressType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterAddressType_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_AddressTypeID",
                table: "PatientAddress",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterAddressType_CreatedBy",
                table: "MasterAddressType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MasterAddressType_DeletedBy",
                table: "MasterAddressType",
                column: "DeletedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterAddressType_AddressTypeID",
                table: "PatientAddress",
                column: "AddressTypeID",
                principalTable: "MasterAddressType",
                principalColumn: "AddressTypeID",
                
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_Country",
                table: "PatientAddress",
                column: "Country",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_MasterCountry1Id",
                table: "PatientAddress",
                column: "MasterCountry1Id",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_MasterState1Id",
                table: "PatientAddress",
                column: "MasterState1Id",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_State",
                table: "PatientAddress",
                column: "State",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_User_User_CreatedBy",
            //    table: "User",
            //    column: "CreatedBy",
            //    principalTable: "User",
            //    principalColumn: "UserID",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterAddressType_AddressTypeID",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_Country",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterCountry_MasterCountry1Id",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_MasterState1Id",
                table: "PatientAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAddress_MasterState_State",
                table: "PatientAddress");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_User_User_CreatedBy",
            //    table: "User");

            migrationBuilder.DropTable(
                name: "MasterAddressType");

            migrationBuilder.DropIndex(
                name: "IX_PatientAddress_AddressTypeID",
                table: "PatientAddress");

            migrationBuilder.DropColumn(
                name: "AddressTypeID",
                table: "PatientAddress");

            //migrationBuilder.RenameColumn(
            //    name: "CreatedBy",
            //    table: "User",
            //    newName: "CreatedBy_fk");

            //migrationBuilder.RenameIndex(
            //    name: "IX_User_CreatedBy",
            //    table: "User",
            //    newName: "IX_User_CreatedBy_fk");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "PatientAddress",
                newName: "MailingZip");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "PatientAddress",
                newName: "HomeState");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "PatientAddress",
                newName: "MailingPhone");

            migrationBuilder.RenameColumn(
                name: "MasterState1Id",
                table: "PatientAddress",
                newName: "MailingState");

            migrationBuilder.RenameColumn(
                name: "MasterCountry1Id",
                table: "PatientAddress",
                newName: "MailCountry");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "PatientAddress",
                newName: "HomeCountry");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "PatientAddress",
                newName: "MailingCity");

            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "PatientAddress",
                newName: "MailingAddress2");

            migrationBuilder.RenameColumn(
                name: "Address1",
                table: "PatientAddress",
                newName: "MailingAddress1");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_State",
                table: "PatientAddress",
                newName: "IX_PatientAddress_HomeState");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MasterState1Id",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MailingState");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_MasterCountry1Id",
                table: "PatientAddress",
                newName: "IX_PatientAddress_MailCountry");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAddress_Country",
                table: "PatientAddress",
                newName: "IX_PatientAddress_HomeCountry");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "CreatedDate",
            //    table: "User",
            //    nullable: false,
            //    defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
            //    oldClrType: typeof(DateTime),
            //    oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Provider",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Provider",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientVitals",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientSocialHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Patients",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 780, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 370, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientPreference",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientMedicalFamilyHistory",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientGuardian",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientEmploymentDetail",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientDiagnosis",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAddress",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 784, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress1",
                table: "PatientAddress",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress2",
                table: "PatientAddress",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeCity",
                table: "PatientAddress",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePhone",
                table: "PatientAddress",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeZip",
                table: "PatientAddress",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterVFCEligibility",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterType",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterState",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterService",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRouteOfAdministration",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRelationship",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 791, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 380, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRejectionReason",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterReferral",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterRace",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterProgram",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPreferredLanguage",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterPatientCommPreferences",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterOccupation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 783, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 373, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterManufacture",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterLocation",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 788, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 377, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunization",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 378, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterImmunityStatus",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 790, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterICD",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterGender",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 786, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 375, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterFundingSource",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 782, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterEthnicity",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCPT",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 787, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 376, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterCountry",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 781, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 372, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MasterAdministrationSite",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 789, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 379, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "InsuranceCompanies",
                nullable: false,
                defaultValue: new DateTime(2017, 7, 24, 15, 43, 14, 785, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 7, 25, 13, 51, 35, 374, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_HomeCountry",
                table: "PatientAddress",
                column: "HomeCountry",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_HomeState",
                table: "PatientAddress",
                column: "HomeState",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterCountry_MailCountry",
                table: "PatientAddress",
                column: "MailCountry",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAddress_MasterState_MailingState",
                table: "PatientAddress",
                column: "MailingState",
                principalTable: "MasterState",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_User_User_CreatedBy_fk",
            //    table: "User",
            //    column: "CreatedBy_fk",
            //    principalTable: "User",
            //    principalColumn: "UserID",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
