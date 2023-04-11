using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WeeeTrackerAPI.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using WeeeTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Core.Services;
using System.Globalization;
using System.Collections.Generic;
using EFCache;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.AspNetCore;

namespace WeeeTrackerAPI
{
  public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var key = Encoding.ASCII.GetBytes(Configuration["Jwt:Key"].PadRight(16, '0').ToString());
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            EntityFrameworkCache.Initialize(new InMemoryCache());

            services.AddDbContext<GVRBD3Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddHttpContextAccessor();

            // configure DI for application services

            services.AddScoped<IFracciones, FraccionService>();
            services.AddScoped<IEstado, EstadoService>();
            services.AddScoped<IFirma, FirmaService>();
            services.AddScoped<IFotografia, FotografiaService>();
            services.AddScoped<IMarca, MarcaService>();
            services.AddScoped<IRaee, RaeeService>();
            services.AddScoped<IResiduo, ResiduoService>();
            services.AddScoped<IResiduoEspecifico, ResiduoEspecificoService>();
            services.AddScoped<ISolicitud, SolicitudService>();
            services.AddScoped<IStock, StockService>();
            services.AddScoped<ITiposContenedor, TiposContenedorService>();
            services.AddScoped<IUserService, UserService>();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("es-ES");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("es-ES"), new CultureInfo("es-ES") };
            });

            services.AddAuthentication(HttpSysDefaults.AuthenticationScheme);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            // loggerFactory.AddDebug();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=default}/{action=Index}/{id?}");
            });

            // loggerFactory.AddFile(Configuration.GetSection("Logging"));
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args,
                IConfigurationRoot config) =>
                    WebHost.CreateDefaultBuilder(args)
                            .UseConfiguration(config)
                            .UseStartup<Startup>()
                            // Using HTTP.sys for Windows Authentication support
                            .UseHttpSys(options =>
                            {
                                options.Authentication.Schemes =
                                AuthenticationSchemes.NTLM | AuthenticationSchemes.Negotiate;
                                options.Authentication.AllowAnonymous = false;
                            });

        }
}
