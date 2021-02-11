using System;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Logger.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        private const string LoggerDatabaseSqlLiteConnectionString = "Data Source=./privateroot/log.db;";

        /// <summary>
        /// Register Emeraude logger feature elements and services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmeraudeLogger(this IServiceCollection services, EmOptions options)
        {
            if (!options.TestMode)
            {
                services.AddDbContext<LoggerContext>(opt =>
                    opt.UseSqlite(
                        connectionString: LoggerDatabaseSqlLiteConnectionString,
                        sqliteOptionsAction: b => b.MigrationsAssembly(AssemblyInfo.GetAssembly().FullName)));
            }
            else
            {
                services.AddDbContext<LoggerContext>(opt =>
                    opt.UseInMemoryDatabase(databaseName: "test_logger_database"));
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
