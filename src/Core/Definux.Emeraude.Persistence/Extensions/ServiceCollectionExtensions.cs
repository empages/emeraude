using System;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Persistence.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configures Emeraude database.
        /// </summary>
        /// <typeparam name="TContextInterface">Interface of the application database context.</typeparam>
        /// <typeparam name="TContextImplementation">Implementation of the application database context.</typeparam>
        /// <param name="services"></param>
        /// <param name="applicationAssembly"></param>
        /// <param name="configuration"></param>
        /// <param name="options"></param>
        /// <returns></returns>
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
                catch (Exception)
                {
                }
            }

            return services;
        }

        /// <summary>
        /// Registers a database initializer.
        /// </summary>
        /// <typeparam name="TInitializerService">Interface of the target database initializer.</typeparam>
        /// <typeparam name="TInitializerImplementation">Implementation class of the target initializer.</typeparam>
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
