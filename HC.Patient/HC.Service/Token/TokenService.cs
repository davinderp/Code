using HC.Patient.Service.Token.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HC.Patient.Model;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Entity;

namespace HC.Patient.Service.Token
{
    public class TokenService : ITokenService
    {
        #region Global Variables
        private readonly ITokenRepository _tokenRepository;
        #endregion
        public TokenService(ITokenRepository tokenRepository)
        {
            this._tokenRepository = tokenRepository;
        }

        public Clinicians GetDoctorByUserID(int UserID)
        {
            return _tokenRepository.GetDoctorByUserID(UserID);
        }

        public User GetUserByUserName(string userName)
        {
            return _tokenRepository.GetUserByUserName(userName);
        }
    }
}
