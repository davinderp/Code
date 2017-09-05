using HC.Patient.Entity;
using HC.Patient.Model;
using HC.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Service.Token.Interfaces
{
    public interface ITokenService : IBaseService
    {
        User GetUserByUserName(string userName);
        Clinicians GetDoctorByUserID(int UserID);
    }
}
