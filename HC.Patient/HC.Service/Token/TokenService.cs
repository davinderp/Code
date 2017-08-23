using HC.Patient.Service.Token.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using HC.Patient.Model;
using HC.Patient.Repositories.Interfaces;

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
        public ApplicationUser GetUserByUserName(string userName)
        {
            return _tokenRepository.GetUserByUserName(userName);
        }
    }
}
