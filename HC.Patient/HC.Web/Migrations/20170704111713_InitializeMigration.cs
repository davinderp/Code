using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HC.Patient.Web.Migrations
{
    public partial class InitializeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "MasterCountry",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCountry", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_MasterCountry_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterDocumentType",
                columns: table => new
                {
                    DocumentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    DocumentType = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDocumentType", x => x.DocumentTypeID);
                    table.ForeignKey(
                        name: "FK_MasterDocumentType_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterEthnicity",
                columns: table => new
                {
                    EthnicityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    EthnicityName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterEthnicity", x => x.EthnicityID);
                    table.ForeignKey(
                        name: "FK_MasterEthnicity_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterFundingSource",
                columns: table => new
                {
                    FundingSourceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    FundingSource = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFundingSource", x => x.FundingSourceID);
                    table.ForeignKey(
                        name: "FK_MasterFundingSource_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterGender",
                columns: table => new
                {
                    GenderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterGender", x => x.GenderID);
                    table.ForeignKey(
                        name: "FK_MasterGender_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterInsurancePCP",
                columns: table => new
                {
                    InsurancePCPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    InsurancePCP = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInsurancePCP", x => x.InsurancePCPID);
                    table.ForeignKey(
                        name: "FK_MasterInsurancePCP_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterInsuranceType",
                columns: table => new
                {
                    InsuranceTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    InsuranceType = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInsuranceType", x => x.InsuranceTypeID);
                    table.ForeignKey(
                        name: "FK_MasterInsuranceType_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterOccupation",
                columns: table => new
                {
                    OccupationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    OccupationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterOccupation", x => x.OccupationID);
                    table.ForeignKey(
                        name: "FK_MasterOccupation_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterPreferredLanguage",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPreferredLanguage", x => x.LanguageID);
                    table.ForeignKey(
                        name: "FK_MasterPreferredLanguage_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterRace",
                columns: table => new
                {
                    RaceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    RaceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterRace", x => x.RaceID);
                    table.ForeignKey(
                        name: "FK_MasterRace_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterState",
                columns: table => new
                {
                    StateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterState", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_MasterState_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    StatusName = table.Column<string>(nullable: true),
                    StatusType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterStatus", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_MasterStatus_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterType",
                columns: table => new
                {
                    TypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterType", x => x.TypeID);
                    table.ForeignKey(
                        name: "FK_MasterType_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    ProviderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeletedBy_fk = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ProviderAddress = table.Column<string>(maxLength: 500, nullable: true),
                    ProviderEmail = table.Column<string>(maxLength: 256, nullable: true),
                    ProviderName = table.Column<string>(maxLength: 50, nullable: true),
                    ProviderPhone_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.ProviderId);
                    table.ForeignKey(
                        name: "FK_Provider_User_DeletedBy_fk",
                        column: x => x.DeletedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Citizenship_fk = table.Column<int>(nullable: true),
                    ClientStatus_fk = table.Column<int>(nullable: false),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    EmergencyContactFirstName = table.Column<string>(maxLength: 100, nullable: true),
                    EmergencyContactLastName = table.Column<string>(maxLength: 100, nullable: true),
                    EmergencyContactPhone = table.Column<string>(maxLength: 20, nullable: true),
                    EmergencyContactRelationship_fk = table.Column<int>(nullable: false),
                    Ethnicity_fk = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    Gender_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    MRN = table.Column<string>(maxLength: 50, nullable: true),
                    MaritalStatus_fk = table.Column<int>(nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    PhotoPath = table.Column<string>(nullable: true),
                    PhotoThumbnailPath = table.Column<string>(nullable: true),
                    PrimaryProvider_fk = table.Column<int>(nullable: false),
                    Race_fk = table.Column<int>(nullable: false),
                    SSN = table.Column<string>(maxLength: 20, nullable: true),
                    SecondaryRace_fk = table.Column<int>(nullable: false),
                    Suffix_fk = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 10, nullable: true),
                    UpdatedBy_fk = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patient_MasterStatus_ClientStatus_fk",
                        column: x => x.ClientStatus_fk,
                        principalTable: "MasterStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterType_EmergencyContactRelationship_fk",
                        column: x => x.EmergencyContactRelationship_fk,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterEthnicity_Ethnicity_fk",
                        column: x => x.Ethnicity_fk,
                        principalTable: "MasterEthnicity",
                        principalColumn: "EthnicityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterGender_Gender_fk",
                        column: x => x.Gender_fk,
                        principalTable: "MasterGender",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterStatus_MaritalStatus_fk",
                        column: x => x.MaritalStatus_fk,
                        principalTable: "MasterStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Provider_PrimaryProvider_fk",
                        column: x => x.PrimaryProvider_fk,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterRace_Race_fk",
                        column: x => x.Race_fk,
                        principalTable: "MasterRace",
                        principalColumn: "RaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterRace_SecondaryRace_fk",
                        column: x => x.SecondaryRace_fk,
                        principalTable: "MasterRace",
                        principalColumn: "RaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_MasterType_Suffix_fk",
                        column: x => x.Suffix_fk,
                        principalTable: "MasterType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientDocuments",
                columns: table => new
                {
                    PatientDocumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DocumentName = table.Column<string>(nullable: true),
                    DocumentNumber = table.Column<string>(nullable: true),
                    DocumentType_fk = table.Column<int>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    State_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDocuments", x => x.PatientDocumentId);
                    table.ForeignKey(
                        name: "FK_PatientDocuments_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDocuments_MasterDocumentType_DocumentType_fk",
                        column: x => x.DocumentType_fk,
                        principalTable: "MasterDocumentType",
                        principalColumn: "DocumentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDocuments_Patient_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDocuments_MasterState_State_fk",
                        column: x => x.State_fk,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDocuments_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientEmploymentDetail",
                columns: table => new
                {
                    PatientEmplomentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Employer = table.Column<string>(nullable: true),
                    EmploymentStatus_fk = table.Column<int>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    Occupation_fk = table.Column<int>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientEmploymentDetail", x => x.PatientEmplomentID);
                    table.ForeignKey(
                        name: "FK_PatientEmploymentDetail_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEmploymentDetail_MasterStatus_EmploymentStatus_fk",
                        column: x => x.EmploymentStatus_fk,
                        principalTable: "MasterStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEmploymentDetail_MasterOccupation_Occupation_fk",
                        column: x => x.Occupation_fk,
                        principalTable: "MasterOccupation",
                        principalColumn: "OccupationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEmploymentDetail_Patient_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientEmploymentDetail_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientGuardian",
                columns: table => new
                {
                    GuardianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    GuardianAddress1 = table.Column<string>(nullable: true),
                    GuardianAddress2 = table.Column<string>(nullable: true),
                    GuardianCity = table.Column<string>(nullable: true),
                    GuardianEmail = table.Column<string>(nullable: true),
                    GuardianFirstName = table.Column<string>(nullable: true),
                    GuardianHomePhone = table.Column<string>(nullable: true),
                    GuardianLastName = table.Column<string>(nullable: true),
                    GuardianMiddleName = table.Column<string>(nullable: true),
                    GuardianMobile = table.Column<string>(nullable: true),
                    GuardianState_fk = table.Column<int>(nullable: false),
                    GuardianWorkPhone = table.Column<string>(nullable: true),
                    GuardianZip = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientGuardian", x => x.GuardianId);
                    table.ForeignKey(
                        name: "FK_PatientGuardian_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientGuardian_MasterState_GuardianState_fk",
                        column: x => x.GuardianState_fk,
                        principalTable: "MasterState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientGuardian_Patient_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientGuardian_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientInsuranceDetails",
                columns: table => new
                {
                    PatientInsuranceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy_fk = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    GroupNumber = table.Column<string>(nullable: true),
                    InsuranceCompany = table.Column<string>(nullable: true),
                    InsuranceID = table.Column<string>(nullable: true),
                    InsurancePCP_fk = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsEmployeePlan = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    PatientID_fk = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Type_fk = table.Column<int>(nullable: false),
                    UpdatedBy_fk = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInsuranceDetails", x => x.PatientInsuranceID);
                    table.ForeignKey(
                        name: "FK_PatientInsuranceDetails_User_CreatedBy_fk",
                        column: x => x.CreatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientInsuranceDetails_MasterInsurancePCP_InsurancePCP_fk",
                        column: x => x.InsurancePCP_fk,
                        principalTable: "MasterInsurancePCP",
                        principalColumn: "InsurancePCPID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientInsuranceDetails_Patient_PatientID_fk",
                        column: x => x.PatientID_fk,
                        principalTable: "Patient",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientInsuranceDetails_MasterInsuranceType_Type_fk",
                        column: x => x.Type_fk,
                        principalTable: "MasterInsuranceType",
                        principalColumn: "InsuranceTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientInsuranceDetails_User_UpdatedBy_fk",
                        column: x => x.UpdatedBy_fk,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterCountry_DeletedBy_fk",
                table: "MasterCountry",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterDocumentType_DeletedBy_fk",
                table: "MasterDocumentType",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEthnicity_DeletedBy_fk",
                table: "MasterEthnicity",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterFundingSource_DeletedBy_fk",
                table: "MasterFundingSource",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterGender_DeletedBy_fk",
                table: "MasterGender",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterInsurancePCP_DeletedBy_fk",
                table: "MasterInsurancePCP",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterInsuranceType_DeletedBy_fk",
                table: "MasterInsuranceType",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterOccupation_DeletedBy_fk",
                table: "MasterOccupation",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPreferredLanguage_DeletedBy_fk",
                table: "MasterPreferredLanguage",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterRace_DeletedBy_fk",
                table: "MasterRace",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterState_DeletedBy_fk",
                table: "MasterState",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterStatus_DeletedBy_fk",
                table: "MasterStatus",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_MasterType_DeletedBy_fk",
                table: "MasterType",
                column: "DeletedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDocuments_CreatedBy_fk",
                table: "PatientDocuments",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDocuments_DocumentType_fk",
                table: "PatientDocuments",
                column: "DocumentType_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDocuments_PatientID_fk",
                table: "PatientDocuments",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDocuments_State_fk",
                table: "PatientDocuments",
                column: "State_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDocuments_UpdatedBy_fk",
                table: "PatientDocuments",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmploymentDetail_CreatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmploymentDetail_EmploymentStatus_fk",
                table: "PatientEmploymentDetail",
                column: "EmploymentStatus_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmploymentDetail_Occupation_fk",
                table: "PatientEmploymentDetail",
                column: "Occupation_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmploymentDetail_PatientID_fk",
                table: "PatientEmploymentDetail",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientEmploymentDetail_UpdatedBy_fk",
                table: "PatientEmploymentDetail",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientGuardian_CreatedBy_fk",
                table: "PatientGuardian",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientGuardian_GuardianState_fk",
                table: "PatientGuardian",
                column: "GuardianState_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientGuardian_PatientID_fk",
                table: "PatientGuardian",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientGuardian_UpdatedBy_fk",
                table: "PatientGuardian",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_CreatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_InsurancePCP_fk",
                table: "PatientInsuranceDetails",
                column: "InsurancePCP_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_PatientID_fk",
                table: "PatientInsuranceDetails",
                column: "PatientID_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_Type_fk",
                table: "PatientInsuranceDetails",
                column: "Type_fk");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInsuranceDetails_UpdatedBy_fk",
                table: "PatientInsuranceDetails",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ClientStatus_fk",
                table: "Patient",
                column: "ClientStatus_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_CreatedBy_fk",
                table: "Patient",
                column: "CreatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_EmergencyContactRelationship_fk",
                table: "Patient",
                column: "EmergencyContactRelationship_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Ethnicity_fk",
                table: "Patient",
                column: "Ethnicity_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Gender_fk",
                table: "Patient",
                column: "Gender_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MaritalStatus_fk",
                table: "Patient",
                column: "MaritalStatus_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PrimaryProvider_fk",
                table: "Patient",
                column: "PrimaryProvider_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Race_fk",
                table: "Patient",
                column: "Race_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_SecondaryRace_fk",
                table: "Patient",
                column: "SecondaryRace_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Suffix_fk",
                table: "Patient",
                column: "Suffix_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UpdatedBy_fk",
                table: "Patient",
                column: "UpdatedBy_fk");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_DeletedBy_fk",
                table: "Provider",
                column: "DeletedBy_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterCountry");

            migrationBuilder.DropTable(
                name: "MasterFundingSource");

            migrationBuilder.DropTable(
                name: "MasterPreferredLanguage");

            migrationBuilder.DropTable(
                name: "PatientDocuments");

            migrationBuilder.DropTable(
                name: "PatientEmploymentDetail");

            migrationBuilder.DropTable(
                name: "PatientGuardian");

            migrationBuilder.DropTable(
                name: "PatientInsuranceDetails");

            migrationBuilder.DropTable(
                name: "MasterDocumentType");

            migrationBuilder.DropTable(
                name: "MasterOccupation");

            migrationBuilder.DropTable(
                name: "MasterState");

            migrationBuilder.DropTable(
                name: "MasterInsurancePCP");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "MasterInsuranceType");

            migrationBuilder.DropTable(
                name: "MasterStatus");

            migrationBuilder.DropTable(
                name: "MasterType");

            migrationBuilder.DropTable(
                name: "MasterEthnicity");

            migrationBuilder.DropTable(
                name: "MasterGender");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "MasterRace");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
