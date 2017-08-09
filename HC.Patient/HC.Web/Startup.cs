using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using HC.Patient.Data;
using HC.Repositories;
using HC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
//using HC.Patient.Service.Users.Interfaces;
//using HC.Patient.Service.Users;
using Swashbuckle.AspNetCore.Swagger;
using JsonApiDotNetCore.Extensions;
using HC.Patient.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using AspNetCoreNlog;
using NLog.Extensions.Logging;
using NLog.Web;
using NLog;
using NLog.Config;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using HC.Patient.Service.MasterData.Interfaces;
using HC.Patient.Service.MasterData;
using HC.Patient.Repositories.Interfaces;
using HC.Patient.Repositories;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using HC.Patient.Web.Options;

namespace HC.Patient.Web
{
    public partial class Startup
    {
        private const string DefaultCorsPolicyName = "localhost";
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
        private const string SecretKey = "needtogetthisfromenvironment";
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));


        //This method gets called by the runtime.Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AuthorizedUser",
                                  policy => policy.RequireClaim("HealthCare", "IAmAuthorized"));

            });

            // Get options from app settings
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            });
        

        services.AddScoped<LogFilter>();
            // Add framework services.
            services.AddMvc();
            services.AddDbContext<HCPatientContext>(option => { option.UseSqlServer(Configuration.GetConnectionString("HCPatient"), b => b.MigrationsAssembly("HC.Patient.Web")); });// ServiceLifetime.Transient);
            //services.AddDbContext<HCPatientContext>(option => { option.UseSqlServer(@"Server=108.168.203.227,7007;Database=HC_Patient;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=HC_Patient;Password=HC_Patient;"); });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddJsonApi<HCPatientContext>();
            services.AddJsonApi<HCPatientContext>(opt =>
            {
                //opt.Namespace = "api/v1";
                opt.DefaultPageSize = 10;
                opt.IncludeTotalRecordCount = true;
            });

            // Add all Transient dependencies
            services = BuildUnityContainer.RegisterAddTransient(services);

            //Configure CORS for angular2 UI
            services.AddCors(options =>
            {
                options.AddPolicy(DefaultCorsPolicyName, builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });


            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, HCPatientContext context)
        {
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _signingKey,

                RequireExpirationTime = true,
                ValidateLifetime = true,

                ClockSkew = TimeSpan.Zero
            };

            app.UseJwtBearerAuthentication(new JwtBearerOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true,
                TokenValidationParameters = tokenValidationParameters
            });

            app.UseCors(DefaultCorsPolicyName); //Enable CORS!
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseExceptionHandler(
            builder =>
            {
                builder.Run(
                  async dbcontext =>
                  {
                      dbcontext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                      dbcontext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                      var error = dbcontext.Features.Get<IExceptionHandlerFeature>();
                      if (error != null)
                      {
                          // context.Response.AddApplicationError(error.Error.Message);
                          await dbcontext.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                      }
                  });
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Index}/{id?}");
            });
            //app.UseJsonApi();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();


            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "My API V1");
            });

            context.Database.EnsureCreated();
            //if (context.PASCore_Users.Any() == false)
            {
                //context.PASCore_UserRoles.Add(new PASCore_UserRoles
                //{
                //    EntityId = Guid.NewGuid(),
                //    FirstName="test"
                //});
                context.SaveChanges();
            }
            // ...
            app.UseJsonApi();
            //ConfigureAuth(app);

            //loggerFactory.AddNLog();

            //add NLog.Web
            //app.AddNLogWeb();

            //LogManager.Configuration = new LoggingConfiguration();

            //LogManager.Configuration.Variables["connectionString"] = Configuration.GetConnectionString("NLog");
            //LogManager.Configuration.Variables["configDir"] = "C:\\Logs";
            //LogManager.ConfigurationReloaded += updateConfig;

            app.UseMvc();
        }

        //private void updateConfig(object sender, LoggingConfigurationReloadedEventArgs e)
        //{
        //    LogManager.Configuration.Variables["connectionString"] = Configuration.GetConnectionString("NLog");
        //    LogManager.Configuration.Variables["configDir"] = "C:\\Logs";
        //}
    }
}
