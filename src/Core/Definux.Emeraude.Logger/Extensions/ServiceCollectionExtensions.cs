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
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmeraudeLogger(this IServiceCollection services, IConfiguration configuration, EmOptions options)
        {
            string connectionString = configuration.GetConnectionString(LoggerConnectionStringKey);

            switch (options.LoggerContextProvider)
            {
                case DatabaseContextProvider.MicrosoftSqlServer:
                    services.AddDbContext<LoggerContext>(contextOptions =>
                        contextOptions.UseSqlServer(
                            connectionString,
                            b => b.MigrationsAssembly(options.MigrationsAssembly)));
                    break;
                case DatabaseContextProvider.PostgreSql:
                    services.AddDbContext<LoggerContext>(contextOptions =>
                        contextOptions.UseNpgsql(
                            connectionString,
                            b => b.MigrationsAssembly(options.MigrationsAssembly)));
                    break;
                case DatabaseContextProvider.InMemoryDatabase:
                    services.AddDbContext<LoggerContext>(contextOptions =>
                        contextOptions.UseInMemoryDatabase(databaseName: "InMemoryLoggerContextDatabase"));
                    break;
            }

            services.AddScoped<ILoggerContext, LoggerContext>();
            if (!options.UseExternalLoggerImplementation)
            {
                services.AddScoped<ILogger, Logger>();
                services.AddScoped<IEmLogger, Logger>();
            }

            if (options.ExecuteMigrations)
            {
                try
                {
                    var serviceProvider = services.BuildServiceProvider();
                    serviceProvider.GetService<LoggerContext>().Database.Migrate();
                }
                catch (Exception)
                {
                }
            }

            return services;
        }
    }
}
