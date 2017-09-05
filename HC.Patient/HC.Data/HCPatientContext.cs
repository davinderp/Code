using Microsoft.EntityFrameworkCore;
using HC.Patient.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Infrastructure;
using JsonApiDotNetCore.Models;
using HC.Patient.Model.MasterData;

namespace HC.Patient.Data
{
    public class HCPatientContext : DbContext
    {
        /// <summary>
        /// Db context for Patient module
        /// </summary>
        /// <param name="options"></param>
        public HCPatientContext(DbContextOptions<HCPatientContext> options) : base(options) { }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<MasterCountry> MasterCountry { get; set; }
        public DbSet<MasterEthnicity> MasterEthnicity { get; set; }
        public DbSet<MasterFundingSource> MasterFundingSource { get; set; }
        public DbSet<MasterPreferredLanguage> MasterPreferredLanguage { get; set; }

        [Resource("master-race")]
        public DbSet<MasterRace> MasterRace { get; set; }
        public DbSet<MasterState> MasterState { get; set; }
        public DbSet<MasterStatus> MasterStatus { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MasterOccupation> MasterOccupation { get; set; }
        public DbSet<PatientDocuments> PatientDocuments { get; set; }
        public DbSet<PatientEmploymentDetail> PatientEmploymentDetail { get; set; }
        public DbSet<PatientGuardian> PatientGuardian { get; set; }
        public DbSet<PatientInsuranceDetails> PatientInsuranceDetails { get; set; }
        public DbSet<PatientAddress> PatientAddress { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<PatientPreference> PatientPreference { get; set; }
        public DbSet<InsuranceCompanies> InsuranceCompanies { get; set; }
        public DbSet<MasterProgram> MasterProgram { get; set; }
        public DbSet<MasterReferral> MasterReferral { get; set; }
        public DbSet<MasterService> MasterService { get; set; }
        public DbSet<MasterType> MasterType { get; set; }
        public DbSet<MasterPatientCommPreferences> MasterPatientCommPreferences { get; set; }
        public DbSet<MasterGender> MasterGender { get; set; }
        public DbSet<PhoneNumbers> PhoneNumbers { get; set; }
        public DbSet<PatientVitals> PatientVitals { get; set; }
        public DbSet<MasterICD> MasterICD { get; set; }
        public DbSet<MasterCPT> MasterCPT { get; set; }
        public DbSet<MasterLocation> MasterLocation { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnosis { get; set; }
        public DbSet<PatientEncounter> PatientEncounter { get; set; }
        public DbSet<PatientMedicalFamilyHistory> PatientMedicalFamilyHistory { get; set; }

        public DbSet<MasterVFCEligibility> MasterVFCEligibility { get; set; }
        public DbSet<MasterImmunization> MasterImmunization { get; set; }
        public DbSet<MasterManufacture> MasterManufacture { get; set; }
        public DbSet<MasterAdministrationSite> MasterAdministrationSite { get; set; }
        public DbSet<MasterRouteOfAdministration> MasterRouteOfAdministration { get; set; }
        public DbSet<MasterImmunityStatus> MasterImmunityStatus { get; set; }
        public DbSet<MasterRejectionReason> MasterRejectionReason { get; set; }
        public DbSet<PatientImmunization> PatientImmunization { get; set; }
        public DbSet<PatientSocialHistory> PatientSocialHistory { get; set; }
        public DbSet<MasterRelationship> MasterRelationship { get; set; }
        public DbSet<PatientPastIllness> PatientPastIllness { get; set; }
        public DbSet<MasterLonic> MasterLonic { get; set; }
        public DbSet<PatientLabTest> PatientLabTest { get; set; }
        public DbSet<MasterLabs> MasterLabs { get; set; }

        public DbSet<Clinicians> Clinicians { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<AppointmentType> AppointmentType { get; set; }
        public DbSet<PatientAppointment> PatientAppointment { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<OrganizationConnectionstring> OrganizationConnectionstring { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<AuditLogs> AuditLogs { get; set; }
        public DbSet<Encounter_CPT> Encounter_CPT { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Authorization> Authorization { get; set; }
        public DbSet<AuthorizationProcedures> AuthorizationProcedures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppointmentType>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<AppointmentType>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<AppointmentType>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);
            //

            modelBuilder.Entity<AuditLogs>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<AuditLogs>()
           .Property(b => b.CreatedDate)
           .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<AuditLogs>()
            .Property(b => b.OrganizationID)
            .HasDefaultValue(1);

            //modelBuilder.Entity<AuditLogs>()
            //.Property(b => b.EventID)
            //.HasDefaultValue(this.Event.LastOrDefaultAsync().Id + 1);
            //

            modelBuilder.Entity<Clinicians>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<Clinicians>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<Clinicians>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //InsuranceCompanies
            modelBuilder.Entity<InsuranceCompanies>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<InsuranceCompanies>()
           .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<InsuranceCompanies>()
            .Property(b => b.OrganizationID)
            .HasDefaultValue(1);

            modelBuilder.Entity<InsuranceCompanies>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //Location
            modelBuilder.Entity<Location>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<Location>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<Location>()
           .Property(b => b.IsActive)
           .HasDefaultValue(true);

            //MasterAdministrationSite
            modelBuilder.Entity<MasterAdministrationSite>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterAdministrationSite>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterAdministrationSite>()
           .Property(b => b.IsActive)
           .HasDefaultValue(true);

            //MasterCountry
            modelBuilder.Entity<MasterCountry>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterCountry>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");            

            //MasterLocation
            modelBuilder.Entity<MasterLocation>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterLocation>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterLocation>()
           .Property(b => b.IsActive)
           .HasDefaultValue(true);

            //MasterCPT
            modelBuilder.Entity<MasterCPT>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterCPT>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterEthnicity
            modelBuilder.Entity<MasterEthnicity>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterEthnicity>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            //MasterFundingSource
            modelBuilder.Entity<MasterFundingSource>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterFundingSource>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            //MasterGender
            modelBuilder.Entity<MasterGender>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterGender>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterICD
            modelBuilder.Entity<MasterICD>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterICD>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterImmunityStatus
            modelBuilder.Entity<MasterImmunityStatus>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterImmunityStatus>()
            .Property(b => b.IsDeleted)
           .HasDefaultValue(false);

            //MasterImmunization
            modelBuilder.Entity<MasterImmunization>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterImmunization>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterImmunization
            modelBuilder.Entity<MasterLabs>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterLabs>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterLonic
            modelBuilder.Entity<MasterLonic>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterLonic>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterManufacture
            modelBuilder.Entity<MasterManufacture>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterManufacture>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterOccupation
            modelBuilder.Entity<MasterOccupation>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterOccupation>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterPatientCommPreferences
            modelBuilder.Entity<MasterPatientCommPreferences>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterPatientCommPreferences>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterPreferredLanguage
            modelBuilder.Entity<MasterPreferredLanguage>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterPreferredLanguage>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            //MasterProgram
            modelBuilder.Entity<MasterProgram>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterProgram>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterRace
            modelBuilder.Entity<MasterRace>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterRace>()
           .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            //MasterReferral
            modelBuilder.Entity<MasterReferral>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterReferral>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterRejectionReason
            modelBuilder.Entity<MasterRejectionReason>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterRejectionReason>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterRelationship
            modelBuilder.Entity<MasterRelationship>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterRelationship>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterRouteOfAdministration
            modelBuilder.Entity<MasterRouteOfAdministration>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterRouteOfAdministration>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterService
            modelBuilder.Entity<MasterService>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterService>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterState
            modelBuilder.Entity<MasterState>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<MasterState>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            //MasterType
            modelBuilder.Entity<MasterType>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterType>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //MasterVFCEligibility
            modelBuilder.Entity<MasterVFCEligibility>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<MasterVFCEligibility>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //Organization
            modelBuilder.Entity<Organization>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<Organization>()
           .Property(b => b.CreatedDate)
           .HasDefaultValueSql("GetDate()");

            //OrganizationConnectionstring
            modelBuilder.Entity<OrganizationConnectionstring>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<OrganizationConnectionstring>()
           .Property(b => b.CreatedDate)
           .HasDefaultValueSql("GetDate()");

            //PatientAddress
            modelBuilder.Entity<PatientAddress>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientAddress>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientAddress>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientAppointment
            modelBuilder.Entity<PatientAppointment>()
           .Property(b => b.IsDeleted)
           .HasDefaultValue(false);

            modelBuilder.Entity<PatientAppointment>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            modelBuilder.Entity<PatientAppointment>()
           .Property(b => b.CreatedDate)
           .HasDefaultValueSql("GetDate()");

            //PatientDiagnosis
            modelBuilder.Entity<PatientDiagnosis>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientDiagnosis>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientDiagnosis>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientDocuments
            modelBuilder.Entity<PatientDocuments>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientDocuments>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientDocuments>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientEmploymentDetail
            modelBuilder.Entity<PatientEmploymentDetail>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientEmploymentDetail>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            //PatientEncounter
            modelBuilder.Entity<PatientEncounter>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientEncounter>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientEncounter>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientGuardian
            modelBuilder.Entity<PatientGuardian>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientGuardian>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientGuardian>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientImmunization
            modelBuilder.Entity<PatientImmunization>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientImmunization>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientImmunization>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientInsuranceDetails
            modelBuilder.Entity<PatientInsuranceDetails>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientInsuranceDetails>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientInsuranceDetails>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientLabTest
            modelBuilder.Entity<PatientLabTest>()
           .Property(b => b.IsDeleted)
           .HasDefaultValue(false);

            modelBuilder.Entity<PatientLabTest>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientLabTest>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientMedicalFamilyHistory
            modelBuilder.Entity<PatientMedicalFamilyHistory>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientMedicalFamilyHistory>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientMedicalFamilyHistory>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientPastIllness
            modelBuilder.Entity<PatientPastIllness>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientPastIllness>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientPastIllness>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientPreference
            modelBuilder.Entity<PatientPreference>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientPreference>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientPreference>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //Patients
            modelBuilder.Entity<Patients>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<Patients>()
            .Property(b => b.ClientStatus)
            .HasDefaultValue(2);//2 is for Active Status

            modelBuilder.Entity<Patients>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<Patients>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            modelBuilder.Entity<Patients>()
            .Property(b => b.OrganizationID)
            .HasDefaultValue(1);

            //PatientSocialHistory
            modelBuilder.Entity<PatientSocialHistory>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientSocialHistory>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientSocialHistory>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //PatientVitals
            modelBuilder.Entity<PatientVitals>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PatientVitals>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PatientVitals>()
           .Property(b => b.IsActive)
           .HasDefaultValue(true);

            //PhoneNumbers
            modelBuilder.Entity<PhoneNumbers>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<PhoneNumbers>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<PhoneNumbers>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            //Provider
            modelBuilder.Entity<Provider>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<Provider>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<Provider>()
           .Property(b => b.IsActive)
           .HasDefaultValue(true);

            modelBuilder.Entity<Provider>()
            .Property(b => b.OrganizationID)
            .HasDefaultValue(1);

            //User
            modelBuilder.Entity<User>()
            .Property(b => b.CreatedDate)
            .HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<User>()
            .Property(b => b.IsDeleted)
            .HasDefaultValue(false);

            modelBuilder.Entity<User>()
            .Property(b => b.IsActive)
            .HasDefaultValue(true);

            modelBuilder.Entity<User>()
            .Property(b => b.OrganizationID)
            .HasDefaultValue(1);

            //UserRoles
            modelBuilder.Entity<UserRoles>()
            .Property(b => b.OrganizationID)
            .HasDefaultValue(1);
            //------------------//
        }
    }
}
