using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HC.Patient.Data;

namespace HC.Patient.Web.Migrations
{
    [DbContext(typeof(HCPatientContext))]
    [Migration("20170704111713_InitializeMigration")]
    partial class InitializeMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HC.Patient.Entity.MasterCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CountryID");

                    b.Property<string>("CountryName");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterCountry");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterDocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DocumentTypeID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<string>("DocumentType");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterDocumentType");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterEthnicity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EthnicityID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<string>("EthnicityName");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterEthnicity");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterFundingSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FundingSourceID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FundingSource");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterFundingSource");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GenderID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterGender");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterInsurancePCP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InsurancePCPID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<string>("InsurancePCP");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterInsurancePCP");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterInsuranceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InsuranceTypeID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<string>("InsuranceType");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterInsuranceType");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterOccupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OccupationID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("OccupationName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterOccupation");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPreferredLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LanguageID");

                    b.Property<string>("Code");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Language");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterPreferredLanguage");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RaceID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("RaceName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterRace");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StateID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("StateName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterState");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StatusID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("StatusName");

                    b.Property<string>("StatusType");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterStatus");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypeID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Type");

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterType");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDocuments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientDocumentId");

                    b.Property<int>("CreatedBy_fk");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DocumentName");

                    b.Property<string>("DocumentNumber");

                    b.Property<int>("DocumentType_fk");

                    b.Property<bool>("IsVerified");

                    b.Property<int>("PatientID_fk");

                    b.Property<int>("State_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("DocumentType_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("State_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientDocuments");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEmploymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientEmplomentID");

                    b.Property<int>("CreatedBy_fk");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Employer");

                    b.Property<int>("EmploymentStatus_fk");

                    b.Property<bool>("IsVerified");

                    b.Property<int>("Occupation_fk");

                    b.Property<int>("PatientID_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("WorkPhone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("EmploymentStatus_fk");

                    b.HasIndex("Occupation_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientEmploymentDetail");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientGuardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuardianId");

                    b.Property<int>("CreatedBy_fk");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("GuardianAddress1");

                    b.Property<string>("GuardianAddress2");

                    b.Property<string>("GuardianCity");

                    b.Property<string>("GuardianEmail");

                    b.Property<string>("GuardianFirstName");

                    b.Property<string>("GuardianHomePhone");

                    b.Property<string>("GuardianLastName");

                    b.Property<string>("GuardianMiddleName");

                    b.Property<string>("GuardianMobile");

                    b.Property<int>("GuardianState_fk");

                    b.Property<string>("GuardianWorkPhone");

                    b.Property<string>("GuardianZip");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsVerified");

                    b.Property<int>("PatientID_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("GuardianState_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientGuardian");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientInsuranceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientInsuranceID");

                    b.Property<int>("CreatedBy_fk");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("GroupNumber");

                    b.Property<string>("InsuranceCompany");

                    b.Property<string>("InsuranceID");

                    b.Property<int>("InsurancePCP_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsEmployeePlan");

                    b.Property<bool>("IsVerified");

                    b.Property<int>("PatientID_fk");

                    b.Property<bool>("Status");

                    b.Property<int>("Type_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("InsurancePCP_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("Type_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientInsuranceDetails");
                });

            modelBuilder.Entity("HC.Patient.Entity.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientID");

                    b.Property<int?>("Citizenship_fk");

                    b.Property<int>("ClientStatus_fk");

                    b.Property<int>("CreatedBy_fk");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<string>("EmergencyContactFirstName")
                        .HasMaxLength(100);

                    b.Property<string>("EmergencyContactLastName")
                        .HasMaxLength(100);

                    b.Property<string>("EmergencyContactPhone")
                        .HasMaxLength(20);

                    b.Property<int>("EmergencyContactRelationship_fk");

                    b.Property<int>("Ethnicity_fk");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<int>("Gender_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<string>("MRN")
                        .HasMaxLength(50);

                    b.Property<int>("MaritalStatus_fk");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath");

                    b.Property<string>("PhotoThumbnailPath");

                    b.Property<int>("PrimaryProvider_fk");

                    b.Property<int>("Race_fk");

                    b.Property<string>("SSN")
                        .HasMaxLength(20);

                    b.Property<int>("SecondaryRace_fk");

                    b.Property<int>("Suffix_fk");

                    b.Property<string>("Title")
                        .HasMaxLength(10);

                    b.Property<int>("UpdatedBy_fk");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientStatus_fk");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("EmergencyContactRelationship_fk");

                    b.HasIndex("Ethnicity_fk");

                    b.HasIndex("Gender_fk");

                    b.HasIndex("MaritalStatus_fk");

                    b.HasIndex("PrimaryProvider_fk");

                    b.HasIndex("Race_fk");

                    b.HasIndex("SecondaryRace_fk");

                    b.HasIndex("Suffix_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("HC.Patient.Entity.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProviderId");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("ProviderAddress")
                        .HasMaxLength(500);

                    b.Property<string>("ProviderEmail")
                        .HasMaxLength(256);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(50);

                    b.Property<int>("ProviderPhone_fk");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("HC.Patient.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterCountry", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterDocumentType", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterEthnicity", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterFundingSource", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterGender", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterInsurancePCP", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterInsuranceType", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterOccupation", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPreferredLanguage", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRace", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterState", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterStatus", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterType", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDocuments", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterDocumentType", "MasterDocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentType_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("State_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEmploymentDetail", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("EmploymentStatus_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterOccupation", "MasterOccupation")
                        .WithMany()
                        .HasForeignKey("Occupation_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientGuardian", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("GuardianState_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientInsuranceDetails", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterInsurancePCP", "MasterInsurancePCP")
                        .WithMany()
                        .HasForeignKey("InsurancePCP_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterInsuranceType", "MasterInsuranceType")
                        .WithMany()
                        .HasForeignKey("Type_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.Patients", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus1")
                        .WithMany()
                        .HasForeignKey("ClientStatus_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType1")
                        .WithMany()
                        .HasForeignKey("EmergencyContactRelationship_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterEthnicity", "MasterEthnicity")
                        .WithMany()
                        .HasForeignKey("Ethnicity_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterGender", "MasterGender")
                        .WithMany()
                        .HasForeignKey("Gender_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatus_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("PrimaryProvider_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRace", "MasterRace")
                        .WithMany()
                        .HasForeignKey("Race_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRace", "SecondaryRace")
                        .WithMany()
                        .HasForeignKey("SecondaryRace_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("Suffix_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HC.Patient.Entity.Provider", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });
        }
    }
}
