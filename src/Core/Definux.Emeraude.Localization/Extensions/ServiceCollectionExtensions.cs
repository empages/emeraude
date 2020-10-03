using System;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Localization.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Localization.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        private const string LocalesDatabaseSqlLiteConnectionString = "Data Source=./privateroot/locales.db;";

        /// <summary>
        /// Register required services for Emeraude localization.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmeraudeLocalization(this IServiceCollection services, EmOptions options)
        {
            services.AddDbContext<LocalizationContext>(options =>
                options.UseSqlite(
                    connectionString: LocalesDatabaseSqlLiteConnectionString,
                    sqliteOptionsAction: b => b.MigrationsAssembly(AssemblyInfo.GetAssembly().FullName)));

            services.AddScoped<ICurrentLanguageProvider, CurrentLanguageProvider>();
            services.AddScoped<ILocalizationContext, LocalizationContext>();
            services.AddScoped<ILocalizer, Localizer>();
            services.AddScoped<ILanguageStore, LanguageStore>();

            if (options.ExecuteMigrations)
            {
                try
                {
                    var serviceProvider = services.BuildServiceProvider();
                    serviceProvider.GetService<LocalizationContext>().Database.Migrate();
                }
                catch (Exception)
                {
                }
            }

            return services;
        }
    }
}
