using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterAdministrationSite",
                columns: table => new
                {
                    AdministrationSiteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HL7 = table.Column<string>(maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SNOMED = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAdministrationSite", x => x.AdministrationSiteID);
                    table.ForeignKey(
                        name: "FK_MasterAdministrationSite_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterImmunityStatus",
                columns: table => new
                {
                    ImmunityStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConceptCode = table.Column<string>(maxLength: 10, nullable: true),
                    ConceptName = table.Column<string>(nullable: true),
                    Defination = table.Column<string>(maxLength: 300, nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    HL7Code = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    NIP004 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterImmunityStatus", x => x.ImmunityStatusID);
                    table.ForeignKey(
                        name: "FK_MasterImmunityStatus_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterImmunization",
                columns: table => new
                {
                    ImmunizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CvxCode = table.Column<string>(maxLength: 50, nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    InternalID = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    NonVaccine = table.Column<bool>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ShortDesc = table.Column<string>(maxLength: 50, nullable: true),
                    VaccineName = table.Column<string>(nullable: true),
                    VaccineStatus = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterImmunization", x => x.ImmunizationID);
                    table.ForeignKey(
                        name: "FK_MasterImmunization_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterManufacture",
                columns: table => new
                {
                    ManufactureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    MVXCode = table.Column<string>(maxLength: 50, nullable: true),
                    ManufacturerName = table.Column<string>(maxLength: 500, nullable: true),
                    Notes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterManufacture", x => x.ManufactureID);
                    table.ForeignKey(
                        name: "FK_MasterManufacture_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterRejectionReason",
                columns: table => new
                {
                    RejectionReasonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    InternalID = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    NonVaccine = table.Column<bool>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ReasonCode = table.Column<string>(maxLength: 5, nullable: true),
                    ReasonDesc = table.Column<string>(maxLength: 100, nullable: true),
                    VaccineStatus = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterRejectionReason", x => x.RejectionReasonID);
                    table.ForeignKey(
                        name: "FK_MasterRejectionReason_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterRouteOfAdministration",
                columns: table => new
                {
                    RouteOfAdministrationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Definition = table.Column<string>(maxLength: 500, nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    FDANCI = table.Column<string>(maxLength: 10, nullable: true),
                    HL7 = table.Column<string>(maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterRouteOfAdministration", x => x.RouteOfAdministrationID);
                    table.ForeignKey(
                        name: "FK_MasterRouteOfAdministration_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterVFCEligibility",
                columns: table => new
                {
                    VFCID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConceptCode = table.Column<string>(maxLength: 10, nullable: true),
                    ConceptName = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterVFCEligibility", x => x.VFCID);
                    table.ForeignKey(
                        name: "FK_MasterVFCEligibility_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterAdministrationSite_DeletedBy_fk",
                table: "MasterAdministrationSite",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterImmunityStatus_DeletedBy_fk",
                table: "MasterImmunityStatus",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterImmunization_DeletedBy_fk",
                table: "MasterImmunization",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterManufacture_DeletedBy_fk",
                table: "MasterManufacture",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterRejectionReason_DeletedBy_fk",
                table: "MasterRejectionReason",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterRouteOfAdministration_DeletedBy_fk",
                table: "MasterRouteOfAdministration",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterVFCEligibility_DeletedBy_fk",
                table: "MasterVFCEligibility",
                column: "DeletedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterAdministrationSite");

            migrationBuilder.DropTable(
                name: "MasterImmunityStatus");

            migrationBuilder.DropTable(
                name: "MasterImmunization");

            migrationBuilder.DropTable(
                name: "MasterManufacture");

            migrationBuilder.DropTable(
                name: "MasterRejectionReason");

            migrationBuilder.DropTable(
                name: "MasterRouteOfAdministration");

            migrationBuilder.DropTable(
                name: "MasterVFCEligibility");
        }
    }
}
