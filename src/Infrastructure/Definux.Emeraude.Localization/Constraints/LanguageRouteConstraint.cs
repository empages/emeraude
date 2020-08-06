using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace Definux.Emeraude.Locales.Constraints
{
    public class LanguageRouteConstraint : IRouteConstraint
    {
        public const string LanguageValueKey = "languageCode";
        public const string LanguageConstraintKey = "lang";

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
