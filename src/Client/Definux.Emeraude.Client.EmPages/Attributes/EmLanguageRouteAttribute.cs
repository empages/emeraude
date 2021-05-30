using System;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Definux.Emeraude.Client.EmPages.Attributes
{
    /// <summary>
    /// Defines language SEO friendly route based on language code (not default language).
    /// Example for English Language with code 'en': '/items/1' map route '/en/items/1'.
    /// Provides string variable 'languageCode' contains current request language code.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EmLanguageRouteAttribute : Attribute, IRouteTemplateProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmLanguageRouteAttribute"/> class.
        /// </summary>
        public EmLanguageRouteAttribute()
        {
            this.Template = "/";
        }

        /// <inheritdoc/>
        public string Template { get; private set; }

        /// <inheritdoc/>
        public int? Order { get; set; }

        /// <inheritdoc/>
        public string Name { get; set; }
    }
}
