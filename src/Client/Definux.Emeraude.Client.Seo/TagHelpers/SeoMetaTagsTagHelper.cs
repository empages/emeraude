using System.Text;
using Definux.Emeraude.Client.Seo.Extensions;
using Definux.Emeraude.Client.Seo.Models;
using Definux.Emeraude.Client.Seo.Options;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Client.Seo.TagHelpers
{
    /// <summary>
    /// Tag helper that create all SEO tags based on the decoration of controller or action.
    /// </summary>
    [HtmlTargetElement("seo-meta-tags", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class SeoMetaTagsTagHelper : TagHelper
    {
        private readonly MetaTagsModel defaultMetaTagsModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeoMetaTagsTagHelper"/> class.
        /// </summary>
        /// <param name="optionsAccessor"></param>
        public SeoMetaTagsTagHelper(IOptions<SeoOptions> optionsAccessor)
        {
            this.defaultMetaTagsModel = optionsAccessor.Value.DefaultMetaTags;
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
            var metaTagsModel = this.ViewContext.ViewData.GetMetaTagsModelOrDefault();
            if (metaTagsModel != null)
            {
                metaTagsModel.ApplyStaticTags(this.defaultMetaTagsModel);

                output.TagName = HtmlTags.Link.Name;
                output.TagMode = TagMode.StartTagOnly;
                output.Attributes.Add("rel", "canonical");
                output.Attributes.Add("href", metaTagsModel.Canonical);

                StringBuilder tagsBuilder = new StringBuilder();
                tagsBuilder.AppendLine($"<meta charset=\"{metaTagsModel.Charset}\" />");

                var startMetaTags = metaTagsModel.GetStartMetaTags();
                foreach (var startMetaTag in startMetaTags)
                {
                    tagsBuilder.AppendLine($"<meta {startMetaTag.KeyName}=\"{startMetaTag.Key}\" {startMetaTag.ValueName}=\"{startMetaTag.Value}\" />");
                }

                tagsBuilder.AppendLine($"<title>{metaTagsModel.Title.Value}</title>");

                var filledMetaTags = metaTagsModel.GetFilledMetaTags();
                foreach (var filledMetaTag in filledMetaTags)
                {
                    tagsBuilder.AppendLine($"<meta {filledMetaTag.KeyName}=\"{filledMetaTag.Key}\" {filledMetaTag.ValueName}=\"{filledMetaTag.Value}\" />");
                }

                output.PreElement.SetHtmlContent(new HtmlString(tagsBuilder.ToString()));
            }
        }
    }
}
