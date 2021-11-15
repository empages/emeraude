using System.Text.RegularExpressions;
using Emeraude.Essentials.Helpers;
using Emeraude.Infrastructure.Localization.Services;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Emeraude.Presentation.PlatformBase.TagHelpers
{
    /// <summary>
    /// Tag helper that translate a translation key (placed in the content of the tag helper) based on the language extracted from the route.
    /// </summary>
    [HtmlTargetElement("t", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class TranslationTagHelper : TagHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationTagHelper"/> class.
        /// </summary>
        /// <param name="localizer"></param>
        public TranslationTagHelper(IEmLocalizer localizer)
        {
            this.Localizer = localizer;
            this.Arguments = new AttributeDictionary();
        }

        /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.Rendering.ViewContext"/>
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        /// <summary>
        /// Element used for tag helper. Default element is span.
        /// </summary>
        [HtmlAttributeName("element")]
        public string Element { get; set; }

        /// <summary>
        /// Flag which true value remove all HTML tags from the tag helper content.
        /// </summary>
        [HtmlAttributeName("strip-html")]
        public bool StripHtml { get; set; }

        /// <summary>
        /// This flag push the execution to convert tag content to key format. That means if you
        /// apply content 'DogName' or 'Dog name' instead of 'DOG_NAME', the tag helper will convert
        /// the content to 'DOG_NAME' internally.
        /// </summary>
        public bool Convert { get; set; }

        /// <summary>
        /// Arguments used for the placeholders in the translation. Usage args-param="parameter".
        /// </summary>
        [HtmlAttributeName("args")]
        public AttributeDictionary Arguments { get; set; }

        /// <summary>
        /// Delimiter start for arguments in the content - default value is '[['.
        /// </summary>
        [HtmlAttributeName("delimiter-start")]
        public string ArgumentsDelimiterStart { get; set; } = "[[";

        /// <summary>
        /// Delimiter end for arguments in the content - default value is ']]'.
        /// </summary>
        [HtmlAttributeName("delimiter-end")]
        public string ArgumentsDelimiterEnd { get; set; } = "]]";

        /// <inheritdoc cref="IEmLocalizer"/>
        protected IEmLocalizer Localizer { get; private set; }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output = this.ProcessOutput(output);

            base.Process(context, output);
        }

        /// <summary>
        /// Processing method for the tag helper.
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        protected virtual TagHelperOutput ProcessOutput(TagHelperOutput output)
        {
            output.TagName = string.IsNullOrEmpty(this.Element) ? "span" : this.Element;
            output.TagMode = TagMode.StartTagAndEndTag;

            string key = output?.GetChildContentAsync()?.Result?.GetContent() ?? string.Empty;
            if (this.StripHtml)
            {
                key = this.StripHtmlTags(key);
            }

            if (this.Convert)
            {
                key = StringUtilities.ConvertToKey(key);
            }

            string translation = this.Localizer.TranslateKey(key);
            translation = this.ApplyArguments(translation);
            output.Content.Clear();
            output.Content.AppendHtml(new HtmlString(translation));

            return output;
        }

        /// <summary>
        /// Remove HTML tags from the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Apply arguments into the value.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected string ApplyArguments(string input)
        {
            if (this.Arguments != null && this.Arguments.Count > 0 && !string.IsNullOrEmpty(input))
            {
                foreach (var argument in this.Arguments)
                {
                    input = input.Replace($"{this.ArgumentsDelimiterStart}{argument.Key}{this.ArgumentsDelimiterEnd}", argument.Value);
                }
            }

            return input;
        }
    }
}
