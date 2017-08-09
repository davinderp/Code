using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterDocumentType_DocumentType_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterInsurancePCP_InsurancePCP_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterInsuranceType_Type_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropTable(
                name: "MasterDocumentType");

            migrationBuilder.DropTable(
                name: "MasterInsurancePCP");

            migrationBuilder.DropTable(
                name: "MasterInsuranceType");

            migrationBuilder.DropIndex(
                name: "IX_PatientInsuranceDetails_Type_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "IsEmployeePlan",
                table: "PatientInsuranceDetails");

            migrationBuilder.RenameColumn(
                name: "Type_fk",
                table: "PatientInsuranceDetails",
                newName: "VisitsAllowedPerYear");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PatientInsuranceDetails",
                newName: "InsurancePersonSameAsPatient");

            migrationBuilder.RenameColumn(
                name: "InsurancePCP_fk",
                table: "PatientInsuranceDetails",
                newName: "InsurancePlanType_fk");

            migrationBuilder.RenameColumn(
                name: "InsuranceID",
                table: "PatientInsuranceDetails",
                newName: "TPLCode");

            migrationBuilder.RenameColumn(
                name: "InsuranceCompany",
                table: "PatientInsuranceDetails",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "GroupNumber",
                table: "PatientInsuranceDetails",
                newName: "InsurancePlanName");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsurancePCP_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsurancePlanType_fk");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "MasterType",
                newName: "StatusName");

            migrationBuilder.RenameColumn(
                name: "StatusType",
                table: "MasterStatus",
                newName: "Type");

            migrationBuilder.AddColumn<DateTime>(
                name: "CardIssueDate",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CarrierPayerID",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceClaimOfficeNumber",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceCompanyAddress",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCompany_fk",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceGroupName",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceIDNumber",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsurancePhotoPathBack",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsurancePhotoPathFront",
                table: "PatientInsuranceDetails",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientDocuments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Expiration",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PatientDocuments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UploadPath",
                table: "PatientDocuments",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StateName",
                table: "MasterState",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateAbbr",
                table: "MasterState",
                maxLength: 2,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    InsuranceCompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyAddress = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyPhone = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.InsuranceCompanyId);
                    table.ForeignKey(
                        name: "FK_InsuranceCompanies_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    PatientID_fk = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberTypeId_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provider_ProviderPhone_fk",
                table: "Provider",
                column: "ProviderPhone_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Citizenship_fk",
                table: "Patients",
                column: "Citizenship_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_InsuranceCompany_fk",
                table: "PatientInsuranceDetails",
                column: "InsuranceCompany_fk");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompanies_DeletedBy_fk",
                table: "InsuranceCompanies",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_DeletedBy_fk",
                table: "PhoneNumbers",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_PatientID_fk",
                table: "PhoneNumbers",
                column: "PatientID_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments",
                column: "DocumentType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_InsuranceCompanies_InsuranceCompany_fk",
                table: "PatientInsuranceDetails",
                column: "InsuranceCompany_fk",
                principalTable: "InsuranceCompanies",
                principalColumn: "InsuranceCompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                column: "InsurancePlanType_fk",
                principalTable: "MasterType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MasterCountry_Citizenship_fk",
                table: "Patients",
                column: "Citizenship_fk",
                principalTable: "MasterCountry",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider",
            //    column: "ProviderPhone_fk",
            //    principalTable: "PhoneNumbers",
            //    principalColumn: "PhoneNumberId",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_MasterType_DocumentType_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_InsuranceCompanies_InsuranceCompany_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientInsuranceDetails_MasterType_InsurancePlanType_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MasterCountry_Citizenship_fk",
                table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Provider_PhoneNumbers_ProviderPhone_fk",
            //    table: "Provider");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Provider_ProviderPhone_fk",
                table: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Citizenship_fk",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_PatientInsuranceDetails_InsuranceCompany_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "CardIssueDate",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "CarrierPayerID",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceClaimOfficeNumber",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceCompanyAddress",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceCompany_fk",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceGroupName",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceIDNumber",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsurancePhotoPathBack",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "InsurancePhotoPathFront",
                table: "PatientInsuranceDetails");

            migrationBuilder.DropColumn(
                name: "Expiration",
                table: "PatientDocuments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PatientDocuments");

            migrationBuilder.DropColumn(
                name: "UploadPath",
                table: "PatientDocuments");

            migrationBuilder.DropColumn(
                name: "StateAbbr",
                table: "MasterState");

            migrationBuilder.RenameColumn(
                name: "VisitsAllowedPerYear",
                table: "PatientInsuranceDetails",
                newName: "Type_fk");

            migrationBuilder.RenameColumn(
                name: "TPLCode",
                table: "PatientInsuranceDetails",
                newName: "InsuranceID");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "PatientInsuranceDetails",
                newName: "InsuranceCompany");

            migrationBuilder.RenameColumn(
                name: "InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                newName: "InsurancePCP_fk");

            migrationBuilder.RenameColumn(
                name: "InsurancePlanName",
                table: "PatientInsuranceDetails",
                newName: "GroupNumber");

            migrationBuilder.RenameColumn(
                name: "InsurancePersonSameAsPatient",
                table: "PatientInsuranceDetails",
                newName: "Status");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInsuranceDetails_InsurancePlanType_fk",
                table: "PatientInsuranceDetails",
                newName: "IX_PatientInsuranceDetails_InsurancePCP_fk");

            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "MasterType",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "MasterStatus",
                newName: "StatusType");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmployeePlan",
                table: "PatientInsuranceDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy_fk",
                table: "PatientDocuments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "StateName",
                table: "MasterState",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MasterDocumentType",
                columns: table => new
                {
                    DocumentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    DocumentType = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDocumentType", x => x.DocumentTypeID);
                    table.ForeignKey(
                        name: "FK_MasterDocumentType_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterInsurancePCP",
                columns: table => new
                {
                    InsurancePCPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    InsurancePCP = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInsurancePCP", x => x.InsurancePCPID);
                    table.ForeignKey(
                        name: "FK_MasterInsurancePCP_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterInsuranceType",
                columns: table => new
                {
                    InsuranceTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    InsuranceType = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInsuranceType", x => x.InsuranceTypeID);
                    table.ForeignKey(
                        name: "FK_MasterInsuranceType_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_Type_fk",
                table: "PatientInsuranceDetails",
                column: "Type_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterDocumentType_DeletedBy_fk",
                table: "MasterDocumentType",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterInsurancePCP_DeletedBy_fk",
                table: "MasterInsurancePCP",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterInsuranceType_DeletedBy_fk",
                table: "MasterInsuranceType",
                column: "DeletedBy_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_MasterDocumentType_DocumentType_fk",
                table: "PatientDocuments",
                column: "DocumentType_fk",
                principalTable: "MasterDocumentType",
                principalColumn: "DocumentTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDocuments_User_UpdatedBy_fk",
                table: "PatientDocuments",
                column: "UpdatedBy_fk",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterInsurancePCP_InsurancePCP_fk",
                table: "PatientInsuranceDetails",
                column: "InsurancePCP_fk",
                principalTable: "MasterInsurancePCP",
                principalColumn: "InsurancePCPID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInsuranceDetails_MasterInsuranceType_Type_fk",
                table: "PatientInsuranceDetails",
                column: "Type_fk",
                principalTable: "MasterInsuranceType",
                principalColumn: "InsuranceTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
