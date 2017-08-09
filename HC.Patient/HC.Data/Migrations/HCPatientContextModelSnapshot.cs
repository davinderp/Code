using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HC.Patient.Data;

namespace HC.Patient.Data.Migrations
{
    [DbContext(typeof(HCPatientContext))]
    partial class HCPatientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("HC.Patient.Entity.PatientBasicInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientID");

                    b.Property<int>("Citizenship_fk");

                    b.Property<int>("CreatedBy_fk");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DOB");

                    b.Property<DateTime>("DrivingLicenceExpiryDate");

                    b.Property<string>("DrivingLicenceNumber");

                    b.Property<string>("Email");

                    b.Property<string>("EmergencyContactName");

                    b.Property<string>("EmergencyContactPhone");

                    b.Property<string>("EmergencyContactRelationship");

                    b.Property<int>("Ethnicity_fk");

                    b.Property<string>("EyeColor");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("FundSourceEnd");

                    b.Property<DateTime>("FundSourceStart");

                    b.Property<int>("FundSource_fk");

                    b.Property<bool>("Gender");

                    b.Property<string>("HairColor");

                    b.Property<string>("HomeAddress1");

                    b.Property<string>("HomeAddress2");

                    b.Property<string>("HomeCity");

                    b.Property<string>("HomePhone");

                    b.Property<int>("HomeState_fk");

                    b.Property<string>("HomeZip");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("LastName");

                    b.Property<string>("MedicaidNum");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Notes");

                    b.Property<string>("PatientNo");

                    b.Property<int>("PreferredLanguage_fk");

                    b.Property<int>("Race_fk");

                    b.Property<bool>("ReceiveSMS");

                    b.Property<DateTime>("ReferralDate");

                    b.Property<string>("ReferralReason");

                    b.Property<string>("SSN");

                    b.Property<int>("SecondaryRace_fk");

                    b.Property<string>("Service");

                    b.Property<string>("Siblings");

                    b.Property<int>("Status_fk");

                    b.Property<int>("UpdatedBy_fk");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("Citizenship_fk");

                    b.HasIndex("CreatedBy_fk");

                    b.HasIndex("Ethnicity_fk");

                    b.HasIndex("FundSource_fk");

                    b.HasIndex("HomeState_fk");

                    b.HasIndex("PreferredLanguage_fk");

                    b.HasIndex("Race_fk");

                    b.HasIndex("SecondaryRace_fk");

                    b.HasIndex("Status_fk");

                    b.HasIndex("UpdatedBy_fk");

                    b.ToTable("PatientBasicInformation");
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

            modelBuilder.Entity("HC.Patient.Entity.PatientBasicInformation", b =>
                {
                    b.HasOne("HC.Patient.Entity.MasterCountry", "MasterCountry")
                        .WithMany()
                        .HasForeignKey("Citizenship_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("CreatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterEthnicity", "MasterEthnicity")
                        .WithMany()
                        .HasForeignKey("Ethnicity_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterFundingSource", "MasterFundingSource")
                        .WithMany()
                        .HasForeignKey("FundSource_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterState", "MasterState")
                        .WithMany()
                        .HasForeignKey("HomeState_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterPreferredLanguage", "MasterPreferredLanguage")
                        .WithMany()
                        .HasForeignKey("PreferredLanguage_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRace", "MasterRace")
                        .WithMany()
                        .HasForeignKey("Race_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterRace", "SecondaryRace")
                        .WithMany()
                        .HasForeignKey("SecondaryRace_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.MasterStatus", "MasterStatus")
                        .WithMany()
                        .HasForeignKey("Status_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HC.Patient.Entity.User", "Users1")
                        .WithMany()
                        .HasForeignKey("UpdatedBy_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
