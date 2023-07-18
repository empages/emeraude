using System;
using System.Collections.Generic;
using System.Reflection;
using EmPages.Identity;
using EmPages.Pages;
using EmPages.Portal;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmPages;

/// <summary>
/// EmPages Framework main options.
/// </summary>
public class EmOptions : IEmPagesOptions, IEmIdentityOptions, IEmPortalOptions, IDisposable
{
    private readonly List<Assembly> pagesAssemblies;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmOptions"/> class.
    /// </summary>
    public EmOptions()
    {
        this.pagesAssemblies = new List<Assembly>();
        this.IdentityOptions = new IdentityOptions();
        this.ConfigureDefaultIdentityOptions();
    }

    /// <inheritdoc cref="IEmPagesOptions.PagesAssemblies"/>
    public IReadOnlyCollection<Assembly> PagesAssemblies => this.pagesAssemblies;

    /// <inheritdoc cref="IEmIdentityOptions.DbContextOptionsBuilder"/>
    public Action<DbContextOptionsBuilder> DbContextOptionsBuilder { get; private set; }

    /// <inheritdoc cref="IEmIdentityOptions.DefaultUserPassword"/>
    public string DefaultUserPassword { get; set; } = "Admin123!";

    /// <inheritdoc cref="IEmIdentityOptions.AccessTokenSecurityKey"/>
    public string AccessTokenSecurityKey { get; set; }

    /// <inheritdoc cref="IEmIdentityOptions.AccessTokenIssuer"/>
    public string AccessTokenIssuer { get; set; }

    /// <inheritdoc cref="IEmIdentityOptions.AccessTokenExpirationSpan"/>
    public TimeSpan AccessTokenExpirationSpan { get; set; }

    /// <inheritdoc cref="IEmIdentityOptions.IdentityOptions"/>
    public IdentityOptions IdentityOptions { get; }

    /// <summary>
    /// Configures database context for needs of framework identity.
    /// </summary>
    /// <param name="builder"></param>
    public void ConfigureIdentityDbContext(Action<DbContextOptionsBuilder> builder)
    {
        this.DbContextOptionsBuilder = builder;
    }

    /// <summary>
    /// Adds an assembly for the needs of EmPages pages.
    /// </summary>
    /// <param name="assemblyName"></param>
    public void AddPagesAssembly(string assemblyName)
    {
        this.AddPagesAssembly(Assembly.Load(assemblyName));
    }

    /// <summary>
    /// Adds an assembly for the needs of EmPages pages.
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

    private void ConfigureDefaultIdentityOptions()
    {
        this.IdentityOptions.Password.RequireDigit = true;
        this.IdentityOptions.Password.RequireNonAlphanumeric = true;
        this.IdentityOptions.Password.RequireLowercase = true;
        this.IdentityOptions.Password.RequireUppercase = true;
        this.IdentityOptions.Password.RequiredLength = 8;
    }
}