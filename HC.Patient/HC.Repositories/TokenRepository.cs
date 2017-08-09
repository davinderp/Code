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
using HC.Patient.Model;

namespace HC.Patient.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly HCPatientContext _context;
        public TokenRepository(HCPatientContext context) 
        {
            this._context = context;
        }

        public ApplicationUser GetUserByUserName(string userName)
        {
            try
            {
                return _context.User.Where(m => m.UserName == userName).Select(p => new ApplicationUser() { UserName = p.UserName, Password = p.Password }).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
