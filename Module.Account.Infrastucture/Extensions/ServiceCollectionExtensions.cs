using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Account.Core.Abstractions;
using Module.Account.Infrastucture.Persistance;
using Shared.Infrastucture.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Infrastucture.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAccountInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<AccountDbContext>(config)
                .AddScoped<IAccountDbContext>(provider => provider.GetService<AccountDbContext>());
            return services;
        }
    }
}
