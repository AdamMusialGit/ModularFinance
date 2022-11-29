using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Module.Account.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAccountCore(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
