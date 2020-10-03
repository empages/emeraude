using System.Linq;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Locales.Constraints
{
    /// <summary>
    /// Implementation of <see cref="IRouteConstraint"/> for language code constraint that validate the request language code.
    /// </summary>
    public class LanguageRouteConstraint : IRouteConstraint
    {
        /// <summary>
        /// Language value property that is applied to the route parameters.
        /// </summary>
        public const string LanguageValueKey = "languageCode";

        /// <summary>
        /// Short name of the language constraint.
        /// </summary>
        public const string LanguageConstraintKey = "lang";

        /// <inheritdoc/>
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var languageStore = (ILanguageStore)httpContext.RequestServices.GetService(typeof(ILanguageStore));

            bool match = false;

            string[] allowedLanguages = languageStore.GetAllLanguageCodes();
            string[] filteredAllowedLanguages = allowedLanguages;

            if (values.ContainsKey(LanguageValueKey))
            {
                string languageCode = values[LanguageValueKey]?.ToString();
                var defaultLanguage = languageStore.GetDefaultLanguage();
                if (defaultLanguage != null)
                {
                    filteredAllowedLanguages = allowedLanguages.Where(x => x != defaultLanguage.Code.ToLower()).ToArray();
                }

                if (languageCode != null &&
                    filteredAllowedLanguages != null &&
                    filteredAllowedLanguages.Count() > 0 &&
                    filteredAllowedLanguages.Contains(languageCode))
                {
                    match = true;
                }
            }

            return match;
        }
    }
}
