using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Localization.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Localization.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string LocalesDatabaseSqlLiteConnectionString = "Data Source=./privateroot/locales.db;";

        public static IServiceCollection RegisterEmeraudeLocalization(this IServiceCollection services)
        {
            services.AddDbContext<LocalizationContext>(options =>
                options.UseSqlite(
                    connectionString: LocalesDatabaseSqlLiteConnectionString,
                    sqliteOptionsAction: b => b.MigrationsAssembly(AssemblyInfo.GetAssembly().FullName)));

            services.AddScoped<ICurrentLanguageProvider, CurrentLanguageProvider>();
            services.AddScoped<ILocalizationContext, LocalizationContext>();
            services.AddScoped<ILocalizer, Localizer>();
            services.AddScoped<ILanguageStore, LanguageStore>();

            return services;
        }
    }
}
