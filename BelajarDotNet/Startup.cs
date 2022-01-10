using BelajarDotNet.Domains.Movie.Repositories;
using BelajarDotNet.Infrastructures.DataAccess;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace BelajarDotNet
{
    public partial class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, ILoggerFactory logFactory)
        {
            Configuration = configuration;
            Logger = logFactory.CreateLogger<Startup>();
        }
        private ILogger Logger { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            Logger.LogInformation("Registering Services");
            /*==============================================================*/
            services.AddControllers();
            /*==============================================================*/
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IUrlHelper>(x =>
            {
                var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
                var factory = x.GetRequiredService<IUrlHelperFactory>();
                return factory.GetUrlHelper(actionContext);
            });
            /*==============================================================*/
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>())
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver()
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    };
                });
            /*==============================================================*/
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            /*==============================================================*/
            // Repositories
            Repositories(services);
            /*==============================================================*/
        }
    }
}
