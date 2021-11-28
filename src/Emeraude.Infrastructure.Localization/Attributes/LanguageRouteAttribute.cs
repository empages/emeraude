using System;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Emeraude.Infrastructure.Localization.Attributes
{
    /// <summary>
    /// Defines language SEO friendly route based on language code (not default language).
    /// Example for English Language with code 'en': '/items/1' map route '/en/items/1'.
    /// Provides string variable 'languageCode' contains current request language code.
    /// </summary>
    public sealed class LanguageRouteAttribute : Attribute, IRouteTemplateProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageRouteAttribute"/> class.
        /// </summary>
        /// <param name="template"></param>
        public LanguageRouteAttribute(string template)
        {
            this.Template = ProcessRouteTemplate(template);
        }

        /// <inheritdoc/>
        public string Template { get; }

        /// <inheritdoc/>
        public int? Order { get; set; }

        /// <inheritdoc/>
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
