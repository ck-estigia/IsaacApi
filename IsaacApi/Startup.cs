using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using IsaacApi.Helpers;
using IsaacApi.Model.Entities;
using MySQL.Data.Entity.Extensions;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi
{
    public partial class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("config.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc(options => { options.Filters.Add(new IsaacExceptionFilter()); })
                .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSingleton<IConfiguration>(sp => { return Configuration; });
            services.AddDbContext<IsaacDbContext>(options => options.UseMySQL(Configuration["DataAccessMySqlProvider:ConnectionString"], b => b.MigrationsAssembly("AspNet5MultipleProject")));
            services.AddScoped<IIsaacFacade, IsaacFacade>();
            services.Configure<IISOptions>(opt =>
            {
                opt.AutomaticAuthentication = true;
                opt.ForwardClientCertificate = true;
                opt.ForwardWindowsAuthentication = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Trace);
            loggerFactory.AddDebug();

            ConfigureAuth(app);

            app.UseMvc();
        }
    }
}
