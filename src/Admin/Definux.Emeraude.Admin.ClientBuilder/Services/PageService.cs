using Definux.Emeraude.Admin.ClientBuilder.Models;
using Definux.Emeraude.Admin.ClientBuilder.Options;
using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Services
{
    public class PageService : IPageService
    {
        private readonly ClientBuilderOptions clientBuilderOptions;
        public PageService(IOptions<ClientBuilderOptions> clientBuilderOptions)
        {
            this.clientBuilderOptions = clientBuilderOptions.Value;
        }

        public List<Page> GetAllPages()
        {
            var options = this.clientBuilderOptions;
            List<Type> emPagesTypes = new List<Type>();
            foreach (var assembly in options.Assemblies)
            {
                var assemblyTypes = assembly.GetTypes().Where(x => x.GetInterfaces().Any(y => y == typeof(IEmPage)) && !x.IsAbstract).ToList();
                emPagesTypes.AddRange(assemblyTypes);
            }

            emPagesTypes = emPagesTypes.Distinct().ToList();

            List<Page> resultPages = new List<Page>();
            foreach (var pageType in emPagesTypes)
            {
                string pageName = pageType.Name;
                if (pageName.EndsWith("Page", StringComparison.OrdinalIgnoreCase))
                {
                    pageName = pageName.Substring(0, pageName.Length - 4);
                }

                var routeAttribute = pageType.GetAttribute<EmRouteAttribute>();
                string routeTemplate = routeAttribute.Template;
                string clientRouteTemplate = ConvertAspNetRouteToVueRoute(routeTemplate);

                var initialStateModelType = pageType.GetProperty("InitialStateModel").PropertyType;
                var initialStateModelDataType = pageType.GetProperty("InitialStateModelData").PropertyType;
                var initialStateModelDataRequestType = pageType.GetProperty("InitialStateModelDataRequest").PropertyType;

                Page currentPage = new Page
                {
                    Id = $"{pageType.FullName.ToString().ToLower().Replace('.', '-')}",
                    Name = pageName,
                    Authorized = pageType.HasAttribute<AuthorizeAttribute>(),
                    Route = routeTemplate,
                    InitialStateModelType = initialStateModelType,
                    InitialStateModelClass = DescriptionExtractor.ExtractClassDescription(initialStateModelType),
                    ClientRoute = clientRouteTemplate
                };

                if (resultPages.FirstOrDefault(x => x.Id == currentPage.Id) == null)
                {
                    resultPages.Add(currentPage);
                }
            }

            return ReorderPagesBasedOnClientRoute(resultPages);
        }

        private string ConvertAspNetRouteToVueRoute(string aspNetRoute)
        {
            if (aspNetRoute == "/")
            {
                return aspNetRoute;
            }

            string[] routeComponents = aspNetRoute.Split('/');
            for (int i = 0; i < routeComponents.Length; i++)
            {
                if (routeComponents[i].StartsWith("{", StringComparison.OrdinalIgnoreCase) &&
                    routeComponents[i].EndsWith("}", StringComparison.OrdinalIgnoreCase))
                {
                    routeComponents[i] = ":" + routeComponents[i]
                        .Replace("/", string.Empty)
                        .Replace("{", string.Empty)
                        .Replace("}", string.Empty)
                        .Replace("*", string.Empty)
                        .Split(':')
                        .FirstOrDefault();
                }
            }

            routeComponents = routeComponents.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            return $"/{string.Join("/", routeComponents)}";
        }

        private List<Page> ReorderPagesBasedOnClientRoute(List<Page> pages)
        {
            var reorderedPages = new List<Page>();
            var reorderingDictionary = new List<RouteKeyPagePair>();
            foreach (var page in pages)
            {
                string orderKey = "";
                if (page.ClientRoute == "/" || string.IsNullOrWhiteSpace(page.ClientRoute))
                {
                    orderKey = "0";
                }
                else
                {
                    orderKey = string.Join(string.Empty, page.ClientRoute.Split('/').Select(x => ExtractOrderKeyFromRouteSegment(x)));
                }

                reorderingDictionary.Add(new RouteKeyPagePair
                {
                    Key = orderKey,
                    Page = page
                });
            }

            var keys = reorderingDictionary.Select(x => x.Key).ToList();
            keys.Sort(StringComparer.Ordinal);

            foreach (var key in keys)
            {
                reorderedPages.Add(reorderingDictionary.FirstOrDefault(x => x.Key == key).Page);
            }

            return reorderedPages;
        }

        private string ExtractOrderKeyFromRouteSegment(string routeSegment)
        {
            if (string.IsNullOrWhiteSpace(routeSegment))
            {
                return string.Empty;
            }

            int startIndex = 0;
            string segmentPrefix = string.Empty;
            if (routeSegment.StartsWith(":"))
            {
                startIndex = 1;
                segmentPrefix = "~";
            }

            int segmentLength = routeSegment.Length - startIndex;
            string segmentText = routeSegment.Substring(startIndex);

            return $"{segmentPrefix}{segmentText}{segmentLength}";
        }

        internal class RouteKeyPagePair
        {
            internal string Key { get; set; }

            internal Page Page { get; set; }
        }
    }
}
