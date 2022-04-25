using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Essentials.Extensions;

namespace Emeraude.Pages;

/// <summary>
/// Reflection helpers for the need of pages.
/// </summary>
public static class EmReflectionHelpers
{
    /// <summary>
    /// Gets all pages types that are registered in specified assemblies.
    /// </summary>
    /// <param name="assemblies"></param>
    /// <returns></returns>
    public static IEnumerable<Type> GetPagesTypesFromAssemblies(IEnumerable<Assembly> assemblies)
    {
        var types = new List<Type>();
        foreach (var assembly in assemblies)
        {
            types
                .AddRange(assembly
                    .GetTypes()
                    .Where(x => x.HasInterface<IEmPage>() && x.IsClass && !x.IsAbstract));
        }

        return types;
    }
}