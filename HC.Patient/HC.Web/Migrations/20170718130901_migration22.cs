using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patients_Email",
                table: "Patients");

            migrationBuilder.CreateTable(
                name: "PatientImmunization",
                columns: table => new
                {
                    ImmunizationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdministeredBy_fk = table.Column<int>(nullable: true),
                    AdministeredDate = table.Column<DateTime>(nullable: false),
                    AdministrationSite_fk = table.Column<int>(nullable: true),
                    AmountAdministered = table.Column<int>(nullable: true),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    ImmunityStatus_fk = table.Column<int>(nullable: false),
                    Immunization_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Manufacture_fk = table.Column<int>(nullable: true),
                    OrderBy_fk = table.Column<int>(nullable: true),
                    PatientID_fk = table.Column<int>(nullable: false),
                    RejectedImmunization = table.Column<bool>(nullable: false),
                    RejectionReason_fk = table.Column<int>(nullable: true),
                    RouteOfAdministration_fk = table.Column<int>(nullable: true),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    VFC_Eligibility_fk = table.Column<int>(nullable: true),
                    VaccineLotNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientImmunization", x => x.ImmunizationId);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_Provider_AdministeredBy_fk",
                        column: x => x.AdministeredBy_fk,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite_fk",
                        column: x => x.AdministrationSite_fk,
                        principalTable: "MasterAdministrationSite",
                        principalColumn: "AdministrationSiteID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus_fk",
                        column: x => x.ImmunityStatus_fk,
                        principalTable: "MasterImmunityStatus",
                        principalColumn: "ImmunityStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterImmunization_Immunization_fk",
                        column: x => x.Immunization_fk,
                        principalTable: "MasterImmunization",
                        principalColumn: "ImmunizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterManufacture_Manufacture_fk",
                        column: x => x.Manufacture_fk,
                        principalTable: "MasterManufacture",
                        principalColumn: "ManufactureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_Provider_OrderBy_fk",
                        column: x => x.OrderBy_fk,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_Patients_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason_fk",
                        column: x => x.RejectionReason_fk,
                        principalTable: "MasterRejectionReason",
                        principalColumn: "RejectionReasonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration_fk",
                        column: x => x.RouteOfAdministration_fk,
                        principalTable: "MasterRouteOfAdministration",
                        principalColumn: "RouteOfAdministrationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility_fk",
                        column: x => x.VFC_Eligibility_fk,
                        principalTable: "MasterVFCEligibility",
                        principalColumn: "VFCID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_AdministeredBy_fk",
                table: "PatientImmunization",
                column: "AdministeredBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_AdministrationSite_fk",
                table: "PatientImmunization",
                column: "AdministrationSite_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_CreatedBy_fk",
                table: "PatientImmunization",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_ImmunityStatus_fk",
                table: "PatientImmunization",
                column: "ImmunityStatus_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_Immunization_fk",
                table: "PatientImmunization",
                column: "Immunization_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_Manufacture_fk",
                table: "PatientImmunization",
                column: "Manufacture_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_OrderBy_fk",
                table: "PatientImmunization",
                column: "OrderBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_PatientID_fk",
                table: "PatientImmunization",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_RejectionReason_fk",
                table: "PatientImmunization",
                column: "RejectionReason_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_RouteOfAdministration_fk",
                table: "PatientImmunization",
                column: "RouteOfAdministration_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_UpdatedBy_fk",
                table: "PatientImmunization",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientImmunization_VFC_Eligibility_fk",
                table: "PatientImmunization",
                column: "VFC_Eligibility_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientImmunization");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Email",
                table: "Patients",
                column: "Email",
                unique: true);
        }
    }
}
