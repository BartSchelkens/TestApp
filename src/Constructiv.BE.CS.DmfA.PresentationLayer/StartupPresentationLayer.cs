using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Constructiv.BE.CS.DmfA.ApplicationLayer;
using Constructiv.BE.CS.DmfA.InfrastructureLayer;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;

namespace Constructiv.BE.CS.DmfA.PresentationLayer
{
    
    public class StartupPresentationLayer : IStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {       
            new StartupInfrastructureLayer().ConfigureServices(services, configuration);
            new StartupApplicationLayer().ConfigureServices(services, configuration);
        }

        public void Configure(IApplicationBuilder app)
        {
            new StartupInfrastructureLayer().Configure(app);
            new StartupApplicationLayer().Configure(app);
        }
    }
}
