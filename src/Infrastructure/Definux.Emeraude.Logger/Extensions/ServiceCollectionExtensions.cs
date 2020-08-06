using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Logger.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string LoggerDatabaseSqlLiteConnectionString = "Data Source=./privateroot/log.db;";

        public static IServiceCollection RegisterEmeraudeLogger(this IServiceCollection services)
        {
            services.AddDbContext<LoggerContext>(options =>
                options.UseSqlite(
                    connectionString: LoggerDatabaseSqlLiteConnectionString,
                    sqliteOptionsAction: b => b.MigrationsAssembly(AssemblyInfo.GetAssembly().FullName)));

            services.AddScoped<ILoggerContext, LoggerContext>();
            services.AddScoped<ILogger, Logger>();

            return services;
        }
    }
}
