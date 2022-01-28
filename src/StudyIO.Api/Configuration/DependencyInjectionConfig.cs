using Microsoft.Extensions.DependencyInjection;
using StudyIO.Business.Interfaces;
using StudyIO.Data.Context;
using StudyIO.Data.Repositories;

namespace StudyIO.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            return services;
        }
    }
}