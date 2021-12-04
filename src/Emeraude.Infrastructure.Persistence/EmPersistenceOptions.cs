using System;
using System.Collections.Generic;
using Emeraude.Configuration.Exceptions;
using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.Persistence.Context;
using Emeraude.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Infrastructure.Persistence;

/// <summary>
/// Options for persistence infrastructure of Emeraude.
/// </summary>
public class EmPersistenceOptions : IEmOptions
{
    private readonly List<Type> databaseInitializers = new ();

    /// <summary>
    /// Provider of database storage for the application.
    /// </summary>
    public DatabaseContextProvider ContextProvider { get; set; }

    /// <summary>
    /// Collection of all database initializers.
    /// </summary>
    public Type[] DatabaseInitializers => this.databaseInitializers.ToArray();

    /// <summary>
    /// Database connection string.
    /// </summary>
    public string ConnectionString { get; set; }

    /// <summary>
    /// Database context options builder. If empty the <see cref="ContextProvider"/> built-in setup will be used.
    /// </summary>
    public Action<DbContextOptionsBuilder> ContextOptionsBuilder { get; set; }

    /// <summary>
    /// Type of the interface of the database context.
    /// </summary>
    public Type ContextInterfaceType { get; private set; }

    /// <summary>
    /// Type of the implementation of the database context.
    /// </summary>
    public Type ContextImplementationType { get; private set; }

    /// <summary>
    /// Action that is invoked on persistence setup.
    /// </summary>
    public Action<IServiceCollection, Action<DbContextOptionsBuilder>> ContextRegistrationAction { get; private set; }

    /// <summary>
    /// Set context interface and its implementation types.
    /// </summary>
    /// <typeparam name="TContextInterface">Interface of the application database context.</typeparam>
    /// <typeparam name="TContextImplementation">Implementation of the application database context.</typeparam>
    public void SetContext<TContextInterface, TContextImplementation>()
        where TContextInterface : class, IEmContext
        where TContextImplementation : EmContext<TContextImplementation>, TContextInterface
    {
        this.ContextInterfaceType = typeof(TContextInterface);
        this.ContextImplementationType = typeof(TContextImplementation);
        this.ContextRegistrationAction = (services, optionsAction) =>
            services.AddDbContext<TContextImplementation>(optionsAction);
    }

    /// <summary>
    /// Register a database initializer into the database initializer manager. The order of adding is the order of calling.
    /// </summary>
    /// <typeparam name="TDatabaseInitializer">Interface type of the database initializer.</typeparam>
    public void AddDatabaseInitializer<TDatabaseInitializer>()
        where TDatabaseInitializer : class, IDatabaseInitializer
    {
        this.databaseInitializers.Add(typeof(TDatabaseInitializer));
    }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public void Validate()
    {
    }
}