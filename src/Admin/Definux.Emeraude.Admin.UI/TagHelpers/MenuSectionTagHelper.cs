using Definux.Emeraude.Admin.UI.AdminMenu;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("menu-section", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class MenuSectionTagHelper : TagHelper
    {
        [HtmlAttributeName("index")]
        public int Index { get; set; }

        [HtmlAttributeName("model")]
        public SidebarMenuSectionItem Model { get; set; }

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
            string sectionIdentificator = $"section{Index}";

            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Li)
                .WithConditionalClasses("active", string.Empty, Model.IsActive, "nav-item main-nav-item")
                .Append(x => x
                    .OpenElement(HtmlTags.A)
                    .WithConditionalClasses("collapsed", string.Empty, Model.IsSingle && Model.IsActive, "nav-link sidebar-main-menu-item")
                    .WithAttribute("title", Model.Title)
                    .WithAttributeIf("href", Model.SingleLinkItem?.DefaultRoute, Model.IsSingle && !Model.Dropdown)
                    .WithAttributeIf("href", $"#{sectionIdentificator}", Model.Dropdown)
                    .WithAttributeIf("aria-controls", sectionIdentificator, !Model.IsSingle)
                    .WithAttributeIf("aria-expanded", Model.IsActive.ToString().ToLower(), Model.Dropdown)
                    .WithAttributeIf("data-toggle", "collapse", Model.Dropdown)
                    .Append(xx => xx
                        .OpenElement(HtmlTags.I)
                        .WithClasses($"menu-icon {Model.Icon}")
                    )
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Span)
                        .WithClasses("menu-title")
                        .Append(Model.Title)
                    )
                    .AppendIf(Model.Dropdown, xx => xx
                        .OpenElement(HtmlTags.I)
                        .WithClasses("menu-arrow")
                    ))
                .AppendIf(Model.Dropdown, x => x
                    .OpenElement(HtmlTags.Div)
                    .WithConditionalClasses("show", string.Empty, Model.IsActive && Model.Dropdown, "collapse")
                    .WithId(sectionIdentificator)
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Ul)
                        .WithClasses("nav flex-column sub-menu")
                        .AppendMultiple(xxx => 
                        {
                            foreach (var child in Model.Children)
                            {
                                xxx.Append(xxxx => xxxx
                                    .OpenElement(HtmlTags.Li)
                                    .WithClasses("nav-item")
                                    .Append(xxxxx => xxxxx
                                        .OpenElement(HtmlTags.A)
                                        .WithConditionalClasses("active", string.Empty, child.IsActive, "nav-link")
                                        .WithAttribute("title", child.Title)
                                        .WithAttribute("href", child.DefaultRoute)
                                        .Append(child.Title)
                                    ));
                            }
                        })
                    ));

            output = htmlBuilder.ApplyToTagHelperOutput(output);
            return output;
        }
    }
}
