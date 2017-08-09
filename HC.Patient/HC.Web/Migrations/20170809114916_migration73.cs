using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration73 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointment_Doctors_DoctorID",
                table: "PatientAppointment");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientEncounter_Doctors_DoctorId",
                table: "PatientEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Doctors_AdministeredBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_Doctors_OrderBy",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_PrimaryDoctor",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Doctors_DoctorID",
                table: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "PhoneNumbers",
                newName: "ClinicianID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_DoctorID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ClinicianID");

            migrationBuilder.RenameColumn(
                name: "PrimaryDoctor",
                table: "Patients",
                newName: "PrimaryClinician");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PrimaryDoctor",
                table: "Patients",
                newName: "IX_Patients_PrimaryClinician");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "PatientEncounter",
                newName: "ClinicianID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_DoctorId",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_ClinicianID");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "PatientAppointment",
                newName: "ClinicianID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAppointment_DoctorID",
                table: "PatientAppointment",
                newName: "IX_PatientAppointment_ClinicianID");

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    OrganizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    OrganizationDescription = table.Column<string>(maxLength: 1000, nullable: false),
                    OrganizationName = table.Column<string>(maxLength: 100, nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.OrganizationID);
                    table.ForeignKey(
                        name: "FK_Organization_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organization_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organization_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Organization_CreatedBy",
                table: "Organization",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_DeletedBy",
                table: "Organization",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_UpdatedBy",
                table: "Organization",
                column: "UpdatedBy");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointment_Clinicians_ClinicianID",
                table: "PatientAppointment");

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

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.RenameColumn(
                name: "ClinicianID",
                table: "PhoneNumbers",
                newName: "DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ClinicianID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_DoctorID");

            migrationBuilder.RenameColumn(
                name: "PrimaryClinician",
                table: "Patients",
                newName: "PrimaryDoctor");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PrimaryClinician",
                table: "Patients",
                newName: "IX_Patients_PrimaryDoctor");

            migrationBuilder.RenameColumn(
                name: "ClinicianID",
                table: "PatientEncounter",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientEncounter_ClinicianID",
                table: "PatientEncounter",
                newName: "IX_PatientEncounter_DoctorId");

            migrationBuilder.RenameColumn(
                name: "ClinicianID",
                table: "PatientAppointment",
                newName: "DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAppointment_ClinicianID",
                table: "PatientAppointment",
                newName: "IX_PatientAppointment_DoctorID");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(nullable: false)
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
                    ProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_Doctors_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CreatedBy",
                table: "Doctors",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DeletedBy",
                table: "Doctors",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ProviderId",
                table: "Doctors",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointment_Doctors_DoctorID",
                table: "PatientAppointment",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientEncounter_Doctors_DoctorId",
                table: "PatientEncounter",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Doctors_AdministeredBy",
                table: "PatientImmunization",
                column: "AdministeredBy",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_Doctors_OrderBy",
                table: "PatientImmunization",
                column: "OrderBy",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_PrimaryDoctor",
                table: "Patients",
                column: "PrimaryDoctor",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Doctors_DoctorID",
                table: "PhoneNumbers",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
