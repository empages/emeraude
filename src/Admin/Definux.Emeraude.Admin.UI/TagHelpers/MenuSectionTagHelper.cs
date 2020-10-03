using Definux.Emeraude.Admin.UI.AdminMenu;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Tag helper used for rendering the admin menu section of the administration sidebar.
    /// </summary>
    [HtmlTargetElement("menu-section", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class MenuSectionTagHelper : TagHelper
    {
        /// <summary>
        /// Index of the menu section.
        /// </summary>
        [HtmlAttributeName("index")]
        public int Index { get; set; }

        /// <summary>
        /// Model of the section.
        /// </summary>
        [HtmlAttributeName("model")]
        public SidebarMenuSectionItem Model { get; set; }

        /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.Rendering.ViewContext"/>
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output = this.ProcessOutput(output);

            base.Process(context, output);
        }

        private TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            string sectionIdentificator = $"section{this.Index}";

            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Li)
                .WithConditionalClasses("active", string.Empty, this.Model.IsActive, "nav-item main-nav-item")
                .Append(x => x
                    .OpenElement(HtmlTags.A)
                    .WithConditionalClasses("collapsed", string.Empty, this.Model.IsSingle && this.Model.IsActive, "nav-link sidebar-main-menu-item")
                    .WithAttribute("title", this.Model.Title)
                    .WithAttributeIf("href", this.Model.SingleLinkItem?.DefaultRoute, this.Model.IsSingle && !this.Model.Dropdown)
                    .WithAttributeIf("href", $"#{sectionIdentificator}", this.Model.Dropdown)
                    .WithAttributeIf("aria-controls", sectionIdentificator, !this.Model.IsSingle)
                    .WithAttributeIf("aria-expanded", this.Model.IsActive.ToString().ToLower(), this.Model.Dropdown)
                    .WithAttributeIf("data-toggle", "collapse", this.Model.Dropdown)
                    .Append(xx => xx
                        .OpenElement(HtmlTags.I)
                        .WithClasses($"menu-icon {this.Model.Icon}"))
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Span)
                        .WithClasses("menu-title")
                        .Append(this.Model.Title))
                    .AppendIf(this.Model.Dropdown, xx => xx
                        .OpenElement(HtmlTags.I)
                        .WithClasses("menu-arrow")))
                .AppendIf(this.Model.Dropdown, x => x
                    .OpenElement(HtmlTags.Div)
                    .WithConditionalClasses("show", string.Empty, this.Model.IsActive && this.Model.Dropdown, "collapse")
                    .WithId(sectionIdentificator)
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Ul)
                        .WithClasses("nav flex-column sub-menu")
                        .AppendMultiple(xxx =>
                        {
                            foreach (var child in this.Model.Children)
                            {
                                xxx.Append(xxxx => xxxx
                                    .OpenElement(HtmlTags.Li)
                                    .WithClasses("nav-item")
                                    .Append(xxxxx => xxxxx
                                        .OpenElement(HtmlTags.A)
                                        .WithConditionalClasses("active", string.Empty, child.IsActive, "nav-link")
                                        .WithAttribute("title", child.Title)
                                        .WithAttribute("href", child.DefaultRoute)
                                        .Append(child.Title)));
                            }
                        })));

            output = htmlBuilder.ApplyToTagHelperOutput(output);
            return output;
        }
    }
}
