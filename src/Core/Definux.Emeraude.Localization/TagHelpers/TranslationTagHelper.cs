using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.RegularExpressions;

namespace Definux.Emeraude.Localization.TagHelpers
{
    [HtmlTargetElement("t", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class TranslationTagHelper : TagHelper
    {
        protected readonly ILocalizer localizer;
        protected readonly ILocalizationContext localizationContext;
        protected readonly ICurrentLanguageProvider currentLanguageProvider;

        public TranslationTagHelper(
            ILocalizer localizer,
            ILocalizationContext localizationContext,
            ICurrentLanguageProvider currentLanguageProvider)
        {
            this.localizer = localizer;
            this.localizationContext = localizationContext;
            this.currentLanguageProvider = currentLanguageProvider;

            Arguments = new AttributeDictionary();
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName("element")]
        public string Element { get; set; }

        [HtmlAttributeName("strip-html")]
        public bool StripHtml { get; set; }

        [HtmlAttributeName("args")]
        public AttributeDictionary Arguments { get; set; }

        /// <summary>
        /// Delimiter start for arguments in the static content - default value is '[['
        /// </summary>
        [HtmlAttributeName("delimiter-start")]
        public string ArgumentsDelimiterStart { get; set; } = "[[";

        /// <summary>
        /// Delimiter end for arguments in the static content - default value is ']]'
        /// </summary>
        [HtmlAttributeName("delimiter-end")]
        public string ArgumentsDelimiterEnd { get; set; } = "]]";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output = ProcessOutput(output);

            base.Process(context, output);
        }

        protected virtual TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            output.TagName = string.IsNullOrEmpty(Element) ? "span" : Element;
            output.TagMode = TagMode.StartTagAndEndTag;

            string key = output?.GetChildContentAsync()?.Result?.GetContent() ?? string.Empty;
            if (StripHtml)
            {
                key = StripHtmlTags(key);
            }

            string translation = this.localizer.TranslateKey(key);
            translation = ApplyArguments(translation);
            output.Content.Clear();
            output.Content.AppendHtml(new HtmlString(translation));

            return output;
        }

        protected string StripHtmlTags(string input)
        {
            try
            {
                Regex regex = new Regex("<.*?>");
                return regex.Replace(input, string.Empty);
            }
            catch (System.Exception)
            {
                return input;
            }
        }

        protected string ApplyArguments(string input)
        {
            if (Arguments != null && Arguments.Count > 0 && !string.IsNullOrEmpty(input))
            {
                foreach (var argument in Arguments)
                {
                    input = input.Replace($"{ArgumentsDelimiterStart}{argument.Key}{ArgumentsDelimiterEnd}", argument.Value);
                }
            }

            return input;
        }
    }
}
