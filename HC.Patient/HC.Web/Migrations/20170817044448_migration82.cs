using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration82 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClientStatus",
                table: "Patients",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PatientAppointment",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PatientAppointment",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAppointment",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_EventID",
                table: "AuditLogs",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditLogs_Event_EventID",
                table: "AuditLogs",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditLogs_Event_EventID",
                table: "AuditLogs");

            migrationBuilder.DropIndex(
                name: "IX_AuditLogs_EventID",
                table: "AuditLogs");

            migrationBuilder.AlterColumn<int>(
                name: "ClientStatus",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PatientAppointment",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PatientAppointment",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PatientAppointment",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");
        }
    }
}
