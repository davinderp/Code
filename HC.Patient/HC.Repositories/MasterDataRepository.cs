using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Repositories.Interfaces;
using HC.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using HC.Patient.Model.MasterData;
using static HC.Common.Enums.CommonEnum;
using System.Linq;

namespace HC.Patient.Repositories
{
    public class MasterDataRepository : IMasterDataRepository
    {
        private readonly HCPatientContext _context;
        public MasterDataRepository(HCPatientContext context)
        {
            this._context = context;
        }

        public MasterDataModel GetMasterDataByName(List<string> masterDataNames)
        {
            try
            {
                MasterDataModel listMasterDataModel = new MasterDataModel();
                GetMasterData(masterDataNames, listMasterDataModel);
                return listMasterDataModel;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MasterState> GetStateByCountryID(int countryID)
        {
            try
            {
                return _context.MasterState.Where(m => m.CountryID == countryID && m.IsActive == true && m.IsDeleted == false).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void GetMasterData(List<string> masterDataNames, MasterDataModel listMasterDataModel)
        {
            masterDataNames.ForEach(p =>
            {
                if (Enum.IsDefined(typeof(MasterDataEnum), p.ToUpper()))
                {
                    switch ((MasterDataEnum)Enum.Parse(typeof(MasterDataEnum), p.ToUpper()))
                    {
                        case MasterDataEnum.MASTERCOUNTRY:
                            listMasterDataModel.MasterCountry = _context.MasterCountry.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a=>a.CountryName).ToList();
                            break;
                        case MasterDataEnum.MASTERETHNICITY:
                            listMasterDataModel.MasterEthnicity = _context.MasterEthnicity.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.EthnicityName).ToList();
                            break;

                        case MasterDataEnum.MASTERFUNDINGSOURCE:
                            listMasterDataModel.MasterFundingSource = _context.MasterFundingSource.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.FundingSource).ToList();
                            break;
                        case MasterDataEnum.MASTEROCCUPATION:
                            listMasterDataModel.MasterOccupation = _context.MasterOccupation.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.OccupationName).ToList();
                            break;
                        case MasterDataEnum.MASTERPREFERREDLANGUAGE:
                            listMasterDataModel.MasterPreferredLanguage = _context.MasterPreferredLanguage.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Language).ToList();
                            break;
                        case MasterDataEnum.MASTERRACE:
                            listMasterDataModel.MasterRace = _context.MasterRace.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.RaceName).ToList();
                            break;
                        case MasterDataEnum.MASTERSTATE:
                            listMasterDataModel.MasterState = _context.MasterState.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.StateName).ToList();
                            break;
                        case MasterDataEnum.SUFFIX:
                            listMasterDataModel.MasterSuffix = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.MASTERPROVIDER:
                            listMasterDataModel.Provider = _context.Provider.Where(a => a.IsActive == true && a.IsDeleted == false).ToList();
                            break;
                        case MasterDataEnum.MARITALSTATUS:
                            listMasterDataModel.MasterMaritalStatus = _context.MasterStatus.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.StatusName).ToList();
                            break;
                        case MasterDataEnum.MASTERRELATIONSHIP:
                            listMasterDataModel.MasterRelationship = _context.MasterRelationship.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.RelationshipName).ToList();
                            break;
                        case MasterDataEnum.MASTERPROGRAM:
                            listMasterDataModel.MasterProgram = _context.MasterProgram.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ProgramName).ToList();
                            break;
                        case MasterDataEnum.MASTERSERVICE:
                            listMasterDataModel.MasterService = _context.MasterService.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ServiceName).ToList();
                            break;
                        case MasterDataEnum.PATIENTSTATUS:
                            listMasterDataModel.MasterPatientStatus = _context.MasterStatus.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.StatusName).ToList();
                            break;
                        case MasterDataEnum.MASTERINSURANCECOMPANY:
                            listMasterDataModel.InsuranceCompanies = _context.InsuranceCompanies.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.CompanyName).ToList();
                            break;
                        case MasterDataEnum.MASTERPATIENTCOMMPREFERENCES:
                            listMasterDataModel.MasterPatientCommPreferences = _context.MasterPatientCommPreferences.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.PatientCommPreferences).ToList();
                            break;
                        case MasterDataEnum.MASTERREFERRAL:
                            listMasterDataModel.MasterReferral = _context.MasterReferral.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ReferralName).ToList();
                            break;
                        case MasterDataEnum.MASTERGENDER:
                            listMasterDataModel.MasterGender = _context.MasterGender.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Gender).ToList();
                            break;
                        case MasterDataEnum.PHONETYPE:
                            listMasterDataModel.MasterPhoneType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.INSURANCEPLANTYPE:
                            listMasterDataModel.InsurancePlanType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.MASTERLOCATION:
                            listMasterDataModel.MasterLocation = _context.MasterLocation.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Location).ToList();
                            break;
                        case MasterDataEnum.MASTERCPT:
                            listMasterDataModel.MasterCPT = _context.MasterCPT.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.CPTCode).ToList();
                            break;
                        case MasterDataEnum.MASTERICD:
                            listMasterDataModel.MasterICD = _context.MasterICD.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Code).ToList();
                            break;
                        //Following are the Master tables for Immunization
                        case MasterDataEnum.MASTERVFC:
                            listMasterDataModel.MasterVFC = _context.MasterVFCEligibility.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ConceptCode).ToList();
                            break;
                        case MasterDataEnum.MASTERIMMUNIZATION:
                            listMasterDataModel.MasterImmunization = _context.MasterImmunization.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.CvxCode).ToList();
                            break;
                        case MasterDataEnum.MASTERMANUFACTURE:
                            listMasterDataModel.MasterManufacture = _context.MasterManufacture.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ManufacturerName).ToList();
                            break;
                        case MasterDataEnum.MASTERADMINISTRATIONSITE:
                            listMasterDataModel.MasterAdministrationSite = _context.MasterAdministrationSite.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Description).ToList();
                            break;
                        case MasterDataEnum.MASTERROUTEOFADMINISTRATION:
                            listMasterDataModel.MasterRouteOfAdministration = _context.MasterRouteOfAdministration.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Description).ToList();
                            break;
                        case MasterDataEnum.MASTERIMMUNITYSTATUS:
                            listMasterDataModel.MasterImmunityStatus = _context.MasterImmunityStatus.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ConceptCode).ToList();
                            break;
                        case MasterDataEnum.MASTERREJECTIONREASON:
                            listMasterDataModel.MasterRejectionReason = _context.MasterRejectionReason.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.ReasonCode).ToList();
                            break;
                        case MasterDataEnum.SOCIALHISTORY:
                            listMasterDataModel.MasterSocialHistory = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.TRAVELHISTORY:
                            listMasterDataModel.MasterTravelHistory = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.ADDRESSTYPE:
                            listMasterDataModel.MasterAddressType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.MASTERCLINICIAN:
                            listMasterDataModel.Clinicians = _context.Clinicians.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.FirstName).ToList();
                            break;
                        case MasterDataEnum.APPOINTMENTTYPE:
                            listMasterDataModel.AppointmentType = _context.AppointmentType.Where(a => a.IsActive == true && a.IsDeleted == false).OrderByDescending(a => a.Description).ToList();
                            break;
                        //Following are the Master tables for Lab
                        case MasterDataEnum.LABTESTTYPE:
                            listMasterDataModel.MasterLabTestType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.MASTERLONIC:
                            listMasterDataModel.MasterLonic = _context.MasterLonic.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.LonicCode).ToList();
                            break;
                        case MasterDataEnum.MASTERLABS:
                            listMasterDataModel.MasterLabs = _context.MasterLabs.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.LabName).ToList();
                            break;
                        case MasterDataEnum.TIMETYPE:
                            listMasterDataModel.MasterTimeType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.FREQUENCYTYPE:
                            listMasterDataModel.MasterFrequencyType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.FREQUENCYDURATIONTYPE:
                            listMasterDataModel.MasterFrequencyDurationType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        //Master Allergy
                        case MasterDataEnum.MASTERALLERGIES:
                            listMasterDataModel.MasterAllergies = _context.MasterAllergies.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.AllergyType).ToList();
                            break;
                        case MasterDataEnum.MASTERREACTION:
                            listMasterDataModel.MasterReaction = _context.MasterReaction.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Reaction).ToList();
                            break;
                        case MasterDataEnum.AUTHORIZEDPROCEDURE:
                            listMasterDataModel.MasterAuthorizedProcedure = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.MASTERCUSTOMLABELTYPE:
                            listMasterDataModel.MasterCustomLabelType = _context.MasterType.Where(a => a.IsActive == true && a.IsDeleted == false && a.Type.ToUpper() == p.ToUpper()).OrderBy(a => a.TypeName).ToList();
                            break;
                        case MasterDataEnum.MASTERCUSTOMLABELS:
                            listMasterDataModel.MasterCustomLabels = _context.MasterCustomLabels.Where(a => a.IsActive == true && a.IsDeleted == false).OrderBy(a => a.Id).Select(t => new MasterCustomLabels { CustomLabelName = t.CustomLabelName, Id = t.Id, MasterType = t.MasterType }).ToList();
                            //listMasterDataModel.MasterCustomLabelData = _context.MasterCustomLabels
                            break;

                            
                    }
                }
            });
        }
    }
}