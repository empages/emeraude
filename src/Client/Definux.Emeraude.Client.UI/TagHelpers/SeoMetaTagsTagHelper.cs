using Definux.Emeraude.Client.UI.Adapters;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Client.UI.TagHelpers
{
    /// <summary>
    /// Tag helper that create all SEO tags based on the decoration of controller or action.
    /// </summary>
    [HtmlTargetElement("seo-meta-tags", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class SeoMetaTagsTagHelper : TagHelper
    {
        private readonly IHtmlMetaTagsBuilder htmlMetaTagsBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeoMetaTagsTagHelper"/> class.
        /// </summary>
        /// <param name="htmlMetaTagsBuilder"></param>
        public SeoMetaTagsTagHelper(IHtmlMetaTagsBuilder htmlMetaTagsBuilder)
        {
            this.htmlMetaTagsBuilder = htmlMetaTagsBuilder;
        }

        /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.Rendering.ViewContext"/>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            this.ProcessTagHelper(context, output);

            base.Process(context, output);
        }

        private void ProcessTagHelper(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = HtmlTags.Meta.Name;
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("name", "framework");
            output.Attributes.Add("content", "Emeraude");
            output.PreElement.SetHtmlContent(this.htmlMetaTagsBuilder.GetCurrentPageMetaTags(this.ViewContext));
        }
    }
}
