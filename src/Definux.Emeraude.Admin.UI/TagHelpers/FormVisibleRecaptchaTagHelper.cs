using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Tag helper that add visible recaptcha input + all required scripts into the head and body.
    /// </summary>
    [HtmlTargetElement("form-visible-recaptcha", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class FormVisibleRecaptchaTagHelper : TagHelper
    {
        private readonly GoogleRecaptchaKeysOptions recaptchaOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormVisibleRecaptchaTagHelper"/> class.
        /// </summary>
        /// <param name="optionsAccessor"></param>
        public FormVisibleRecaptchaTagHelper(IOptions<GoogleRecaptchaKeysOptions> optionsAccessor)
        {
            this.recaptchaOptions = optionsAccessor.Value;
        }

        /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.Rendering.ViewContext"/>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        /// <inheritdoc/>
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Div)
                .WithClasses("form-group")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("g-recaptcha")
                    .WithDataAttribute("sitekey", this.recaptchaOptions.SiteKey)
                    .AppendMultiple(xx =>
                    {
                        if (this.ViewContext.ModelState.ContainsKey("ReCaptcha") &&
                            this.ViewContext.ModelState["ReCaptcha"].Errors != null &&
                            this.ViewContext.ModelState["ReCaptcha"].Errors.Count > 0)
                        {
                            foreach (var error in this.ViewContext.ModelState["ReCaptcha"].Errors)
                            {
                                xx.Append(xxx => xxx
                                    .OpenElement(HtmlTags.Span)
                                    .WithClasses("text-danger text-small")
                                    .Append(error.ErrorMessage));
                            }
                        }
                    }));

            output = htmlBuilder.ApplyToTagHelperOutput(output);

            var headHtmlBuilder = new HtmlBuilder.HtmlBuilder();
            headHtmlBuilder
                .StartElement(HtmlTags.Script)
                .WithAttribute("src", "https://www.google.com/recaptcha/api.js")
                .WithAttribute("async", "true")
                .WithAttribute("defer", "true");

            this.ViewContext.AppendIntoTheHead(headHtmlBuilder.RenderHtml());

            return base.ProcessAsync(context, output);
        }
    }
}
