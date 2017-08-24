using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration87 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientAppointment_Staff_StaffID",
            //    table: "PatientAppointment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientEncounter_Staff_StaffID",
            //    table: "PatientEncounter");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientImmunization_Staff_AdministeredBy",
            //    table: "PatientImmunization");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PatientImmunization_Staff_OrderBy",
            //    table: "PatientImmunization");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Patients_Staff_PrimaryClinician",
            //    table: "Patients");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Staff_StaffID",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropTable(
            //    name: "Staff");

            //migrationBuilder.DropIndex(
            //    name: "IX_OrganizationConnectionstring_OrganizationID",
            //    table: "OrganizationConnectionstring");

            migrationBuilder.DropColumn(
                name: "EncounterID",
                table: "PatientVitals");

            migrationBuilder.DropColumn(
                name: "FollowUp",
                table: "PatientVitals");

            //migrationBuilder.RenameColumn(
            //    name: "StaffID",
            //    table: "PhoneNumbers",
            //    newName: "ClinicianID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PhoneNumbers_StaffID",
            //    table: "PhoneNumbers",
            //    newName: "IX_PhoneNumbers_ClinicianID");

            migrationBuilder.RenameColumn(
                name: "VisitDateTime",
                table: "PatientEncounter",
                newName: "VisitStartDate");

            //migrationBuilder.RenameColumn(
            //    name: "StaffID",
            //    table: "PatientEncounter",
            //    newName: "ClinicianID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PatientEncounter_StaffID",
            //    table: "PatientEncounter",
            //    newName: "IX_PatientEncounter_ClinicianID");

            //migrationBuilder.RenameColumn(
            //    name: "StaffID",
            //    table: "PatientAppointment",
            //    newName: "ClinicianID");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PatientAppointment",
                newName: "Notes");

            //migrationBuilder.RenameIndex(
            //    name: "IX_PatientAppointment_StaffID",
            //    table: "PatientAppointment",
            //    newName: "IX_PatientAppointment_ClinicianID");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "VisitEndDate",
                table: "PatientEncounter",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.CreateTable(
            //    name: "Clinicians",
            //    columns: table => new
            //    {
            //        ClinicianID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Address = table.Column<string>(maxLength: 500, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
            //        DeletedBy = table.Column<int>(nullable: false),
            //        DeletedDate = table.Column<DateTime>(nullable: true),
            //        Email = table.Column<string>(maxLength: 256, nullable: false),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        IsActive = table.Column<bool>(nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false),
            //        MiddleName = table.Column<string>(maxLength: 50, nullable: false),
            //        OrganizationID = table.Column<int>(nullable: false),
            //        ProviderId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Clinicians", x => x.ClinicianID);
            //        table.ForeignKey(
            //            name: "FK_Clinicians_User_CreatedBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "User",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Clinicians_User_DeletedBy",
            //            column: x => x.DeletedBy,
            //            principalTable: "User",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Clinicians_Organization_OrganizationID",
            //            column: x => x.OrganizationID,
            //            principalTable: "Organization",
            //            principalColumn: "OrganizationID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Clinicians_Provider_ProviderId",
            //            column: x => x.ProviderId,
            //            principalTable: "Provider",
            //            principalColumn: "ProviderId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_PatientEncounter_AppointmentID",
                table: "PatientEncounter",
                column: "AppointmentID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrganizationConnectionstring_OrganizationID",
            //    table: "OrganizationConnectionstring",
            //    column: "OrganizationID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clinicians_CreatedBy",
            //    table: "Clinicians",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clinicians_DeletedBy",
            //    table: "Clinicians",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clinicians_OrganizationID",
            //    table: "Clinicians",
            //    column: "OrganizationID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clinicians_ProviderId",
            //    table: "Clinicians",
            //    column: "ProviderId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientAppointment_Clinicians_ClinicianID",
            //    table: "PatientAppointment",
            //    column: "ClinicianID",
            //    principalTable: "Clinicians",
            //    principalColumn: "ClinicianID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientEncounter_PatientAppointment_AppointmentID",
            //    table: "PatientEncounter",
            //    column: "AppointmentID",
            //    principalTable: "PatientAppointment",
            //    principalColumn: "PatientAppointmentId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientEncounter_Clinicians_ClinicianID",
            //    table: "PatientEncounter",
            //    column: "ClinicianID",
            //    principalTable: "Clinicians",
            //    principalColumn: "ClinicianID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientImmunization_Clinicians_AdministeredBy",
            //    table: "PatientImmunization",
            //    column: "AdministeredBy",
            //    principalTable: "Clinicians",
            //    principalColumn: "ClinicianID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PatientImmunization_Clinicians_OrderBy",
            //    table: "PatientImmunization",
            //    column: "OrderBy",
            //    principalTable: "Clinicians",
            //    principalColumn: "ClinicianID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Patients_Clinicians_PrimaryClinician",
            //    table: "Patients",
            //    column: "PrimaryClinician",
            //    principalTable: "Clinicians",
            //    principalColumn: "ClinicianID",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PhoneNumbers_Clinicians_ClinicianID",
            //    table: "PhoneNumbers",
            //    column: "ClinicianID",
            //    principalTable: "Clinicians",
            //    principalColumn: "ClinicianID",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointment_Clinicians_ClinicianID",
                table: "PatientAppointment");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_PatientAppointment_AppointmentID",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Clinicians_ClinicianID",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Clinicians_AdministeredBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Clinicians_OrderBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Clinicians_PrimaryClinician",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Clinicians_ClinicianID",
                table: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Clinicians");

            migrationBuilder.DropIndex(
                name: "IX_PatientEncounter_AppointmentID",
                table: "PatientEncounter");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationConnectionstring_OrganizationID",
                table: "OrganizationConnectionstring");

            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "PatientEncounter");

            migrationBuilder.DropColumn(
                name: "VisitEndDate",
                table: "PatientEncounter");

            migrationBuilder.RenameColumn(
                name: "ClinicianID",
                table: "PhoneNumbers",
                newName: "StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ClinicianID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_StaffID");

            migrationBuilder.RenameColumn(
                name: "VisitStartDate",
                table: "PatientEncounter",
                newName: "VisitDateTime");

            migrationBuilder.RenameColumn(
                name: "ClinicianID",
                table: "PatientEncounter",
                newName: "StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_ClinicianID",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_StaffID");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "PatientAppointment",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ClinicianID",
                table: "PatientAppointment",
                newName: "StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAppointment_ClinicianID",
                table: "PatientAppointment",
                newName: "IX_PatientAppointment_StaffID");

            migrationBuilder.AddColumn<int>(
                name: "EncounterID",
                table: "PatientVitals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "FollowUp",
                table: "PatientVitals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
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
                    OrganizationID = table.Column<int>(nullable: false, defaultValue: 1),
                    ProviderId = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_UserRoles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "UserRoles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationConnectionstring_OrganizationID",
                table: "OrganizationConnectionstring",
                column: "OrganizationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CreatedBy",
                table: "Staff",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DeletedBy",
                table: "Staff",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrganizationID",
                table: "Staff",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ProviderId",
                table: "Staff",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleID",
                table: "Staff",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointment_Staff_StaffID",
                table: "PatientAppointment",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Staff_StaffID",
                table: "PatientEncounter",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Staff_AdministeredBy",
                table: "PatientImmunization",
                column: "AdministeredBy",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Staff_OrderBy",
                table: "PatientImmunization",
                column: "OrderBy",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Restrict);

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
    }
}
