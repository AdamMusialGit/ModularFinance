using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Transfer.Core.Abstractions;
using Module.Transfer.Infrastructure.Persistance;
using Shared.Infrastucture.Extensions;

namespace Module.Transfer.Infrastucture.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTransferInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<TransferDbContext>(config)
                .AddScoped<ITransferDbContext>(provider => provider.GetService<TransferDbContext>());
            return services;
        }
    }
}
