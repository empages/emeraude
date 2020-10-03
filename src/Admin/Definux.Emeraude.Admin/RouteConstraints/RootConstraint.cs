using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Admin.RouteConstraints
{
    /// <summary>
    /// Implementation of <see cref="IRouteConstraint"/> for the public and private roots.
    /// </summary>
    public class RootConstraint : IRouteConstraint
    {
        /// <summary>
        /// Root value property that is applied to the route parameters.
        /// </summary>
        public const string RootKey = "root";

        /// <summary>
        /// Short name of the root constraint.
        /// </summary>
        public const string RootConstraintKey = "root";

        /// <summary>
        /// Root route slug.
        /// </summary>
        public const string RootRouteSlug = "{" + RootKey + ":" + RootConstraintKey + "}";

        /// <inheritdoc/>
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool match = false;

            if (values.ContainsKey(RootConstraintKey))
            {
                string[] rootsTypes = new string[] { "public", "private" };
                match = rootsTypes.Contains(values[RootConstraintKey]?.ToString());
            }

            return match;
        }
    }
}
