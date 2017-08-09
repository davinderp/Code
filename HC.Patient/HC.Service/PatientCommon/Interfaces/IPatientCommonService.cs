using HC.Patient.Entity;
using HC.Patient.Model.Vitals;
using HC.Service.Interfaces;

namespace HC.Patient.Service.PatientCommon.Interfaces
{
    public interface IPatientCommonService : IBaseService
    {
        Patients PatientExist(Patients patientInfo);
        Patients UpdatePatientData(int id,Patients patientInfo);
        PatientAddress UpdatePatientAddressData(int id, PatientAddress patientInfo);
        PatientInsuranceDetails UpdatePatientInsuranceData(int id, PatientInsuranceDetails patientInfo);
        PhoneNumbers UpdatePhoneNumbersData(int id, PhoneNumbers patientInfo);
        PatientPreference UpdatePatientPreferenceData(int id, PatientPreference patientInfo);
        PatientVitals UpdatePatientVitalseData(int id, PatientVitals patientInfo);
        bool UpdatePatientVitalsFollowUpData(Vitals followupVitals);
        bool UpdatePatientMedicalFamilyHistoryData(int id, PatientMedicalFamilyHistory patientInfo);
        PatientImmunization UpdatePatientImmunizationData(int id, PatientImmunization patientInfo);
        PatientSocialHistory UpdatePatientSocialHistoryData(int id, PatientSocialHistory patientInfo);
    }
}

