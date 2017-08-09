using HC.Patient.Model;
using HC.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Service.Token.Interfaces
{
    public interface ITokenService : IBaseService
    {
       ApplicationUser GetUserByUserName(string userName);
    }
}
