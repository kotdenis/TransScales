using Microsoft.Extensions.DependencyInjection;
using TransScales.Data.Repositries.Implementation;
using TransScales.Data.Repositries.Interfacies;

namespace TransScales.Data.Configuration
{
    public static class RepositoryDependencies
    {
        public static void MakeRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<IJournalRepository, JournalRepository>();
            services.AddScoped<ITransportRepository, TransportRepository>();
            services.AddScoped<ITransportQuantityRepository, TransportQuantityRepository>();
        }
    }
}
