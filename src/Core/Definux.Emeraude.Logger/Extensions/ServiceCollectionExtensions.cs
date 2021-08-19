using System;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Logger.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        private const string LoggerConnectionStringKey = "LoggerContext";

        /// <summary>
        /// Register Emeraude logger feature elements and services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="loggerOptions"></param>
        /// <param name="mainOptions"></param>
        public static void RegisterEmeraudeLogger(this IServiceCollection services, IConfiguration configuration, EmLoggerOptions loggerOptions, EmMainOptions mainOptions)
        {
            string connectionString = configuration.GetConnectionString(LoggerConnectionStringKey);

            switch (loggerOptions.ContextProvider)
            {
                case DatabaseContextProvider.MicrosoftSqlServer:
                    services.AddDbContext<LoggerContext>(contextOptions =>
                        contextOptions.UseSqlServer(
                            connectionString,
                            b => b.MigrationsAssembly(mainOptions.InfrastructureAssembly)));
                    break;
                case DatabaseContextProvider.PostgreSql:
                    services.AddDbContext<LoggerContext>(contextOptions =>
                        contextOptions.UseNpgsql(
                            connectionString,
                            b => b.MigrationsAssembly(mainOptions.InfrastructureAssembly)));
                    break;
                case DatabaseContextProvider.InMemoryDatabase:
                    services.AddDbContext<LoggerContext>(contextOptions =>
                        contextOptions.UseInMemoryDatabase(databaseName: "InMemoryLoggerContextDatabase"));
                    break;
            }

            services.AddScoped<ILoggerContext, LoggerContext>();
            services.AddScoped<ILogger, Logger>();
            services.AddScoped<IEmLogger, Logger>();

            if (mainOptions.ExecuteMigrations)
            {
                try
                {
                    services
                        .BuildServiceProvider()
                        .GetService<LoggerContext>()
                        ?.Database
                        .Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
