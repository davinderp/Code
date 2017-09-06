using Audit.SqlServer.Providers;
using Elmah.Io.AspNetCore;
using HC.Patient.Data;
using HC.Patient.Web.Options;
using HC.Repositories;
using HC.Repositories.Interfaces;
using JsonApiDotNetCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Extensions.Logging;
using NLog.Web;
//using HC.Patient.Service.Users.Interfaces;
//using HC.Patient.Service.Users;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Net;
using System.Text;
using System.IO;
using System.Linq;
using HC.Patient.Entity;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace HC.Patient.Web
{
    public partial class Startup
    {
        private const string DefaultCorsPolicyName = "localhost";
        public IConfigurationRoot Configuration { get; }
        private static int organizationID = 0;
        private Organization organization = new Organization();
        public Startup(IHostingEnvironment env)
        {
            env.ConfigureNLog("nlog.config");
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            organizationID = Configuration.GetValue<Int32>("OrganizationID");
          
        }


        private const string SecretKey = "needtogetthisfromenvironment";
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));


        //This method gets called by the runtime.Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)//,HCPatientContext context)
        {
            //organization = context.Organization.Where(p => p.Id == organizationID).FirstOrDefault();
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
            services.AddMvc(options =>
            {
                //options.Filters.Add(new AuthorizeFilter("AuthorizedUser"));
            });
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

            Audit.Core.Configuration.DataProvider = new SqlDataProvider()
            {
                ConnectionString = Configuration.GetConnectionString("HCPatient"),//organization.OrganizationConnectionstring.OrganizationDBConnectionstring,
                Schema = "dbo",
                TableName = "Event",
                IdColumnName = "EventId",
                JsonColumnName = "Data",
                LastUpdatedDateColumnName = "LastUpdatedDate"
            };
            services.AddScoped<LogFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, HCPatientContext context)//, 
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
            app.UseElmahIo("6e46539834624195b66edb223f370836", new Guid("d6251932-8823-4afe-b0ba-0ef3fac938fb"));
            app.UseJwtBearerAuthentication(new JwtBearerOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true,
                TokenValidationParameters = tokenValidationParameters
            });

            app.UseCors(DefaultCorsPolicyName); //Enable CORS!
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

            //app.UseForwardedHeaders(new ForwardedHeadersOptions
            //{
            //    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            //});


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
            //{
            //    //context.PASCore_UserRoles.Add(new PASCore_UserRoles
            //    //{
            //    //    EntityId = Guid.NewGuid(),
            //    //    FirstName="test"
            //    //});
            //    context.SaveChanges();
            //}
            // ...
            app.UseJsonApi();
            //ConfigureAuth(app);

            loggerFactory.AddNLog();


            //add NLog.Web
            app.AddNLogWeb();



            var configDir = "C:\\Logs";

            if (configDir != string.Empty)
            {
                var logEventInfo = LogEventInfo.CreateNullEvent();


                foreach (FileTarget target in LogManager.Configuration.AllTargets.Where(t => t is FileTarget))
                {
                    var filename = target.FileName.Render(logEventInfo).Replace("'", "");
                    target.FileName = Path.Combine(configDir, filename);
                }

                LogManager.ReconfigExistingLoggers();
            }
            //LogManager.Configuration = new LoggingConfiguration();

            organization = context.Organization.Where(p => p.Id == organizationID).FirstOrDefault();
            LogManager.Configuration.Variables["connectionString"] = Configuration.GetConnectionString("HCPatient");

            LogManager.Configuration.Variables["configDir"] = "C:\\Logs";
            LogManager.ConfigurationReloaded += updateConfig;
            app.UseMvc();
        }



        private void updateConfig(object sender, LoggingConfigurationReloadedEventArgs e)
        {
            LogManager.Configuration.Variables["connectionString"] = Configuration.GetConnectionString("HCPatient");
            LogManager.Configuration.Variables["configDir"] = "C:\\Logs";
        }
}
}
