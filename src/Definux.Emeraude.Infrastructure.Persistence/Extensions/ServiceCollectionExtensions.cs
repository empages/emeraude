using System;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Infrastructure.Identity.Persistence;
using Definux.Emeraude.Infrastructure.Persistence.Context;
using Definux.Emeraude.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Infrastructure.Persistence.Extensions
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
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="persistenceOptions"></param>
        /// <param name="mainOptions"></param>
        public static void ConfigureDatabases(this IServiceCollection services, IConfiguration configuration, EmPersistenceOptions persistenceOptions, EmMainOptions mainOptions)
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
                        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
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

            // Main entity context instance registration
            persistenceOptions.ContextRegistrationAction(services, persistenceOptions.ContextOptionsBuilder);
            services.AddScoped(typeof(IEmContext), persistenceOptions.ContextImplementationType);
            services.AddScoped(persistenceOptions.ContextInterfaceType, persistenceOptions.ContextImplementationType);

            // Identity context instance registration
            services.AddDbContext<IdentityContextInstance>(persistenceOptions.ContextOptionsBuilder);
            services.AddScoped<IIdentityContext, IdentityContextInstance>();

            services.AddTransient<IDatabaseInitializerManager, DatabaseInitializerManager>();

            if (mainOptions.ExecuteMigrations)
            {
                try
                {
                    var databaseInstance = (DbContext)services
                        .BuildServiceProvider()
                        .GetService(persistenceOptions.ContextImplementationType);

                    databaseInstance
                        ?.Database
                        .Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
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
