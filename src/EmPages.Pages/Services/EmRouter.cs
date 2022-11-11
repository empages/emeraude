using System;
using System.Collections.Generic;
using System.Linq;

namespace EmPages.Pages.Services;

/// <inheritdoc />
internal class EmRouter : IEmRouter
{
    private readonly IEmPageStore schemaStore;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmRouter"/> class.
    /// </summary>
    /// <param name="schemaStore"></param>
    public EmRouter(IEmPageStore schemaStore)
    {
        this.schemaStore = schemaStore;
    }

    /// <inheritdoc/>
    public EmPageDescriptor RouteToPage(string route)
    {
        try
        {
            var rawRouteInstance = new EmPageRoute(route, true);
            var pagesWithSimilarRouteSegments =
                this.schemaStore
                    .PageDescriptors
                    .Where(x => x.PageRoute.Segments.Count() == rawRouteInstance.Segments.Count())
                    .ToList();

            if (!pagesWithSimilarRouteSegments.Any())
            {
                return null;
            }

            var segmentsCount = rawRouteInstance.Segments.Count();
            var builtRoutesPairs = new List<(EmPageDescriptor PageDescriptor, List<(string Raw, string Source, bool Dynamic)> Pair)>();
            foreach (var page in pagesWithSimilarRouteSegments)
            {
                var currentListPair = new List<(string Raw, string Source, bool Dynamic)>();
                for (int i = 0; i < segmentsCount; i++)
                {
                    currentListPair.Add((
                        rawRouteInstance.Segments.ElementAt(i).Value,
                        page.PageRoute.Segments.ElementAt(i).Value,
                        page.PageRoute.Segments.ElementAt(i).Dynamic));
                }

                builtRoutesPairs.Add((page, currentListPair));
            }

            foreach (var pair in builtRoutesPairs)
            {
                if (pair.Pair.Where(x => !x.Dynamic).All(x => x.Raw.ToUpperInvariant() == x.Source.ToUpperInvariant()))
                {
                    return pair.PageDescriptor;
                }
            }

            return null;
        }
        catch
        {
            return null;
        }
    }
}