using Microsoft.AspNetCore.Mvc.Routing;
using System;

namespace Definux.Emeraude.Locales.Attributes
{
    /// <summary>
    /// Defines language SEO friendly route based on language code (not default language). 
    /// Example for English Language with code 'en': '/items/1' map route '/en/items/1'.
    /// Provides string variable 'languageCode' contains current request language code.
    /// </summary>
    public sealed class LanguageRouteAttribute : Attribute, IRouteTemplateProvider
    {
        public LanguageRouteAttribute(string template)
        {
            Template = ProcessRouteTemplate(template);
        }

        public string Template { get; }

        public int? Order { get; set; }

        public string Name { get; set; }

        private static string ProcessRouteTemplate(string template)
        {
            string resultTemplate = string.Empty;
            string separator = "/";
            if (template.StartsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                resultTemplate += "/";
                separator = string.Empty;
            }

            resultTemplate += "{languageCode:lang}";
            resultTemplate += separator;
            resultTemplate += template;

            return resultTemplate;
        }

    }
}
