using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class migration53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterLabs",
                columns: table => new
                {
                    LabID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(maxLength: 500, nullable: true),
                    Address2 = table.Column<string>(maxLength: 500, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    LabName = table.Column<string>(maxLength: 100, nullable: true),
                    LabPhone = table.Column<string>(maxLength: 20, nullable: true),
                    StateID = table.Column<int>(nullable: false),
                    Zip = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLabs", x => x.LabID);
                    table.ForeignKey(
                        name: "FK_MasterLabs_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterLabs_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MasterLabs_MasterState_StateID",
                        column: x => x.StateID,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterLonic",
                columns: table => new
                {
                    LonicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    LonicCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLonic", x => x.LonicID);
                    table.ForeignKey(
                        name: "FK_MasterLonic_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterLonic_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientLabTest",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConditionOfSpecimen = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    FrequencyDuration = table.Column<string>(maxLength: 100, nullable: true),
                    FrequencyDurationID = table.Column<int>(nullable: false),
                    FrequencyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    LabName = table.Column<int>(nullable: false),
                    LonicCodeID = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OrderBy = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Ordered = table.Column<bool>(nullable: false),
                    PatientID = table.Column<int>(nullable: false),
                    ScheduledDate = table.Column<DateTime>(nullable: false),
                    TestName = table.Column<string>(maxLength: 100, nullable: false),
                    TestSpecimenSource = table.Column<string>(maxLength: 200, nullable: true),
                    TestTypeID = table.Column<int>(nullable: false),
                    TimeTypeID = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientLabTest", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_User_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_MasterType_FrequencyDurationID",
                        column: x => x.FrequencyDurationID,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_MasterType_FrequencyID",
                        column: x => x.FrequencyID,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_MasterLabs_LabName",
                        column: x => x.LabName,
                        principalTable: "MasterLabs",
                        principalColumn: "LabID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_MasterLonic_LonicCodeID",
                        column: x => x.LonicCodeID,
                        principalTable: "MasterLonic",
                        principalColumn: "LonicID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_Provider_OrderBy",
                        column: x => x.OrderBy,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_MasterType_TestTypeID",
                        column: x => x.TestTypeID,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_MasterType_TimeTypeID",
                        column: x => x.TimeTypeID,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientLabTest_User_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterLabs_CreatedBy",
                table: "MasterLabs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLabs_DeletedBy",
                table: "MasterLabs",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLabs_StateID",
                table: "MasterLabs",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLonic_CreatedBy",
                table: "MasterLonic",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLonic_DeletedBy",
                table: "MasterLonic",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_CreatedBy",
                table: "PatientLabTest",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_DeletedBy",
                table: "PatientLabTest",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_FrequencyDurationID",
                table: "PatientLabTest",
                column: "FrequencyDurationID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_FrequencyID",
                table: "PatientLabTest",
                column: "FrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_LabName",
                table: "PatientLabTest",
                column: "LabName");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_LonicCodeID",
                table: "PatientLabTest",
                column: "LonicCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_OrderBy",
                table: "PatientLabTest",
                column: "OrderBy");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_PatientID",
                table: "PatientLabTest",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_TestTypeID",
                table: "PatientLabTest",
                column: "TestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_TimeTypeID",
                table: "PatientLabTest",
                column: "TimeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientLabTest_UpdatedBy",
                table: "PatientLabTest",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientLabTest");

            migrationBuilder.DropTable(
                name: "MasterLabs");

            migrationBuilder.DropTable(
                name: "MasterLonic");
        }
    }
}
