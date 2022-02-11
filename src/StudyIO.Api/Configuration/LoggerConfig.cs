using Elmah.Io.AspNetCore;
using Elmah.Io.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace StudyIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfiguration(this IServiceCollection services)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "f399f3ba6f894c8d81ad71fb3775a8e4";
                o.LogId = new Guid("9e44eec8-4166-4df2-8894-cf043113b1ff");
            });

            //configurando Elmah como um provider,
            //dessa forma o Elmah consegue capturar
            //services.AddLogging(builder =>
            //{
            //    builder.AddElmahIo(o =>
            //    {
            //        o.ApiKey = "f399f3ba6f894c8d81ad71fb3775a8e4";
            //        o.LogId = new Guid("9e44eec8-4166-4df2-8894-cf043113b1ff");
            //    });

            //    //Add filtro pra ele mostrar logs de warning pra cima
            //    builder.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);
            //});

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}