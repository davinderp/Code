using HC.Patient.Repositories;
using HC.Patient.Repositories.Interfaces;


using HC.Patient.Service.MasterData;
using HC.Patient.Service.MasterData.Interfaces;

using Microsoft.Extensions.DependencyInjection;
using HC.Patient.Service.PatientCommon;
using HC.Patient.Service.PatientCommon.Interfaces;
using HC.Patient.Service.Token;
using HC.Patient.Service.Token.Interfaces;

//using HC.Patient.Repositories;
//using HC.Patient.Repositories.Interfaces;
//using HC.Patient.Service.Interfaces;
//using HC.Patient.Service.Roles;
//using HC.Patient.Service.Roles.Interfaces;
//using HC.Patient.Service.Security;
//using HC.Patient.Service.Security.Interfaces;
//using HC.Patient.Service.Services;
//using HC.Patient.Service.Users;
//using HC.Patient.Service.Users.Interfaces;

namespace HC.Patient.Web
{
    public static class BuildUnityContainer
    {
        public static IServiceCollection RegisterAddTransient(IServiceCollection services)
        {
            #region Repository

            services.AddTransient<IMasterDataRepository, MasterDataRepository>();
            services.AddTransient<IPatientCommonRepository, PatientCommonRepository>();
            #endregion

            #region Services
            services.AddTransient<IPatientCommonService, PatientCommonService>();
            services.AddTransient<IMasterDataService, MasterDataService>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<ITokenRepository, TokenRepository>();

            #endregion

            return services;
        }
    }
}
