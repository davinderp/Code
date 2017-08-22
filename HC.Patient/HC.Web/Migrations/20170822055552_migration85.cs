using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration85 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientAppointment_Clinicians_ClinicianID",
            //    table: "PatientAppointment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientEncounter_Clinicians_ClinicianID",
            //    table: "PatientEncounter");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientImmunization_Clinicians_AdministeredBy",
            //    table: "PatientImmunization");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientImmunization_Clinicians_OrderBy",
            //    table: "PatientImmunization");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Patients_Clinicians_PrimaryClinician",
            //    table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Clinicians_ClinicianID",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Staff_StaffId",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropTable(
            //    name: "Clinicians");

            //migrationBuilder.DropIndex(
            //    name: "IX_PhoneNumbers_ClinicianID",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropColumn(
            //    name: "ClinicianID",
            //    table: "PhoneNumbers");

            //migrationBuilder.RenameColumn(
            //    name: "StaffId",
            //    table: "PhoneNumbers",
            //    newName: "StaffID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PhoneNumbers_StaffId",
            //    table: "PhoneNumbers",
            //    newName: "IX_PhoneNumbers_StaffID");

            //migrationBuilder.RenameColumn(
            //    name: "ClinicianID",
            //    table: "PatientEncounter",
            //    newName: "StaffID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PatientEncounter_ClinicianID",
            //    table: "PatientEncounter",
            //    newName: "IX_PatientEncounter_StaffID");

            //migrationBuilder.RenameColumn(
            //    name: "ClinicianID",
            //    table: "PatientAppointment",
            //    newName: "StaffID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PatientAppointment_ClinicianID",
            //    table: "PatientAppointment",
            //    newName: "IX_PatientAppointment_StaffID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientAppointment_Staff_StaffID",
            //    table: "PatientAppointment",
            //    column: "StaffID",
            //    principalTable: "Staff",
            //    principalColumn: "StaffID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientEncounter_Staff_StaffID",
            //    table: "PatientEncounter",
            //    column: "StaffID",
            //    principalTable: "Staff",
            //    principalColumn: "StaffID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientImmunization_Staff_AdministeredBy",
            //    table: "PatientImmunization",
            //    column: "AdministeredBy",
            //    principalTable: "Staff",
            //    principalColumn: "StaffID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientImmunization_Staff_OrderBy",
            //    table: "PatientImmunization",
            //    column: "OrderBy",
            //    principalTable: "Staff",
            //    principalColumn: "StaffID",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Staff_PrimaryClinician",
                table: "Patients",
                column: "PrimaryClinician",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Staff_StaffID",
                table: "PhoneNumbers",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointment_Staff_StaffID",
                table: "PatientAppointment");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Staff_StaffID",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Staff_AdministeredBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Staff_OrderBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Staff_PrimaryClinician",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Staff_StaffID",
                table: "PhoneNumbers");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "PhoneNumbers",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_StaffID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_StaffId");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "PatientEncounter",
                newName: "ClinicianID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_StaffID",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_ClinicianID");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "PatientAppointment",
                newName: "ClinicianID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAppointment_StaffID",
                table: "PatientAppointment",
                newName: "IX_PatientAppointment_ClinicianID");

            migrationBuilder.AddColumn<int>(
                name: "ClinicianID",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clinicians",
                columns: table => new
                {
                    ClinicianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    DeletedBy = table.Column<int>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    OrganizationID = table.Column<int>(nullable: false),
                    ProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinicians", x => x.ClinicianID);
                    table.ForeignKey(
                        name: "FK_Clinicians_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clinicians_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clinicians_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clinicians_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_ClinicianID",
                table: "PhoneNumbers",
                column: "ClinicianID");

            migrationBuilder.CreateIndex(
                name: "IX_Clinicians_CreatedBy",
                table: "Clinicians",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Clinicians_DeletedBy",
                table: "Clinicians",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Clinicians_OrganizationID",
                table: "Clinicians",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Clinicians_ProviderId",
                table: "Clinicians",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointment_Clinicians_ClinicianID",
                table: "PatientAppointment",
                column: "ClinicianID",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Clinicians_ClinicianID",
                table: "PatientEncounter",
                column: "ClinicianID",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Clinicians_AdministeredBy",
                table: "PatientImmunization",
                column: "AdministeredBy",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Clinicians_OrderBy",
                table: "PatientImmunization",
                column: "OrderBy",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Clinicians_PrimaryClinician",
                table: "Patients",
                column: "PrimaryClinician",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Clinicians_ClinicianID",
                table: "PhoneNumbers",
                column: "ClinicianID",
                principalTable: "Clinicians",
                principalColumn: "ClinicianID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Staff_StaffId",
                table: "PhoneNumbers",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
