using System;
using System.Collections.Generic;
using System.Reflection;
using Emeraude.Identity;
using Emeraude.Pages;
using Emeraude.PortalGateway;
using Microsoft.EntityFrameworkCore;

namespace Emeraude;

/// <summary>
/// Emeraude Framework main options.
/// </summary>
public class EmOptions : IEmPagesOptions, IEmIdentityOptions, IEmPortalGatewayOptions, IDisposable
{
    private readonly Dictionary<Type, (Type Renderer, Type Mutator)> defaultTypesToComponentsMapping;
    private readonly List<string> portalUrls;
    private readonly List<Assembly> pagesAssemblies;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmOptions"/> class.
    /// </summary>
    public EmOptions()
    {
        this.pagesAssemblies = new List<Assembly>();
        this.defaultTypesToComponentsMapping = new Dictionary<Type, (Type Renderer, Type Mutator)>();
        this.portalUrls = new List<string>();
    }

    /// <inheritdoc cref="IEmPagesOptions.PagesAssemblies"/>
    public IReadOnlyCollection<Assembly> PagesAssemblies => this.pagesAssemblies;

    /// <inheritdoc cref="IEmPagesOptions.DefaultTypesToComponentsMapping"/>
    public IReadOnlyDictionary<Type, (Type Renderer, Type Mutator)> DefaultTypesToComponentsMapping => this.defaultTypesToComponentsMapping;

    /// <inheritdoc cref="IEmIdentityOptions.DbContextOptionsBuilder"/>
    public Action<DbContextOptionsBuilder> DbContextOptionsBuilder { get; private set; }

    /// <inheritdoc cref="IEmIdentityOptions.DefaultUserPassword"/>
    public string DefaultUserPassword { get; set; } = "Admin123!";

    /// <inheritdoc/>
    public IReadOnlyList<string> PortalUrls => this.portalUrls;

    /// <inheritdoc/>
    public string GatewayId { get; set; }

    /// <summary>
    /// Configures specified default type to component map.
    /// </summary>
    /// <typeparam name="TType">Primitive type.</typeparam>
    /// <typeparam name="TRenderer">Renderer type.</typeparam>
    /// <typeparam name="TMutator">Mutator type.</typeparam>
    public void ConfigureDefaultTypeToComponentMap<TType, TRenderer, TMutator>()
        where TRenderer : EmRenderer, new()
        where TMutator : EmMutator, new()
    {
        this.defaultTypesToComponentsMapping[typeof(TType)] = (typeof(TRenderer), typeof(TMutator));
    }

    /// <summary>
    /// Configures database context for needs of framework identity.
    /// </summary>
    /// <param name="builder"></param>
    public void ConfigureIdentityDbContext(Action<DbContextOptionsBuilder> builder)
    {
        this.DbContextOptionsBuilder = builder;
    }

    /// <summary>
    /// Adds a portal URL in the gateway options.
    /// </summary>
    /// <param name="url"></param>
    public void AddPortalUrl(string url)
    {
        if (this.portalUrls.Contains(url))
        {
            return;
        }

        this.portalUrls.Add(url);
    }

    /// <summary>
    /// Clears all portal URLs for the gateway options.
    /// </summary>
    public void ClearPortalUrls()
    {
        this.portalUrls.Clear();
    }

    /// <summary>
    /// Adds an assembly for the needs of Emeraude pages.
    /// </summary>
    /// <param name="assemblyName"></param>
    public void AddPagesAssembly(string assemblyName)
    {
        this.AddPagesAssembly(Assembly.Load(assemblyName));
    }

    /// <summary>
    /// Adds an assembly for the needs of Emeraude pages.
    /// </summary>
    /// <param name="assembly"></param>
    public void AddPagesAssembly(Assembly assembly)
    {
        if (this.pagesAssemblies.Contains(assembly))
        {
            return;
        }

        this.pagesAssemblies.Add(assembly);
    }

    /// <summary>
    /// Clears all registered pages assemblies.
    /// </summary>
    public void ClearPagesAssemblies()
    {
        this.pagesAssemblies.Clear();
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        // nothing to dispose
    }
}