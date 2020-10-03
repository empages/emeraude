using System;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Configuration.Options;
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
            services.AddDbContext<LoggerContext>(options =>
                options.UseSqlite(
                    connectionString: LoggerDatabaseSqlLiteConnectionString,
                    sqliteOptionsAction: b => b.MigrationsAssembly(AssemblyInfo.GetAssembly().FullName)));

            services.AddScoped<ILoggerContext, LoggerContext>();
            services.AddScoped<ILogger, Logger>();

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
