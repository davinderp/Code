using HC.Patient.Service.MasterData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HC.Patient.Model.MasterData;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Entity;

namespace HC.Patient.Service.MasterData
{
    public class MasterDataService : IMasterDataService
    {
        #region Global Variables
        private readonly IMasterDataRepository _masterDataRepository;
        #endregion
        public MasterDataService(IMasterDataRepository masterDataRepository)
        {
            this._masterDataRepository = masterDataRepository;
        }
        public MasterDataModel GetMasterDataByName(List<string> masterDataNames)
        {
            return _masterDataRepository.GetMasterDataByName(masterDataNames);
        }

        public List<MasterState> GetStateByCountryID(int countryID)
        {
            return _masterDataRepository.GetStateByCountryID(countryID);
        }
    }
}
