using Definux.Emeraude.Infrastructure.Localization.Services;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Presentation.PlatformBase.TagHelpers
{
    /// <summary>
    /// Tag helper that translate a static content key (placed in the content of the tag helper) based on the language extracted from the route.
    /// </summary>
    [HtmlTargetElement("sc", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class StaticContentTagHelper : TranslationTagHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticContentTagHelper"/> class.
        /// </summary>
        /// <param name="localizer"></param>
        public StaticContentTagHelper(IEmLocalizer localizer)
            : base(localizer)
        {
        }

        /// <inheritdoc/>
        protected override TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            output.TagName = string.IsNullOrEmpty(this.Element) ? "div" : this.Element;
            output.TagMode = TagMode.StartTagAndEndTag;

            string key = output?.GetChildContentAsync()?.Result?.GetContent() ?? string.Empty;

            var content = this.Localizer.GetStaticContent(key);

            content = this.ApplyArguments(content);

            output.Content.Clear();
            output.Content.AppendHtml(new HtmlString(content));

            return output;
        }
    }
}
