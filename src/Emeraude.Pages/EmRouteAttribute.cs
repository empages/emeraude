using System;

namespace Emeraude.Pages;

/// <summary>
/// Attribute that defines the route of the page.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class EmRouteAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmRouteAttribute"/> class.
    /// </summary>
    /// <param name="template"></param>
    public EmRouteAttribute(string template)
    {
        if (string.IsNullOrWhiteSpace(template))
        {
            throw new ArgumentNullException(nameof(template));
        }

        this.Template = template;
    }

    /// <summary>
    /// Template of the current route.
    /// </summary>
    public string Template { get; }
}