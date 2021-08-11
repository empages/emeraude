using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.ClientBuilder.Shared.Helpers
{
    /// <summary>
    /// Implements object that define the client route structure.
    /// </summary>
    public class ClientRoute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRoute"/> class.
        /// </summary>
        /// <param name="route"></param>
        public ClientRoute(string route)
        {
            this.Route = route;
            if (route != "/" && !string.IsNullOrWhiteSpace(route))
            {
                this.Segments = this.Route.Split("/").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                this.OrderKey = string.Join(
                    string.Empty,
                    this.Segments.Select(this.ExtractOrderKeyFromRouteSegment));
            }
            else
            {
                this.Segments = new[] { string.Empty };
                this.OrderKey = "0";
            }
        }

        /// <summary>
        /// Route value.
        /// </summary>
        public string Route { get; }

        /// <summary>
        /// Route segments.
        /// </summary>
        public string[] Segments { get; }

        /// <summary>
        /// Order key.
        /// </summary>
        public string OrderKey { get; }

        private string ExtractOrderKeyFromRouteSegment(string routeSegment)
        {
            if (string.IsNullOrWhiteSpace(routeSegment))
            {
                return string.Empty;
            }

            string segmentPrefix = string.Empty;
            string segmentText = routeSegment;
            if (routeSegment.StartsWith(":"))
            {
                segmentPrefix = "~";
                segmentText = "param";
            }

            return $"{segmentPrefix}{segmentText}";
        }
    }
}