using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Definux.Emeraude.Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureDatabases<TContextInterface, TContextImplementation>(this IServiceCollection services, string applicationAssembly, IConfiguration configuration, EmOptions options)
            where TContextInterface : class, IEmContext
            where TContextImplementation : EmContext<TContextImplementation>, TContextInterface
        {
            services.AddDbContext<TContextImplementation>(options =>
                options.UseSqlServer(
                    connectionString: configuration.GetConnectionString("DatabaseConnection"),
                    b => b.MigrationsAssembly(applicationAssembly)));

            services.AddScoped<IEmContext, TContextImplementation>();
            services.AddScoped<TContextInterface, TContextImplementation>();
            services.AddTransient<IDatabaseInitializerManager, DatabaseInitializerManager>();

            if (options.ExecuteMigrations)
            {
                try
                {
                    var serviceProvider = services.BuildServiceProvider();
                    serviceProvider.GetService<TContextImplementation>().Database.Migrate();
                }
                catch (Exception) { }
            }

            return services;
        }

        /// <summary>
        /// Register database initializer.
        /// </summary>
        /// <typeparam name="TInitializerService"></typeparam>
        /// <typeparam name="TInitializerImplementation"></typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDatabaseInitializer<TInitializerService, TInitializerImplementation>(this IServiceCollection services)
            where TInitializerService : class, IDatabaseInitializer
            where TInitializerImplementation : class, TInitializerService, IDatabaseInitializer
        {
            services.AddTransient<TInitializerService, TInitializerImplementation>();

            return services;
        }
    }
}
