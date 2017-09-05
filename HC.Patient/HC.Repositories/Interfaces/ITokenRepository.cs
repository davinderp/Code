using HC.Patient.Entity;
using HC.Patient.Model;
using HC.Patient.Model.MasterData;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Repositories.Interfaces
{
    public interface ITokenRepository//: IRepository<MasterDataModel>
    {
        User GetUserByUserName(string userName);
        Clinicians GetDoctorByUserID(int UserID);
    }
}
