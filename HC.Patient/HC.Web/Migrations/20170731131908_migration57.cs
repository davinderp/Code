using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PhoneNumbers_Doctors_DoctorsId",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropIndex(
            //    name: "IX_PhoneNumbers_DoctorsId",
            //    table: "PhoneNumbers");

            //migrationBuilder.DropColumn(
            //    name: "DoctorsId",
            //    table: "PhoneNumbers");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Doctors",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_DoctorID",
                table: "PhoneNumbers",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Doctors_DoctorID",
                table: "PhoneNumbers",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Doctors_DoctorID",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_DoctorID",
                table: "PhoneNumbers");

            migrationBuilder.AddColumn<int>(
                name: "DoctorsId",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Doctors",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_DoctorsId",
                table: "PhoneNumbers",
                column: "DoctorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Doctors_DoctorsId",
                table: "PhoneNumbers",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
