using System;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Definux.Emeraude.Client.EmPages.Attributes
{
    /// <summary>
    /// Defines the route of current EmPage.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EmRouteAttribute : Attribute, IRouteTemplateProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmRouteAttribute"/> class.
        /// Set up the page route.
        /// </summary>
        /// <param name="template"></param>
        public EmRouteAttribute(string template)
        {
            this.Template = ProcessRouteTemplate(template);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmRouteAttribute"/> class.
        /// Set up the page as home page for the system.
        /// </summary>
        public EmRouteAttribute()
        {
            this.Template = "/";
        }

        /// <inheritdoc/>
        public string Template { get; set; }

        /// <inheritdoc/>
        public int? Order { get; set; }

        /// <inheritdoc/>
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
