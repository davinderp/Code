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

        public User GetUserByUserName(string userName)
        {
            try
            {
                return _context.User.Where(m => m.UserName == userName).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Clinicians GetDoctorByUserID(int UserID)
        {
            try
            {
                return _context.Clinicians.Where(m => m.UserID == UserID).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
