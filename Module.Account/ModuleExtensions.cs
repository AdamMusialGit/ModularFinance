using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Account.Core.Extensions;
using Module.Account.Infrastucture.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddAccount(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddAccountCore()
                .AddAccountInfrastructure(configuration);
            return services;
        }
    }
}
