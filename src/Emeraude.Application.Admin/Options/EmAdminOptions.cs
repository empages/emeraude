using System;
using Emeraude.Application.Admin.Adapters;
using Emeraude.Configuration.Options;

namespace Emeraude.Application.Admin.Options;

/// <summary>
/// Options for admin part of Emeraude.
/// </summary>
public class EmAdminOptions : IEmOptions
{
    /// <summary>
    /// Implementation type of <see cref="IAdminMenusBuilder"/>.
    /// </summary>
    public Type AdminMenusBuilderType { get; private set; }

    /// <summary>
    /// Set admin menus builder type.
    /// </summary>
    /// <typeparam name="TAdminMenusBuilder">Admin menus builder implementation type.</typeparam>
    public void SetAdminMenusBuilder<TAdminMenusBuilder>()
        where TAdminMenusBuilder : class, IAdminMenusBuilder
    {
        this.AdminMenusBuilderType = typeof(TAdminMenusBuilder);
    }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public void Validate()
    {
    }
}