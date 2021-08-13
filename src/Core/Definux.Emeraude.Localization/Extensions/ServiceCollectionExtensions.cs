using System;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Interfaces.Services;
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
        public static IServiceCollection RegisterEmeraudeLocalization(this IServiceCollection services, EmMainOptions options)
        {
            if (!options.TestMode)
            {
                services.AddDbContext<LocalizationContext>(opt =>
                    opt.UseSqlite(
                        connectionString: LocalesDatabaseSqlLiteConnectionString,
                        sqliteOptionsAction: b => b.MigrationsAssembly(AssemblyInfo.GetAssembly().FullName)));
            }
            else
            {
                services.AddDbContext<LocalizationContext>(opt =>
                    opt.UseInMemoryDatabase(databaseName: "test_localization_database"));
            }

            services.AddScoped<ICurrentLanguageProvider, CurrentLanguageProvider>();
            services.AddScoped<ILocalizationContext, LocalizationContext>();
            services.AddScoped<ILocalizer, Localizer>();
            services.AddScoped<IEmLocalizer, Localizer>();
            services.AddScoped<ILanguageStore, LanguageStore>();

            if (options.ExecuteMigrations)
            {
                try
                {
                    services
                        .BuildServiceProvider()
                        .GetService<LocalizationContext>()
                        ?.Database
                        .Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return services;
        }
    }
}
