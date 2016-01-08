using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructiv.BE.CS.DmfA.DataAccessLayer.Repository;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.CodeAnalysis;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;


namespace Constructiv.BE.CS.DmfA.PresentationLayer
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }

        public Startup(IApplicationEnvironment applicationEnvironment)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(applicationEnvironment.ApplicationBasePath)
                .AddJsonFile("config.json")
                .Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            new StartupPresentationLayer().ConfigureServices(services, Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerfactory)
        {
            //Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Trace().CreateLogger();
            loggerfactory.AddConsole();
            

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();

            new StartupPresentationLayer().Configure(app);
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
