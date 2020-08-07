using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("menu-section", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class MenuSectionTagHelper : TagHelper
    {
        [HtmlAttributeName("controllers")]
        public List<string> Controllers { get; set; }

        [HtmlAttributeName("controller")]
        public string Controller { get; set; }

        [HtmlAttributeName("index")]
        public int Index { get; set; }

        [HtmlAttributeName("icon")]
        public string Icon { get; set; }

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("href")]
        public string Href { get; set; }

        [HtmlAttributeName("single")]
        public bool Single { get; set; }


        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output = ProcessOutput(output);

            base.Process(context, output);
        }

        private TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            var controllersNames = Controllers?.Select(x => x.ToLower()).ToList();
            string sectionIdentificator = $"section{Index}";
            string routeController = ViewContext.RouteData.Values["controller"].ToString().ToLower();
            bool collapsed = controllersNames != null ? !controllersNames.Contains(routeController) : !Controller.ToLower().Equals(routeController);

            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Li)
                .WithConditionalClasses(string.Empty, "active", collapsed, "nav-item main-nav-item")
                .Append(x => x
                    .OpenElement(HtmlTags.A)
                    .WithConditionalClasses("collapsed", string.Empty, Single && collapsed, "nav-link")
                    .WithAttribute("title", Title)
                    .WithAttributeIf("href", Href, Single)
                    .WithAttributeIf("href", $"#{sectionIdentificator}", !Single)
                    .WithAttributeIf("aria-controls", sectionIdentificator, !Single)
                    .WithAttributeIf("aria-expanded", (!collapsed).ToString().ToLower(), !Single)
                    .WithAttributeIf("data-toggle", "collapse", !Single)
                    .Append(xx => xx
                        .OpenElement(HtmlTags.I)
                        .WithClasses($"menu-icon {Icon}")
                    )
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Span)
                        .WithClasses("menu-title")
                        .Append(Title)
                    )
                    .AppendIf(!Single, xx => xx
                        .OpenElement(HtmlTags.I)
                        .WithClasses("menu-arrow")
                    ))
                .AppendIf(!Single, x => x
                    .OpenElement(HtmlTags.Div)
                    .WithConditionalClasses(string.Empty, "show", collapsed, "collapse")
                    .WithId(sectionIdentificator)
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Ul)
                        .WithClasses("nav flex-column sub-menu")
                        .Append(output.GetChildContentAsync()?.Result?.GetContent())
                    ));

            output = htmlBuilder.ApplyToTagHelperOutput(output);
            return output;
        }
    }
}
