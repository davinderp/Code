using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HC.Patient.Web.Migrations
{
    public partial class migration49 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_Manufacture",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility",
                table: "PatientImmunization");

            migrationBuilder.RenameColumn(
                name: "VFC_Eligibility",
                table: "PatientImmunization",
                newName: "VFCID");

            migrationBuilder.RenameColumn(
                name: "RouteOfAdministration",
                table: "PatientImmunization",
                newName: "RouteOfAdministrationID");

            migrationBuilder.RenameColumn(
                name: "RejectionReason",
                table: "PatientImmunization",
                newName: "RejectionReasonID");

            migrationBuilder.RenameColumn(
                name: "Manufacture",
                table: "PatientImmunization",
                newName: "ManufactureID");

            migrationBuilder.RenameColumn(
                name: "ImmunityStatus",
                table: "PatientImmunization",
                newName: "ImmunityStatusID");

            migrationBuilder.RenameColumn(
                name: "AdministrationSite",
                table: "PatientImmunization",
                newName: "AdministrationSiteID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_VFC_Eligibility",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_VFCID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RouteOfAdministration",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RouteOfAdministrationID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RejectionReason",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RejectionReasonID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_Manufacture",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_ManufactureID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_ImmunityStatus",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_ImmunityStatusID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_AdministrationSite",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_AdministrationSiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSiteID",
                table: "PatientImmunization",
                column: "AdministrationSiteID",
                principalTable: "MasterAdministrationSite",
                principalColumn: "AdministrationSiteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatusID",
                table: "PatientImmunization",
                column: "ImmunityStatusID",
                principalTable: "MasterImmunityStatus",
                principalColumn: "ImmunityStatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_ManufactureID",
                table: "PatientImmunization",
                column: "ManufactureID",
                principalTable: "MasterManufacture",
                principalColumn: "ManufactureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReasonID",
                table: "PatientImmunization",
                column: "RejectionReasonID",
                principalTable: "MasterRejectionReason",
                principalColumn: "RejectionReasonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministrationID",
                table: "PatientImmunization",
                column: "RouteOfAdministrationID",
                principalTable: "MasterRouteOfAdministration",
                principalColumn: "RouteOfAdministrationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFCID",
                table: "PatientImmunization",
                column: "VFCID",
                principalTable: "MasterVFCEligibility",
                principalColumn: "VFCID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSiteID",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatusID",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_ManufactureID",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReasonID",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministrationID",
                table: "PatientImmunization");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFCID",
                table: "PatientImmunization");

            migrationBuilder.RenameColumn(
                name: "VFCID",
                table: "PatientImmunization",
                newName: "VFC_Eligibility");

            migrationBuilder.RenameColumn(
                name: "RouteOfAdministrationID",
                table: "PatientImmunization",
                newName: "RouteOfAdministration");

            migrationBuilder.RenameColumn(
                name: "RejectionReasonID",
                table: "PatientImmunization",
                newName: "RejectionReason");

            migrationBuilder.RenameColumn(
                name: "ManufactureID",
                table: "PatientImmunization",
                newName: "Manufacture");

            migrationBuilder.RenameColumn(
                name: "ImmunityStatusID",
                table: "PatientImmunization",
                newName: "ImmunityStatus");

            migrationBuilder.RenameColumn(
                name: "AdministrationSiteID",
                table: "PatientImmunization",
                newName: "AdministrationSite");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_VFCID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_VFC_Eligibility");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RouteOfAdministrationID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RouteOfAdministration");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_RejectionReasonID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_RejectionReason");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_ManufactureID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_Manufacture");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_ImmunityStatusID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_ImmunityStatus");

            migrationBuilder.RenameIndex(
                name: "IX_PatientImmunization_AdministrationSiteID",
                table: "PatientImmunization",
                newName: "IX_PatientImmunization_AdministrationSite");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterAdministrationSite_AdministrationSite",
                table: "PatientImmunization",
                column: "AdministrationSite",
                principalTable: "MasterAdministrationSite",
                principalColumn: "AdministrationSiteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterImmunityStatus_ImmunityStatus",
                table: "PatientImmunization",
                column: "ImmunityStatus",
                principalTable: "MasterImmunityStatus",
                principalColumn: "ImmunityStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterManufacture_Manufacture",
                table: "PatientImmunization",
                column: "Manufacture",
                principalTable: "MasterManufacture",
                principalColumn: "ManufactureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRejectionReason_RejectionReason",
                table: "PatientImmunization",
                column: "RejectionReason",
                principalTable: "MasterRejectionReason",
                principalColumn: "RejectionReasonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterRouteOfAdministration_RouteOfAdministration",
                table: "PatientImmunization",
                column: "RouteOfAdministration",
                principalTable: "MasterRouteOfAdministration",
                principalColumn: "RouteOfAdministrationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientImmunization_MasterVFCEligibility_VFC_Eligibility",
                table: "PatientImmunization",
                column: "VFC_Eligibility",
                principalTable: "MasterVFCEligibility",
                principalColumn: "VFCID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
