using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Configuration.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Definux.Emeraude.Logger.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string LoggerDatabaseSqlLiteConnectionString = "Data Source=./privateroot/log.db;";

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
                catch (Exception) { }
            }

            return services;
        }
    }
}
