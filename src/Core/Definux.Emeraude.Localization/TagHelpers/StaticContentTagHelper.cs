using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace Definux.Emeraude.Localization.TagHelpers
{
    [HtmlTargetElement("sc", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class StaticContentTagHelper : TranslationTagHelper
    {
        public StaticContentTagHelper(
            ILocalizer localizer, 
            ILocalizationContext localizationContext, 
            ICurrentLanguageProvider currentLanguageProvider)
            : base(localizer, localizationContext, currentLanguageProvider)
        {

        }

        protected override TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            output.TagName = string.IsNullOrEmpty(Element) ? "div" : Element;
            output.TagMode = TagMode.StartTagAndEndTag;

            string key = output?.GetChildContentAsync()?.Result?.GetContent() ?? string.Empty;

            var currentLanguage = this.currentLanguageProvider.GetCurrentLanguage();

            var translation = this.localizationContext
                .StaticContent
                .Where(x => x.ContentKey.Key == key && x.LanguageId == currentLanguage.Id)
                .Select(x => x.Content)
                .FirstOrDefault() ?? string.Empty;

            translation = ApplyArguments(translation);

            output.Content.Clear();
            output.Content.AppendHtml(new HtmlString(translation));

            return output;
        }
    }
}
