using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration79 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    AuditLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    EventID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true, defaultValue: false),
                    NewValue = table.Column<string>(nullable: false),
                    OldValue = table.Column<string>(nullable: false),
                    OrganizationID = table.Column<int>(nullable: false, defaultValue: 1),
                    PrimaryKeyID = table.Column<int>(nullable: false),
                    PropertyName = table.Column<string>(nullable: false),
                    TableName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.AuditLogID);
                    table.ForeignKey(
                        name: "FK_AuditLogs_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditLogs_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Restrict);
                });

            //migrationBuilder.CreateTable(
            //    name: "Event",
            //    columns: table => new
            //    {
            //        EventId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Data = table.Column<string>(nullable: true),
            //        InsertedDate = table.Column<DateTime>(nullable: false),
            //        LastUpdatedDate = table.Column<DateTime>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Event", x => x.EventId);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AuditLogs_CreatedBy",
            //    table: "AuditLogs",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AuditLogs_DeletedBy",
            //    table: "AuditLogs",
            //    column: "DeletedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AuditLogs_OrganizationID",
            //    table: "AuditLogs",
            //    column: "OrganizationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
