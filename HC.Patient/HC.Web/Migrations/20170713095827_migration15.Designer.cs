using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HC.Patient.Data;

namespace HC.Patient.Web.Migrations
{
    [DbContext(typeof(HCPatientContext))]
    [Migration("20170713095827_migration15")]
    partial class migration15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HC.Patient.Entity.InsuranceCompanies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InsuranceCompanyId");

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyEmail");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyPhone");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("InsuranceCompanies");
                });

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

            modelBuilder.Entity("HC.Patient.Entity.MasterPatientCommPreferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientCommPreferencesID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("PatientCommPreferences");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterPatientCommPreferences");
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

            modelBuilder.Entity("HC.Patient.Entity.MasterProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProgramID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("ProgramName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterProgram");
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

            modelBuilder.Entity("HC.Patient.Entity.MasterReferral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReferralID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("ReferralName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterReferral");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ServiceID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("ServiceName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.ToTable("MasterService");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StateID");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("StateAbbr")
                        .HasMaxLength(2);

                    b.Property<string>("StateName")
                        .HasMaxLength(50);

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

                    b.Property<string>("Type");

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

            modelBuilder.Entity("HC.Patient.Entity.PatientAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AddressID");

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("HomeAddress1")
                        .HasMaxLength(200);

                    b.Property<string>("HomeAddress2")
                        .HasMaxLength(200);

                    b.Property<string>("HomeCity")
                        .HasMaxLength(100);

                    b.Property<int>("HomeCountry_fk");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(20);

                    b.Property<int>("HomeState_fk");

                    b.Property<string>("HomeZip")
                        .HasMaxLength(20);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsMailingSame");

                    b.Property<int?>("MailCountry_fk");

                    b.Property<string>("MailingAddress1")
                        .HasMaxLength(200);

                    b.Property<string>("MailingAddress2")
                        .HasMaxLength(200);

                    b.Property<string>("MailingCity")
                        .HasMaxLength(100);

                    b.Property<string>("MailingPhone")
                        .HasMaxLength(20);

                    b.Property<int?>("MailingState_fk");

                    b.Property<string>("MailingZip")
                        .HasMaxLength(20);

                    b.Property<int>("PatientID_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("HomeCountry_fk");

                    b.HasIndex("HomeState_fk");

                    b.HasIndex("MailCountry_fk");

                    b.HasIndex("MailingState_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientAddress");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDocuments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientDocumentId");

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("DocumentName")
                        .HasMaxLength(100);

                    b.Property<string>("DocumentNumber")
                        .HasMaxLength(50);

                    b.Property<int?>("DocumentType_fk");

                    b.Property<DateTime?>("Expiration");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsVerified");

                    b.Property<int>("PatientID_fk");

                    b.Property<int?>("State_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UploadPath");

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

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Employer")
                        .HasMaxLength(100);

                    b.Property<int?>("EmploymentStatus_fk");

                    b.Property<bool?>("IsVerified");

                    b.Property<int?>("Occupation_fk");

                    b.Property<int>("PatientID_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("WorkPhone")
                        .HasMaxLength(20);

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

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("GuardianAddress1")
                        .HasMaxLength(500);

                    b.Property<string>("GuardianAddress2")
                        .HasMaxLength(500);

                    b.Property<string>("GuardianCity")
                        .HasMaxLength(100);

                    b.Property<string>("GuardianEmail")
                        .HasMaxLength(256);

                    b.Property<string>("GuardianFirstName")
                        .HasMaxLength(100);

                    b.Property<string>("GuardianHomePhone")
                        .HasMaxLength(20);

                    b.Property<string>("GuardianLastName")
                        .HasMaxLength(100);

                    b.Property<string>("GuardianMiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("GuardianMobile")
                        .HasMaxLength(20);

                    b.Property<int?>("GuardianState_fk");

                    b.Property<string>("GuardianWorkPhone")
                        .HasMaxLength(20);

                    b.Property<string>("GuardianZip")
                        .HasMaxLength(10);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsVerified");

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

                    b.Property<DateTime?>("CardIssueDate");

                    b.Property<string>("CarrierPayerID")
                        .HasMaxLength(20);

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("InsuranceClaimOfficeNumber")
                        .HasMaxLength(20);

                    b.Property<string>("InsuranceCompanyAddress")
                        .HasMaxLength(500);

                    b.Property<int>("InsuranceCompany_fk");

                    b.Property<string>("InsuranceGroupName")
                        .HasMaxLength(100);

                    b.Property<string>("InsuranceIDNumber")
                        .HasMaxLength(20);

                    b.Property<bool?>("InsurancePersonSameAsPatient");

                    b.Property<string>("InsurancePhotoPathBack");

                    b.Property<string>("InsurancePhotoPathFront");

                    b.Property<string>("InsurancePhotoPathThumbBack");

                    b.Property<string>("InsurancePhotoPathThumbFront");

                    b.Property<string>("InsurancePlanName")
                        .HasMaxLength(100);

                    b.Property<int?>("InsurancePlanType_fk");

                    b.Property<int?>("InsuranceType_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsVerified");

                    b.Property<string>("Notes")
                        .HasMaxLength(500);

                    b.Property<int>("PatientID_fk");

                    b.Property<string>("TPLCode")
                        .HasMaxLength(20);

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("VisitsAllowedPerYear");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("InsuranceCompany_fk");

                    b.HasIndex("InsurancePlanType_fk");

                    b.HasIndex("InsuranceType_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientInsuranceDetails");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientPreferenceID");

                    b.Property<bool?>("AddClientToCaseLoad");

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsVerified");

                    b.Property<int?>("PatientHomeCommPreferences_fk");

                    b.Property<int>("PatientID_fk");

                    b.Property<int?>("PatientOfficeCommPreferences_fk");

                    b.Property<int?>("PreferredLanguage_fk");

                    b.Property<DateTime?>("ProgramStartDate");

                    b.Property<int?>("Program_fk");

                    b.Property<bool?>("ReceiveSMS");

                    b.Property<DateTime?>("ReferralDate");

                    b.Property<string>("ReferralReason");

                    b.Property<int?>("Referral_fk");

                    b.Property<int?>("ServiceRequested_fk");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("PatientHomeCommPreferences_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("PatientOfficeCommPreferences_fk");

                    b.HasIndex("PreferredLanguage_fk");

                    b.HasIndex("Program_fk");

                    b.HasIndex("Referral_fk");

                    b.HasIndex("ServiceRequested_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientPreference");
                });

            modelBuilder.Entity("HC.Patient.Entity.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientID");

                    b.Property<int?>("Citizenship_fk");

                    b.Property<int>("ClientStatus_fk");

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("EmergencyContactFirstName")
                        .HasMaxLength(100);

                    b.Property<string>("EmergencyContactLastName")
                        .HasMaxLength(100);

                    b.Property<string>("EmergencyContactPhone")
                        .HasMaxLength(20);

                    b.Property<int?>("EmergencyContactRelationship_fk");

                    b.Property<int?>("Ethnicity_fk");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<int>("Gender_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<string>("MRN")
                        .HasMaxLength(50);

                    b.Property<int?>("MaritalStatus_fk");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath");

                    b.Property<string>("PhotoThumbnailPath");

                    b.Property<int?>("PrimaryProvider_fk");

                    b.Property<int>("Race_fk");

                    b.Property<string>("SSN")
                        .HasMaxLength(20);

                    b.Property<int?>("SecondaryRace_fk");

                    b.Property<int?>("Suffix_fk");

                    b.Property<string>("Title")
                        .HasMaxLength(10);

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("Citizenship_fk");

                    b.HasIndex("ClientStatus_fk");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("EmergencyContactRelationship_fk");

                    b.HasIndex("Ethnicity_fk");

                    b.HasIndex("Gender_fk");

                    b.HasIndex("MaritalStatus_fk");

                    b.HasIndex("PrimaryProvider_fk");

                    b.HasIndex("Race_fk");

                    b.HasIndex("SecondaryRace_fk");

                    b.HasIndex("Suffix_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientVitals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientVitalId");

                    b.Property<double>("BMI");

                    b.Property<string>("BMI_Status");

                    b.Property<int>("BP_diastolic");

                    b.Property<int>("BP_systolic");

                    b.Property<int?>("CreatedBy_fk");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<int>("EncounterID_fk");

                    b.Property<bool>("FollowUp");

                    b.Property<string>("HeartRate");

                    b.Property<double>("Height_cm");

                    b.Property<double>("Height_ft");

                    b.Property<double>("Height_in");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("PatientID_fk");

                    b.Property<int>("Pulse");

                    b.Property<int>("Respiration");

                    b.Property<int?>("UpdatedBy_fk");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<double>("Weight_kg");

                    b.Property<double>("Weight_lbs");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("DeletedBy_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientVitals");
                });

            modelBuilder.Entity("HC.Patient.Entity.PhoneNumbers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PhoneNumberId");

                    b.Property<int?>("DeletedBy_fk");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("PatientID_fk");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20);

                    b.Property<int>("PhoneNumberTypeId_fk");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.HasIndex("PatientID_fk");

                    b.HasIndex("PhoneNumberTypeId_fk");

                    b.ToTable("PhoneNumbers");
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

                    b.Property<int?>("ProviderPhone_fk");

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy_fk");

                    b.HasIndex("ProviderPhone_fk");

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

            modelBuilder.Entity("HC.Patient.Entity.InsuranceCompanies", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterCountry", b =>
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

            modelBuilder.Entity("HC.Patient.Entity.MasterOccupation", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPatientCommPreferences", b =>
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

            modelBuilder.Entity("HC.Patient.Entity.MasterProgram", b =>
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

            modelBuilder.Entity("HC.Patient.Entity.MasterReferral", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterService", b =>
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

            modelBuilder.Entity("HC.Patient.Entity.PatientAddress", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry")
                        .WithMany()
                        .HasForeignKey("HomeCountry_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("HomeState_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry1")
                        .WithMany()
                        .HasForeignKey("MailCountry_fk");

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState1")
                        .WithMany()
                        .HasForeignKey("MailingState_fk");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientAddress")
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDocuments", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("DocumentType_fk");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("State_fk");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEmploymentDetail", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("EmploymentStatus_fk");

                    b.HasOne("HC.Patient.Entity.MasterOccupation", "MasterOccupation")
                        .WithMany()
                        .HasForeignKey("Occupation_fk");

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
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("GuardianState_fk");

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
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.InsuranceCompanies", "InsuranceCompanies")
                        .WithMany()
                        .HasForeignKey("InsuranceCompany_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("InsurancePlanType_fk");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType1")
                        .WithMany()
                        .HasForeignKey("InsuranceType_fk");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientInsuranceDetails")
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientPreference", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.MasterPatientCommPreferences", "MasterPatientCommPreferences")
                        .WithMany()
                        .HasForeignKey("PatientHomeCommPreferences_fk");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientPreference")
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterPatientCommPreferences", "MasterPatientCommPreferences1")
                        .WithMany()
                        .HasForeignKey("PatientOfficeCommPreferences_fk");

                    b.HasOne("HC.Patient.Entity.MasterPreferredLanguage", "MasterPreferredLanguage")
                        .WithMany()
                        .HasForeignKey("PreferredLanguage_fk");

                    b.HasOne("HC.Patient.Entity.MasterProgram", "MasterProgram")
                        .WithMany()
                        .HasForeignKey("Program_fk");

                    b.HasOne("HC.Patient.Entity.MasterReferral", "MasterReferral")
                        .WithMany()
                        .HasForeignKey("Referral_fk");

                    b.HasOne("HC.Patient.Entity.MasterService", "MasterService")
                        .WithMany()
                        .HasForeignKey("ServiceRequested_fk");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.Patients", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry")
                        .WithMany()
                        .HasForeignKey("Citizenship_fk");

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus1")
                        .WithMany()
                        .HasForeignKey("ClientStatus_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType1")
                        .WithMany()
                        .HasForeignKey("EmergencyContactRelationship_fk");

                    b.HasOne("HC.Patient.Entity.MasterEthnicity", "MasterEthnicity")
                        .WithMany()
                        .HasForeignKey("Ethnicity_fk");

                    b.HasOne("HC.Patient.Entity.MasterGender", "MasterGender")
                        .WithMany()
                        .HasForeignKey("Gender_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatus_fk");

                    b.HasOne("HC.Patient.Entity.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("PrimaryProvider_fk");

                    b.HasOne("HC.Patient.Entity.MasterRace", "MasterRace")
                        .WithMany()
                        .HasForeignKey("Race_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRace", "SecondaryRace")
                        .WithMany()
                        .HasForeignKey("SecondaryRace_fk");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("Suffix_fk");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientVitals", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk");

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk");
                });

            modelBuilder.Entity("HC.Patient.Entity.PhoneNumbers", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("PatientID_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("PhoneNumberTypeId_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HC.Patient.Entity.Provider", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy_fk");

                    b.HasOne("HC.Patient.Entity.PhoneNumbers", "PhoneNumbers")
                        .WithMany()
                        .HasForeignKey("ProviderPhone_fk");
                });
        }
    }
}
