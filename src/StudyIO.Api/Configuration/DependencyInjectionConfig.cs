using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using StudyIO.Api.Extensions;
using StudyIO.Business.Interfaces;
using StudyIO.Business.Notifications;
using StudyIO.Business.Services;
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
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspnetUser>();

            return services;
        }
    }
}