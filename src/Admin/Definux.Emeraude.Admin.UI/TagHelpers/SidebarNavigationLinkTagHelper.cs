using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("sidebar-navigation-link", TagStructure = TagStructure.WithoutEndTag)]
    public class SidebarNavigationLinkTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;

        public SidebarNavigationLinkTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory;
        }

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("action")]
        public string Action { get; set; }

        [HtmlAttributeName("controller")]
        public string Controller { get; set; }

        [HtmlAttributeName("route-values")]
        public Dictionary<string, object> RouteValues { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            var routeKeys = urlHelper.ActionContext.RouteData.Values.Select(x => x.Key);
            foreach (var routeKey in routeKeys)
            {
                if (routeKey != "area" && routeKey != "controller" && routeKey != "action")
                {
                    urlHelper.ActionContext.RouteData.Values.Remove(routeKey);
                }
            }

            string href = urlHelper.Action(Action, Controller, new { Area = "Admin" });
            if (RouteValues != null)
            {
                RouteValues.Add("Area", "Admin");
                href = urlHelper.Action(Action, Controller, RouteValues);
            }

            bool active = false;
            if (ViewContext.RouteData.Values["controller"].ToString().ToLower() == Controller.ToLower() &&
                ViewContext.RouteData.Values["action"].ToString().ToLower() == Action.ToLower() &&
                ViewContext.RouteData.Values["area"].ToString().ToLower() == "Admin")
            {
                active = true;
                if (RouteValues != null)
                {
                    active = false;
                    if (ViewContext.HttpContext.Request.Path.Value.StartsWith(href, System.StringComparison.OrdinalIgnoreCase))
                    {
                        active = true;
                    }
                }
            }

            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder.StartElement(HtmlTags.Li)
                .WithClasses("nav-item")
                .Append(x => x
                    .OpenElement(HtmlTags.A)
                    .WithConditionalClasses("active", string.Empty, active, "nav-link")
                    .WithAttribute("title", Title)
                    .WithAttribute("href", href)
                    .Append(Title)
                );

            output = htmlBuilder.ApplyToTagHelperOutput(output);
        }
    }
}
