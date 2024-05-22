using AssetService.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace AssetService.Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddOptions<PersistenceConfiguration>().Configure<IConfiguration>((settings, configuration) =>
            {
                configuration.GetSection(PersistenceConfiguration.SectionName).Bind(settings);
            });

            services.AddDbContextFactory<AssetDbContext>((services, options) =>
            {
                var persistenceOptions = services.GetRequiredService<IOptions<PersistenceConfiguration>>().Value;
                options.UseNpgsql(persistenceOptions.ConnectionString);
            });
            return services;
        }
    }
}
