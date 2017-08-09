using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HC.Patient.Data;

namespace HC.Patient.Web.Migrations
{
    [DbContext(typeof(HCPatientContext))]
    [Migration("20170809114916_migration73")]
    partial class migration73
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HC.Patient.Entity.AppointmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AppointmentTypeID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("AppointmentType");
                });

            modelBuilder.Entity("HC.Patient.Entity.Clinicians", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ClinicianID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy")
                        .IsRequired();

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("OrganizationID");

                    b.Property<int>("ProviderId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("ProviderId");

                    b.ToTable("Clinicians");
                });

            modelBuilder.Entity("HC.Patient.Entity.InsuranceCompanies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InsuranceCompanyId");

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyEmail");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyPhone");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("InsuranceCompanies");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterAdministrationSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AdministrationSiteID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<string>("HL7");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("SNOMED")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterAdministrationSite");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CountryID");

                    b.Property<string>("CountryName");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterCountry");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterCPT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CPTID");

                    b.Property<string>("CPTCode");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterCPT");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterEthnicity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EthnicityID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("EthnicityName");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterEthnicity");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterFundingSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FundingSourceID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FundingSource");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterFundingSource");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GenderID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterGender");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterICD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ICDID");

                    b.Property<string>("Code");

                    b.Property<string>("CodeType");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterICD");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterImmunityStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ImmunityStatusID");

                    b.Property<string>("ConceptCode")
                        .HasMaxLength(10);

                    b.Property<string>("ConceptName");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Defination")
                        .HasMaxLength(300);

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("HL7Code")
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int?>("NIP004");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterImmunityStatus");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterImmunization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ImmunizationID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("CvxCode")
                        .HasMaxLength(50);

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int?>("InternalID");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool?>("NonVaccine");

                    b.Property<string>("Note");

                    b.Property<string>("ShortDesc")
                        .HasMaxLength(50);

                    b.Property<string>("VaccineName");

                    b.Property<string>("VaccineStatus")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterImmunization");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterLabs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LabID");

                    b.Property<string>("Address1")
                        .HasMaxLength(500);

                    b.Property<string>("Address2")
                        .HasMaxLength(500);

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("LabName")
                        .HasMaxLength(100);

                    b.Property<string>("LabPhone")
                        .HasMaxLength(20);

                    b.Property<int>("StateID");

                    b.Property<string>("Zip")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("StateID");

                    b.ToTable("MasterLabs");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LocationID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Location");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterLocation");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterLonic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LonicID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("LonicCode");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterLonic");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterManufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ManufactureID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("MVXCode")
                        .HasMaxLength(50);

                    b.Property<string>("ManufacturerName")
                        .HasMaxLength(500);

                    b.Property<int>("Notes");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterManufacture");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterOccupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OccupationID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("OccupationName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterOccupation");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPatientCommPreferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientCommPreferencesID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("PatientCommPreferences");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterPatientCommPreferences");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPreferredLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LanguageID");

                    b.Property<string>("Code");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Language");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterPreferredLanguage");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProgramID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ProgramName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterProgram");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RaceID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("RaceName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterRace");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterReferral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReferralID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ReferralName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterReferral");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRejectionReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RejectionReasonID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ReasonCode")
                        .HasMaxLength(5);

                    b.Property<string>("ReasonDesc")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterRejectionReason");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RelationshipID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("RelationshipName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterRelationship");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRouteOfAdministration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RouteOfAdministrationID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Definition")
                        .HasMaxLength(500);

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("FDANCI")
                        .HasMaxLength(10);

                    b.Property<string>("HL7")
                        .HasMaxLength(10);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterRouteOfAdministration");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ServiceID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ServiceName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterService");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StateID");

                    b.Property<int?>("CountryID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("StateAbbr")
                        .HasMaxLength(2);

                    b.Property<string>("StateName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterState");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StatusID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("StatusName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterStatus");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypeID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Type");

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterType");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterVFCEligibility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VFCID");

                    b.Property<string>("ConceptCode")
                        .HasMaxLength(10);

                    b.Property<string>("ConceptName");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("MasterVFCEligibility");
                });

            modelBuilder.Entity("HC.Patient.Entity.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrganizationID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("OrganizationDescription")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AddressID");

                    b.Property<string>("Address1")
                        .HasMaxLength(200);

                    b.Property<string>("Address2")
                        .HasMaxLength(200);

                    b.Property<int?>("AddressTypeID");

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<int>("CountryID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsMailingSame");

                    b.Property<int>("PatientID");

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<int>("StateID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("Zip")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("AddressTypeID");

                    b.HasIndex("CountryID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("StateID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientAddress");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientAppointmentId");

                    b.Property<int>("AppointmentTypeID");

                    b.Property<int>("ClinicianID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("EndDateTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("PatientID");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentTypeID");

                    b.HasIndex("ClinicianID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientAppointment");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDiagnosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientDiagnosisId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("ICDID");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PatientID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("ICDID");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientDiagnosis");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDocuments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientDocumentId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("DocumentName")
                        .HasMaxLength(100);

                    b.Property<string>("DocumentNumber")
                        .HasMaxLength(50);

                    b.Property<int?>("DocumentType");

                    b.Property<DateTime?>("Expiration");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsVerified");

                    b.Property<int>("PatientID");

                    b.Property<int?>("State");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UploadPath");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DocumentType");

                    b.HasIndex("PatientID");

                    b.HasIndex("State");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientDocuments");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEmploymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientEmplomentID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Employer")
                        .HasMaxLength(100);

                    b.Property<int?>("EmploymentStatus");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsVerified");

                    b.Property<int?>("Occupation");

                    b.Property<int>("PatientID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("WorkPhone")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("EmploymentStatus");

                    b.HasIndex("Occupation");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientEmploymentDetail");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEncounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientEncounterId");

                    b.Property<string>("Assessment");

                    b.Property<int>("CPTID");

                    b.Property<int>("ClinicianID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("LocationID");

                    b.Property<string>("Objective");

                    b.Property<int>("PatientID");

                    b.Property<string>("Plans");

                    b.Property<string>("Subjective");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<DateTime>("VisitDateTime");

                    b.HasKey("Id");

                    b.HasIndex("CPTID");

                    b.HasIndex("ClinicianID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("LocationID");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientEncounter");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientGuardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuardianId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

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

                    b.Property<int?>("GuardianState");

                    b.Property<string>("GuardianWorkPhone")
                        .HasMaxLength(20);

                    b.Property<string>("GuardianZip")
                        .HasMaxLength(10);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsVerified");

                    b.Property<int>("PatientID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("GuardianState");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientGuardian");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientImmunization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ImmunizationId");

                    b.Property<int?>("AdministeredBy");

                    b.Property<DateTime>("AdministeredDate");

                    b.Property<int?>("AdministrationSiteID");

                    b.Property<int?>("AmountAdministered");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<int>("ImmunityStatusID");

                    b.Property<int>("Immunization");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int?>("ManufactureID");

                    b.Property<int?>("OrderBy");

                    b.Property<int>("PatientID");

                    b.Property<bool>("RejectedImmunization");

                    b.Property<int?>("RejectionReasonID");

                    b.Property<int?>("RouteOfAdministrationID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("VFCID");

                    b.Property<string>("VaccineLotNumber");

                    b.HasKey("Id");

                    b.HasIndex("AdministeredBy");

                    b.HasIndex("AdministrationSiteID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("ImmunityStatusID");

                    b.HasIndex("Immunization");

                    b.HasIndex("ManufactureID");

                    b.HasIndex("OrderBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("RejectionReasonID");

                    b.HasIndex("RouteOfAdministrationID");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("VFCID");

                    b.ToTable("PatientImmunization");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientInsuranceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientInsuranceID");

                    b.Property<DateTime?>("CardIssueDate");

                    b.Property<string>("CarrierPayerID")
                        .HasMaxLength(20);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("InsuranceClaimOfficeNumber")
                        .HasMaxLength(20);

                    b.Property<string>("InsuranceCompanyAddress")
                        .HasMaxLength(500);

                    b.Property<int>("InsuranceCompanyID");

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

                    b.Property<int?>("InsurancePlanTypeID");

                    b.Property<int?>("InsuranceTypeID");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsVerified");

                    b.Property<string>("Notes")
                        .HasMaxLength(500);

                    b.Property<int>("PatientID");

                    b.Property<string>("TPLCode")
                        .HasMaxLength(20);

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("VisitsAllowedPerYear");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("InsuranceCompanyID");

                    b.HasIndex("InsurancePlanTypeID");

                    b.HasIndex("InsuranceTypeID");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientInsuranceDetails");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientLabTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TestId");

                    b.Property<string>("ConditionOfSpecimen")
                        .HasMaxLength(200);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("FrequencyDuration")
                        .HasMaxLength(100);

                    b.Property<int>("FrequencyDurationID");

                    b.Property<int>("FrequencyID");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LabName");

                    b.Property<int>("LonicCodeID");

                    b.Property<string>("Notes");

                    b.Property<int?>("OrderBy");

                    b.Property<DateTime>("OrderDate");

                    b.Property<bool>("Ordered");

                    b.Property<int>("PatientID");

                    b.Property<DateTime>("ScheduledDate");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("TestSpecimenSource")
                        .HasMaxLength(200);

                    b.Property<int>("TestTypeID");

                    b.Property<int>("TimeTypeID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("FrequencyDurationID");

                    b.HasIndex("FrequencyID");

                    b.HasIndex("LabName");

                    b.HasIndex("LonicCodeID");

                    b.HasIndex("OrderBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("TestTypeID");

                    b.HasIndex("TimeTypeID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientLabTest");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientMedicalFamilyHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MedicalFamilyHistoryId");

                    b.Property<int?>("AgeOfDiagnosis");

                    b.Property<string>("CauseOfDeath");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("DOB");

                    b.Property<DateTime?>("DateOfDeath");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("DiseaseID");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("GenderID");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Observation");

                    b.Property<int>("PatientID");

                    b.Property<int>("RelationshipID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("DiseaseID");

                    b.HasIndex("GenderID");

                    b.HasIndex("PatientID");

                    b.HasIndex("RelationshipID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientMedicalFamilyHistory");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientPastIllness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PastIllnessId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<DateTime>("DiagnosisDate");

                    b.Property<string>("Illness")
                        .HasMaxLength(300);

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PatientID");

                    b.Property<int>("StatusID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("StatusID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientPastIllness");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientPreferenceID");

                    b.Property<bool?>("AddClientToCaseLoad");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int?>("PatientHomeCommPreferencesID");

                    b.Property<int>("PatientID");

                    b.Property<int?>("PatientOfficeCommPreferencesID");

                    b.Property<int?>("PreferredLanguageID");

                    b.Property<bool?>("ReceiveSMS");

                    b.Property<int?>("ServiceRequestedID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("PatientHomeCommPreferencesID");

                    b.HasIndex("PatientID");

                    b.HasIndex("PatientOfficeCommPreferencesID");

                    b.HasIndex("PreferredLanguageID");

                    b.HasIndex("ServiceRequestedID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientPreference");
                });

            modelBuilder.Entity("HC.Patient.Entity.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientID");

                    b.Property<int?>("Citizenship");

                    b.Property<int>("ClientStatus");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("DOB");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("EmergencyContactFirstName")
                        .HasMaxLength(100);

                    b.Property<string>("EmergencyContactLastName")
                        .HasMaxLength(100);

                    b.Property<string>("EmergencyContactPhone")
                        .HasMaxLength(20);

                    b.Property<int?>("EmergencyContactRelationship");

                    b.Property<int?>("Ethnicity");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("IsVerified");

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<string>("MRN")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("MaritalStatus");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath");

                    b.Property<string>("PhotoThumbnailPath");

                    b.Property<int?>("PrimaryClinician");

                    b.Property<int?>("Program");

                    b.Property<DateTime?>("ProgramStartDate");

                    b.Property<int>("Race");

                    b.Property<int?>("Referral");

                    b.Property<DateTime?>("ReferralDate");

                    b.Property<string>("ReferralReason");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("SecondaryRace");

                    b.Property<int?>("SecondaryRace1Id");

                    b.Property<int?>("Suffix");

                    b.Property<string>("Title")
                        .HasMaxLength(10);

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("Citizenship");

                    b.HasIndex("ClientStatus");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("EmergencyContactRelationship");

                    b.HasIndex("Ethnicity");

                    b.HasIndex("Gender");

                    b.HasIndex("MaritalStatus");

                    b.HasIndex("PrimaryClinician");

                    b.HasIndex("Program");

                    b.HasIndex("Race");

                    b.HasIndex("Referral");

                    b.HasIndex("SecondaryRace1Id");

                    b.HasIndex("Suffix");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientSocialHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SocialHistoryId");

                    b.Property<int>("AlcohalID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("DrugID");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Occupation")
                        .HasMaxLength(300);

                    b.Property<int>("PatientID");

                    b.Property<int>("TobaccoID");

                    b.Property<int>("TravelID");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("AlcohalID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("DrugID");

                    b.HasIndex("PatientID");

                    b.HasIndex("TobaccoID");

                    b.HasIndex("TravelID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientSocialHistory");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientVitals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientVitalId");

                    b.Property<double>("BMI");

                    b.Property<int>("BPDiastolic");

                    b.Property<int>("BPSystolic");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("EncounterID");

                    b.Property<bool>("FollowUp");

                    b.Property<int>("HeartRate");

                    b.Property<double>("HeightFt");

                    b.Property<double>("HeightIn");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PatientID");

                    b.Property<int>("Pulse");

                    b.Property<int>("Respiration");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<double>("WeightLbs");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("PatientVitals");
                });

            modelBuilder.Entity("HC.Patient.Entity.PhoneNumbers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PhoneNumberId");

                    b.Property<int?>("ClinicianID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int?>("PatientID");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20);

                    b.Property<int>("PhoneNumberTypeId");

                    b.Property<int?>("ProviderId");

                    b.HasKey("Id");

                    b.HasIndex("ClinicianID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("PatientID");

                    b.HasIndex("PhoneNumberTypeId");

                    b.HasIndex("ProviderId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("HC.Patient.Entity.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProviderId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy")
                        .IsRequired();

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("ProviderAddress")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("ProviderEmail")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("HC.Patient.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Password");

                    b.Property<int>("RoleID");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("RoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HC.Patient.Entity.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleID");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("RoleName")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DeletedBy");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("HC.Patient.Entity.AppointmentType", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.Clinicians", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HC.Patient.Entity.InsuranceCompanies", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterAdministrationSite", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterCountry", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterCPT", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterEthnicity", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterFundingSource", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterGender", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterICD", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterImmunityStatus", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterImmunization", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterLabs", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterLocation", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterLonic", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterManufacture", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterOccupation", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPatientCommPreferences", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterPreferredLanguage", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterProgram", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRace", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterReferral", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRejectionReason", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRelationship", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterRouteOfAdministration", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterService", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterState", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry")
                        .WithMany()
                        .HasForeignKey("CountryID");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterStatus", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterType", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.MasterVFCEligibility", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.Organization", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientAddress", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterType", "MasterAddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeID");

                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientAddress")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientAppointment", b =>
                {
                    b.HasOne("HC.Patient.Entity.AppointmentType", "AppointmentType")
                        .WithMany()
                        .HasForeignKey("AppointmentTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Clinicians", "Clinician")
                        .WithMany()
                        .HasForeignKey("ClinicianID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDiagnosis", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterICD", "MasterICD")
                        .WithMany()
                        .HasForeignKey("ICDID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientDocuments", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("DocumentType");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("State");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEmploymentDetail", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("EmploymentStatus");

                    b.HasOne("HC.Patient.Entity.MasterOccupation", "MasterOccupation")
                        .WithMany()
                        .HasForeignKey("Occupation");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientEncounter", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterCPT", "MasterCPT")
                        .WithMany()
                        .HasForeignKey("CPTID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Clinicians", "Clinician")
                        .WithMany()
                        .HasForeignKey("ClinicianID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterLocation", "MasterLocation")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientGuardian", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("GuardianState");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientImmunization", b =>
                {
                    b.HasOne("HC.Patient.Entity.Clinicians", "Clinician1")
                        .WithMany()
                        .HasForeignKey("AdministeredBy");

                    b.HasOne("HC.Patient.Entity.MasterAdministrationSite", "MasterAdministrationSite")
                        .WithMany()
                        .HasForeignKey("AdministrationSiteID");

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterImmunityStatus", "MasterImmunityStatus")
                        .WithMany()
                        .HasForeignKey("ImmunityStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterImmunization", "MasterImmunization")
                        .WithMany()
                        .HasForeignKey("Immunization")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterManufacture", "MasterManufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureID");

                    b.HasOne("HC.Patient.Entity.Clinicians", "Clinician")
                        .WithMany()
                        .HasForeignKey("OrderBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRejectionReason", "MasterRejectionReason")
                        .WithMany()
                        .HasForeignKey("RejectionReasonID");

                    b.HasOne("HC.Patient.Entity.MasterRouteOfAdministration", "MasterRouteOfAdministration")
                        .WithMany()
                        .HasForeignKey("RouteOfAdministrationID");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.HasOne("HC.Patient.Entity.MasterVFCEligibility", "MasterVFCEligibility")
                        .WithMany()
                        .HasForeignKey("VFCID");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientInsuranceDetails", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.InsuranceCompanies", "InsuranceCompanies")
                        .WithMany()
                        .HasForeignKey("InsuranceCompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("InsurancePlanTypeID");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType1")
                        .WithMany()
                        .HasForeignKey("InsuranceTypeID");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientInsuranceDetails")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientLabTest", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterDurationType")
                        .WithMany()
                        .HasForeignKey("FrequencyDurationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterFrequencyType")
                        .WithMany()
                        .HasForeignKey("FrequencyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterLabs", "MasterLabs")
                        .WithMany()
                        .HasForeignKey("LabName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterLonic", "MasterLonic")
                        .WithMany()
                        .HasForeignKey("LonicCodeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("OrderBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterTestType")
                        .WithMany()
                        .HasForeignKey("TestTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterTimeType")
                        .WithMany()
                        .HasForeignKey("TimeTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientMedicalFamilyHistory", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterICD", "MasterICD")
                        .WithMany()
                        .HasForeignKey("DiseaseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterGender", "MasterGender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientMedicalFamilyHistory")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRelationship", "MasterRelationship")
                        .WithMany()
                        .HasForeignKey("RelationshipID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientPastIllness", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientPreference", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterPatientCommPreferences", "MasterPatientCommPreferences")
                        .WithMany()
                        .HasForeignKey("PatientHomeCommPreferencesID");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PatientPreference")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterPatientCommPreferences", "MasterPatientCommPreferences1")
                        .WithMany()
                        .HasForeignKey("PatientOfficeCommPreferencesID");

                    b.HasOne("HC.Patient.Entity.MasterPreferredLanguage", "MasterPreferredLanguage")
                        .WithMany()
                        .HasForeignKey("PreferredLanguageID");

                    b.HasOne("HC.Patient.Entity.MasterService", "MasterService")
                        .WithMany()
                        .HasForeignKey("ServiceRequestedID");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.Patients", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry")
                        .WithMany()
                        .HasForeignKey("Citizenship");

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus1")
                        .WithMany()
                        .HasForeignKey("ClientStatus")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType1")
                        .WithMany()
                        .HasForeignKey("EmergencyContactRelationship");

                    b.HasOne("HC.Patient.Entity.MasterEthnicity", "MasterEthnicity")
                        .WithMany()
                        .HasForeignKey("Ethnicity");

                    b.HasOne("HC.Patient.Entity.MasterGender", "MasterGender")
                        .WithMany()
                        .HasForeignKey("Gender")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatus");

                    b.HasOne("HC.Patient.Entity.Clinicians", "Clinician")
                        .WithMany()
                        .HasForeignKey("PrimaryClinician");

                    b.HasOne("HC.Patient.Entity.MasterProgram", "MasterProgram")
                        .WithMany()
                        .HasForeignKey("Program");

                    b.HasOne("HC.Patient.Entity.MasterRace", "MasterRace")
                        .WithMany()
                        .HasForeignKey("Race")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterReferral", "MasterReferral")
                        .WithMany()
                        .HasForeignKey("Referral");

                    b.HasOne("HC.Patient.Entity.MasterRace", "SecondaryRace1")
                        .WithMany()
                        .HasForeignKey("SecondaryRace1Id");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("Suffix");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientSocialHistory", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterType", "MasterAlcohal")
                        .WithMany()
                        .HasForeignKey("AlcohalID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterDrug")
                        .WithMany()
                        .HasForeignKey("DrugID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterTobacco")
                        .WithMany()
                        .HasForeignKey("TobaccoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterTravel")
                        .WithMany()
                        .HasForeignKey("TravelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PatientVitals", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users2")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("HC.Patient.Entity.PhoneNumbers", b =>
                {
                    b.HasOne("HC.Patient.Entity.Clinicians", "Clinician")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ClinicianID");

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.Patients", "Patient")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("PatientID");

                    b.HasOne("HC.Patient.Entity.MasterType", "MasterType")
                        .WithMany()
                        .HasForeignKey("PhoneNumberTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.Provider")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ProviderId");
                });

            modelBuilder.Entity("HC.Patient.Entity.Provider", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HC.Patient.Entity.User", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "User1")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("HC.Patient.Entity.UserRoles", "UserRoles")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HC.Patient.Entity.UserRoles", b =>
                {
                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("DeletedBy");
                });
        }
    }
}
