using System;
using Essentials.Extensions;

namespace Emeraude.Pages.Extensions;

/// <summary>
/// Extensions for types.
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Extracts route instance from page type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <exception cref="EmSetupException"></exception>
    public static EmPageRoute ExtractRouteFromPageType(this Type type)
    {
        var routeAttribute = type.GetAttribute<EmRouteAttribute>();
        if (routeAttribute == null)
        {
            throw new EmSetupException("Cannot extract route from page that is not decorated with 'EmRouteAttribute'");
        }

        return new EmPageRoute(routeAttribute.Template);
    }
}