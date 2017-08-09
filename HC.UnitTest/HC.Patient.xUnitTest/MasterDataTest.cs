using System;
using Xunit;
using HC.Patient.Web.Controllers;
using HC.Patient.Service.MasterData.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using HC.Patient.Service.MasterData;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Repositories;
using HC.Patient.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using HC.Model;

namespace HC.Patient.xUnitTest
{
    public class MasterDataTest
    {
        private readonly IMasterDataService _masterDataService;
        public MasterDataTest()
        {

            var services = new ServiceCollection();
            services.AddTransient<IMasterDataService, MasterDataService>();
            services.AddTransient<IMasterDataRepository, MasterDataRepository>();
            //services.AddDbContext<HCPatientContext>(option => { option.UseSqlServer(Configuration.GetConnectionString("HCPatient"), b => b.MigrationsAssembly("HC.Patient.Web")); });
            services.AddDbContext<HCPatientContext>(option => { option.UseSqlServer("Server=108.168.203.227,7007;Database=HC_Patient;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=HC_Patient;Password=HC_Patient;"); });

            var provider = services.BuildServiceProvider();

            _masterDataService = provider.GetService<IMasterDataService>();

        }
        [Fact]
        public void GetStates_AllStatesByCountryID_NotNull()
        {
            var masterDataController = new MasterDataController(_masterDataService);
            var result = masterDataController.GetStateByCountryID(1);
            Assert.NotNull(result);
            
        }
        [Fact]
        public void GetStates_AllStatesByCountryID_Equal()
        {
            var masterDataController = new MasterDataController(_masterDataService);
            var result = masterDataController.GetStateByCountryID(-1);

            JsonModel jsonModel = (JsonModel)result.Value;
            Assert.Equal(jsonModel.StatusCode, 404);

        }
    }
}
