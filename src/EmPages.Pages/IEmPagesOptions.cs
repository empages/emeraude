using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EmPages.Pages;

/// <summary>
/// Options for configuring EmPages pages.
/// </summary>
public interface IEmPagesOptions
{
    /// <summary>
    /// Collection of all assemblies that will be scanned for pages.
    /// </summary>
    IReadOnlyCollection<Assembly> PagesAssemblies { get; }

    /// <summary>
    /// Represents relation between item types and corresponding <see cref="EmComponent"/>.
    /// Defaults are populated by the framework.
    /// </summary>
    IReadOnlyDictionary<Type, (Type Renderer, Type Mutator)> DefaultTypesToComponentsMapping { get; }
}