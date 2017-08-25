using HC.Patient.Entity;
using HC.Patient.Model.Vitals;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Service.PatientCommon.Interfaces;

namespace HC.Patient.Service.PatientCommon
{
    public class PatientCommonService : IPatientCommonService
    {
        #region Global Variables
        private readonly IPatientCommonRepository _patientCommonRepository;
        #endregion
        public PatientCommonService(IPatientCommonRepository patientCommonRepository)
        {
            this._patientCommonRepository = patientCommonRepository;
        }
        public Patients PatientExist(Patients patientInfo)
        {
            return _patientCommonRepository.PatientExist(patientInfo);
        }
        public Patients UpdatePatientData(int id,Patients patientInfo)
        {
            return _patientCommonRepository.UpdatePatientData(id,patientInfo);
        }
        public PatientAddress UpdatePatientAddressData(int id, PatientAddress patientInfo)
        {
            return _patientCommonRepository.UpdatePatientAddressData(id, patientInfo);
        }
        public PatientInsuranceDetails UpdatePatientInsuranceData(int id, PatientInsuranceDetails patientInfo)
        {
            return _patientCommonRepository.UpdatePatientInsuranceData(id, patientInfo);
        }
        public PhoneNumbers UpdatePhoneNumbersData(int id, PhoneNumbers patientInfo)
        {
            return _patientCommonRepository.UpdatePhoneNumbersData(id, patientInfo);
        }
        public PatientPreference UpdatePatientPreferenceData(int id, PatientPreference patientInfo)
        {
            return _patientCommonRepository.UpdatePatientPreferenceData(id, patientInfo);
        }
        public PatientVitals UpdatePatientVitalseData(int id, PatientVitals patientInfo)
        {
            return _patientCommonRepository.UpdatePatientVitalseData(id, patientInfo);
        }
        //public bool UpdatePatientVitalsFollowUpData(Vitals patientInfo)
        //{
        //    return _patientCommonRepository.UpdatePatientVitalsFollowUpData(patientInfo);
        //}
        public bool UpdatePatientDiagnosisData(int id, PatientDiagnosis patientInfo)
        {
            return _patientCommonRepository.UpdatePatientDiagnosisData(id, patientInfo);
        }
        public bool UpdatePatientEncounterData(int id, PatientEncounter patientInfo)
        {
            return _patientCommonRepository.UpdatePatientEncounterData(id,patientInfo);
        }
        public bool UpdatePatientMedicalFamilyHistoryData(int id, PatientMedicalFamilyHistory patientInfo)
        {
            return _patientCommonRepository.UpdatePatientMedicalFamilyHistoryData(id, patientInfo);
        }
        public PatientImmunization UpdatePatientImmunizationData(int id, PatientImmunization patientInfo)
        {
            return _patientCommonRepository.UpdatePatientImmunizationData(id, patientInfo);
        }
        public PatientSocialHistory UpdatePatientSocialHistoryData(int id, PatientSocialHistory patientInfo)
        {
            return _patientCommonRepository.UpdatePatientSocialHistoryData(id, patientInfo);
        }
    }
}
