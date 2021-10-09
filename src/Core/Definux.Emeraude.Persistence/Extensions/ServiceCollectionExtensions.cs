using System;
using Definux.Emeraude.Application.Persistence;
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
        private const string DatabaseConnectionStringKey = "EntityContext";

        /// <summary>
        /// Configures Emeraude database.
        /// </summary>
        /// <typeparam name="TContextInterface">Interface of the application database context.</typeparam>
        /// <typeparam name="TContextImplementation">Implementation of the application database context.</typeparam>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="persistenceOptions"></param>
        /// <param name="mainOptions"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureDatabases<TContextInterface, TContextImplementation>(this IServiceCollection services, IConfiguration configuration, EmPersistenceOptions persistenceOptions, EmMainOptions mainOptions)
            where TContextInterface : class, IEmContext
            where TContextImplementation : EmContext<TContextImplementation>, TContextInterface
        {
            string connectionString = configuration.GetConnectionString(DatabaseConnectionStringKey);

            if (persistenceOptions.ContextOptionsBuilder == null)
            {
                switch (persistenceOptions.ContextProvider)
                {
                    case DatabaseContextProvider.MicrosoftSqlServer:
                        persistenceOptions.ContextOptionsBuilder = contextOptions =>
                            contextOptions.UseSqlServer(
                                connectionString,
                                b => b.MigrationsAssembly(mainOptions.InfrastructureAssembly));
                        break;
                    case DatabaseContextProvider.PostgreSql:
                        persistenceOptions.ContextOptionsBuilder = contextOptions =>
                            contextOptions.UseNpgsql(
                                connectionString,
                                b => b.MigrationsAssembly(mainOptions.InfrastructureAssembly));
                        break;
                    case DatabaseContextProvider.InMemoryDatabase:
                        persistenceOptions.ContextOptionsBuilder = contextOptions =>
                            contextOptions.UseInMemoryDatabase(databaseName: "InMemoryEntityContextDatabase");
                        break;
                }
            }

            if (persistenceOptions.ContextOptionsBuilder == null)
            {
                throw new InvalidOperationException("Database provider is not configured properly.");
            }

            services.AddDbContext<TContextImplementation>(persistenceOptions.ContextOptionsBuilder);
            services.AddDbContextFactory<TContextImplementation>(persistenceOptions.ContextOptionsBuilder, ServiceLifetime.Scoped);

            services.AddScoped<IEmContextFactory, EmContextFactory<TContextImplementation>>();
            services.AddScoped<IEmContext, TContextImplementation>();
            services.AddScoped<TContextInterface, TContextImplementation>();
            services.AddTransient<IDatabaseInitializerManager, DatabaseInitializerManager>();

            if (mainOptions.ExecuteMigrations)
            {
                try
                {
                    services
                        .BuildServiceProvider()
                        .GetService<TContextImplementation>()
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
