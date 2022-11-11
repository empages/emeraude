using System;
using System.Collections.Generic;
using System.Linq;

namespace EmPages.Pages;

/// <summary>
/// Route instance for specific page.
/// </summary>
public class EmPageRoute
{
    private static readonly string[] ReservedFirstSegments = new string[]
    {
        "settings",
        "auth",
        "manage",
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageRoute"/> class.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="ignoreSymbolsProtection"></param>
    public EmPageRoute(string value, bool ignoreSymbolsProtection = false)
    {
        string template = value ?? string.Empty;
        if (template.StartsWith("/"))
        {
            template = template.Substring(1);
        }

        if (string.IsNullOrWhiteSpace(template))
        {
            throw new ArgumentException("Route value must be defined with at least one segment");
        }

        this.Template = template;
        var segmentsValues = template.Split('/');
        var segments = new List<EmPageRouteSegment>();

        if (ReservedFirstSegments.Contains(segmentsValues.FirstOrDefault()?.ToLowerInvariant()))
        {
            throw new ArgumentException($"First route segment should not be [{string.Join(',', ReservedFirstSegments)}] because these segments are reserved");
        }

        foreach (var segmentsValue in segmentsValues)
        {
            segments.Add(new EmPageRouteSegment(segmentsValue, ignoreSymbolsProtection));
        }

        this.Segments = segments;
    }

    /// <summary>
    /// Raw template of the route.
    /// </summary>
    public string Template { get; }

    /// <summary>
    /// Route segments. Example - for template "/dogs/{id}" segments are ["dog", "{id}"].
    /// </summary>
    public IEnumerable<EmPageRouteSegment> Segments { get; }

    /// <summary>
    /// Builds route value for specified arguments.
    /// </summary>
    /// <param name="routeArgs"></param>
    /// <returns></returns>
    public string Build(params string[] routeArgs)
    {
        if (this.Segments.Count(x => x.Dynamic) != routeArgs.Length)
        {
            throw new ArgumentException("Route arguments count must be equal to the route dynamic segments count");
        }

        var routeSegmentsValues = new List<string>();
        var dynamicArgumentIndex = 0;
        foreach (var segment in this.Segments)
        {
            if (!segment.Dynamic)
            {
                routeSegmentsValues.Add(segment.Value);
            }
            else
            {
                routeSegmentsValues.Add(routeArgs[dynamicArgumentIndex]);
                dynamicArgumentIndex++;
            }
        }

        return string.Join('/', routeSegmentsValues);
    }
}