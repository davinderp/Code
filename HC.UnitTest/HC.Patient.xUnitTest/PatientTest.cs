using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Web.Controllers;
using JsonApiDotNetCore.Extensions;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;
using HC.Repositories.Interfaces;
using HC.Repositories;
using Microsoft.AspNetCore.Http;
using JsonApiDotNetCore.Controllers;
using Moq;

namespace HC.Patient.xUnitTest
{
    public class PatientTest: JsonApiControllerMixin
    {
        private readonly Mock<IJsonApiContext> _jsonApiContext;
        private readonly Mock<IResourceService<Patients, int>> _resourceService;
        private readonly Mock<ILoggerFactory> _loggerFactory;
        //private readonly Mock<IApplicationBuilder>_applicationBuilder;

        public PatientTest(IJsonApiContext jsonApiContext)
        {
            _jsonApiContext = new Mock<IJsonApiContext>();
            _resourceService = new Mock<IResourceService<Patients, int>>();
            _loggerFactory = new Mock<ILoggerFactory>();

            //var services = new ServiceCollection();
            ////services.AddTransient<IJsonApiContext, JsonApiContext>();
            ////services.AddTransient<IResourceService<Patients, int>, EntityResourceService<Patients,int>>();
            ////services.AddTransient<ILoggerFactory, LoggerFactory>();
            ////services.AddTransient<IApplicationBuilder, ApplicationBuilder>();
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddDbContext<HCPatientContext>(option => { option.UseSqlServer("Server=108.168.203.227,7007;Database=HC_Patient;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=HC_Patient;Password=HC_Patient;"); });
            //services.AddJsonApi<HCPatientContext>(opt =>
            //{
            //    //opt.Namespace = "api/v1";
            //    opt.DefaultPageSize = 10;
            //    opt.IncludeTotalRecordCount = true;
            //});




            //var provider = services.BuildServiceProvider();

            //_applicationBuilder = provider.GetService<IApplicationBuilder>();
            ////_applicationBuilder.UseJsonApi(true);
            //_jsonApiContext = provider.GetService<IJsonApiContext>();
            //_resourceService = provider.GetService<IResourceService<Patients, int>>();
            //_loggerFactory = provider.GetService<ILoggerFactory>();
        }
        [Fact]
        public void test1()
        {
            var patientController = new PatientController(_jsonApiContext.Object, _resourceService.Object, _loggerFactory.Object);
        }
    }
}
