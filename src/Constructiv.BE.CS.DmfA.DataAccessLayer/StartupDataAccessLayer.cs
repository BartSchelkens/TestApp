using Constructiv.BE.CS.DmfA.DataAccessLayer.Repository;
using Constructiv.BE.CS.DmfA.InfrastructureLayer;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Constructiv.BE.CS.DmfA.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class StartupDataAccessLayer : IStartup
    {

        public void ConfigureServices(IServiceCollection services, IConfiguration Configuration)
        {
            ConfigureDependencyInjection(services);
            ConfigureEntityFramework(services, Configuration);


        }

        private void ConfigureEntityFramework(IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<DatabaseContext>(options =>
                    options.UseSqlServer(configuration["Data:DefaultConnection:ConnectionString"]));
        }

        private void ConfigureDependencyInjection(IServiceCollection services)
        {
            services.AddSingleton<PersonRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
           // SampleData.InitializeDatabaseAsync(app.ApplicationServices).Wait();
        }
        
    }
}
