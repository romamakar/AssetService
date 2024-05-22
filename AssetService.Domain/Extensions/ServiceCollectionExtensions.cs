using AssetService.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AssetService.Domain.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IAssetService, Services.AssetService>();
            return services;
        }
    }
}
