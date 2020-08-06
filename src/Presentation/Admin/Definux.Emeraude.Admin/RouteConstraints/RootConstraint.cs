using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace Definux.Emeraude.Admin.RouteConstraints
{
    public class RootConstraint : IRouteConstraint
    {
        public const string RootKey = "root";
        public const string RootConstraintKey = "root";
        public const string RootRouteSlug = "{" + RootKey + ":" + RootConstraintKey + "}";

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
