using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.Persistence.Seed;

/// <inheritdoc cref="IDatabaseInitializerManager"/>
public class DatabaseInitializerManager : IDatabaseInitializerManager
{
    private readonly ILogger<DatabaseInitializerManager> logger;
    private readonly IServiceProvider serviceProvider;
    private readonly List<IDatabaseInitializer> databaseInitializers;

    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseInitializerManager"/> class.
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <param name="logger"></param>
    public DatabaseInitializerManager(IServiceProvider serviceProvider, ILogger<DatabaseInitializerManager> logger)
    {
        this.logger = logger;
        this.serviceProvider = serviceProvider.CreateScope().ServiceProvider;
        this.databaseInitializers = new List<IDatabaseInitializer>();
    }

    /// <inheritdoc/>
    public void LoadDatabaseInitializers(params Type[] initializersTypes)
    {
        foreach (var initializerType in initializersTypes)
        {
            this.databaseInitializers.Add(this.serviceProvider.GetService(initializerType) as IDatabaseInitializer);
        }
    }

    /// <inheritdoc/>
    public async Task SeedAsync()
    {
        if (this.databaseInitializers == null || this.databaseInitializers.Count == 0)
        {
            this.logger.LogInformation("To seed data into database please load database initializers from the Emeraude options");
            return;
        }

        foreach (var initializer in this.databaseInitializers)
        {
            await initializer.SeedAsync();
        }
    }
}