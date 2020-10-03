using System.Linq;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Localization.TagHelpers
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
        /// <param name="localizationContext"></param>
        /// <param name="currentLanguageProvider"></param>
        public StaticContentTagHelper(
            ILocalizer localizer,
            ILocalizationContext localizationContext,
            ICurrentLanguageProvider currentLanguageProvider)
            : base(localizer, localizationContext, currentLanguageProvider)
        {
        }

        /// <inheritdoc/>
        protected override TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            output.TagName = string.IsNullOrEmpty(this.Element) ? "div" : this.Element;
            output.TagMode = TagMode.StartTagAndEndTag;

            string key = output?.GetChildContentAsync()?.Result?.GetContent() ?? string.Empty;

            var currentLanguage = this.CurrentLanguageProvider.GetCurrentLanguage();

            var translation = this.LocalizationContext
                .StaticContent
                .Where(x => x.ContentKey.Key == key && x.LanguageId == currentLanguage.Id)
                .Select(x => x.Content)
                .FirstOrDefault() ?? string.Empty;

            translation = this.ApplyArguments(translation);

            output.Content.Clear();
            output.Content.AppendHtml(new HtmlString(translation));

            return output;
        }
    }
}
