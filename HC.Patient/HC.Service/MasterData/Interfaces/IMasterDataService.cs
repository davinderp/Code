using System;
using System.Collections.Generic;
using System.Text;
using HC.Patient.Entity;
using HC.Patient.Model.MasterData;
using HC.Service.Interfaces;

namespace HC.Patient.Service.MasterData.Interfaces
{
    public interface IMasterDataService : IBaseService
    {
      MasterDataModel GetMasterDataByName(List<string> masterDataNames);
        List<MasterState> GetStateByCountryID(int countryID);
    }
}
