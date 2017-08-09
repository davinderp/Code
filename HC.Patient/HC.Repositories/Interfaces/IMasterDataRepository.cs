using HC.Patient.Entity;
using HC.Patient.Model.MasterData;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Repositories.Interfaces
{
    public interface IMasterDataRepository//: IRepository<MasterDataModel>
    {
        MasterDataModel GetMasterDataByName(List<string> masterDataNames);
        List<MasterState> GetStateByCountryID(int countryID);
    }
}
