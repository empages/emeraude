using Microsoft.AspNetCore.Mvc.Routing;
using System;

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
        public EmLanguageRouteAttribute()
        {
            Template = "/";
        }

        public string Template { get; private set; }

        public int? Order { get; set; }

        public string Name { get; set; }
    }
}
