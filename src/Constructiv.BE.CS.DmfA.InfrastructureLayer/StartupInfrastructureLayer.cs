using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Constructiv.BE.CS.DmfA.InfrastructureLayer
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class StartupInfrastructureLayer : IStartup
    {

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Nothing yet
        }

        public void Configure(IApplicationBuilder app)
        {
            // Nothing yet
        }
    }
}
