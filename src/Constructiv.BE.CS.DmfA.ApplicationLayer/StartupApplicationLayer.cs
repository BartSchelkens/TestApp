using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Manager;
using Constructiv.BE.CS.DmfA.DataAccessLayer;
using Constructiv.BE.CS.DmfA.InfrastructureLayer;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Constructiv.BE.CS.DmfA.ApplicationLayer
{
    // ReSharper disable once InconsistentNaming
    public class StartupApplicationLayer : IStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            new StartupDataAccessLayer().ConfigureServices(services, configuration);

            services.AddSingleton<IPersonManager, PersonManager>();
                        
        }

        public void Configure(IApplicationBuilder app)
        {
            new StartupDataAccessLayer().Configure(app);
        }


    }
}
