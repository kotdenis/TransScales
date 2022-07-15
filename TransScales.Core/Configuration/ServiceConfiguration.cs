using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using TransScales.Core.Services.Implementation;
using TransScales.Core.Services.Interfacies;
using TransScales.Core.Validation;
using TransScales.Dto.DtoModels;

namespace TransScales.Core.Configuration
{
    public static class ServiceConfiguration
    {
        public static void MakeServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICacheManager, CacheManager>();
            services.AddScoped<ITransportService, TransportService>();
            services.AddScoped<IJournalService, JournalService>();
            services.AddScoped<IValidator<TransportDto>, TransportValidator>();
            services.AddScoped<IValidator<JournalDto>, JournalValidator>();
        }
    }
}
