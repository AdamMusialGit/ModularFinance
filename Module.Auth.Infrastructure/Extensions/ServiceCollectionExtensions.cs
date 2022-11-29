using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Auth.Core.Abstractions;
using Module.Auth.Infrastructure.Persistance;
using Shared.Infrastucture.Extensions;

namespace Module.Auth.Infrastucture.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<AuthDbContext>(config)
                .AddScoped<IAuthDbContext>(provider => provider.GetService<AuthDbContext>());
            return services;
        }
    }
}
