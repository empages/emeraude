using Microsoft.AspNetCore.Mvc.Routing;
using System;

namespace Definux.Emeraude.Client.EmPages.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EmRouteAttribute : Attribute, IRouteTemplateProvider
    {
        /// <summary>
        /// Set up the page route.
        /// </summary>
        /// <param name="template"></param>
        public EmRouteAttribute(string template)
        {
            Template = ProcessRouteTemplate(template);
        }

        /// <summary>
        /// Set up the page as home page for the system.
        /// </summary>
        public EmRouteAttribute()
        {
            Template = "/";
        }

        public string Template { get; set; }

        public int? Order { get; set; }

        public string Name { get; set; }

        private static string ProcessRouteTemplate(string template)
        {
            string resultTemplate = template;
            if (template.StartsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                resultTemplate.Substring(1);
            }

            return resultTemplate;
        }
    }
}
