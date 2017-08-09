using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class Migration66 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_User_Roles_RoleID",
            //    table: "User");

            //migrationBuilder.DropTable(
            //    name: "Roles");

            //migrationBuilder.AddColumn<int>(
            //    name: "DeletedBy",
            //    table: "User",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "DeletedDate",
            //    table: "User",
            //    nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "UserRoles",
            //    columns: table => new
            //    {
            //        RoleID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DeletedBy = table.Column<int>(nullable: true),
            //        DeletedDate = table.Column<DateTime>(nullable: true),
            //        IsActive = table.Column<bool>(nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: true),
            //        RoleName = table.Column<string>(maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserRoles", x => x.RoleID);
            //        table.ForeignKey(
            //            name: "FK_UserRoles_User_DeletedBy",
            //            column: x => x.DeletedBy,
            //            principalTable: "User",
            //            principalColumn: "UserID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_User_DeletedBy",
            //    table: "User",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserRoles_DeletedBy",
            //    table: "UserRoles",
            //    column: "DeletedBy");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_User_User_DeletedBy",
            //    table: "User",
            //    column: "DeletedBy",
            //    principalTable: "User",
            //    principalColumn: "UserID",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRoles_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "UserRoles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_DeletedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRoles_RoleID",
                table: "User");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_User_DeletedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "User");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    RoleName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Roles_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DeletedBy",
                table: "Roles",
                column: "DeletedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Roles_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
