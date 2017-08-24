using HC.Patient.Entity;
using HC.Patient.Model.MasterData;
using HC.Patient.Model.Vitals;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Repositories.Interfaces
{
    public interface IPatientCommonRepository//: IRepository<MasterDataModel>
    {
        Patients PatientExist(Patients patientInfo);
        Patients UpdatePatientData(int id, Patients patientInfo);
        PatientAddress UpdatePatientAddressData(int id, PatientAddress patientInfo);
        PatientInsuranceDetails UpdatePatientInsuranceData(int id, PatientInsuranceDetails patientInfo);
        PhoneNumbers UpdatePhoneNumbersData(int id, PhoneNumbers patientInfo);
        PatientPreference UpdatePatientPreferenceData(int id, PatientPreference patientInfo);
        PatientVitals UpdatePatientVitalseData(int id, PatientVitals patientInfo);
        //bool UpdatePatientVitalsFollowUpData(Vitals followupVitals);
        bool UpdatePatientDiagnosisData(int id, PatientDiagnosis patientInfo);
        bool UpdatePatientEncounterData(int id, PatientEncounter patientInfo);
        bool UpdatePatientMedicalFamilyHistoryData(int id, PatientMedicalFamilyHistory patientInfo);
        PatientImmunization UpdatePatientImmunizationData(int id, PatientImmunization patientInfo);
        PatientSocialHistory UpdatePatientSocialHistoryData(int id, PatientSocialHistory patientInfo);
    }
}
