using Definux.HtmlBuilder;
using Definux.Utilities.Options;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("form-visible-recaptcha", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class FormVisibleRecaptchaTagHelper : TagHelper
    {
        private readonly GoogleRecaptchaKeysOptions recaptchaOptions;
        public FormVisibleRecaptchaTagHelper(IOptions<GoogleRecaptchaKeysOptions> options)
        {
            this.recaptchaOptions = options.Value;
        }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Div)
                .WithClasses("form-group")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("g-recaptcha")
                    .WithDataAttribute("sitekey", this.recaptchaOptions.VisibleRecaptcha.SiteKey)
                    .AppendMultiple(xx =>
                    {
                        if (ViewContext.ModelState.ContainsKey("ReCaptcha") && 
                            ViewContext.ModelState["ReCaptcha"].Errors != null && 
                            ViewContext.ModelState["ReCaptcha"].Errors.Count > 0)
                        {
                            foreach (var error in ViewContext.ModelState["ReCaptcha"].Errors)
                            {
                                xx.Append(xxx => xxx
                                    .OpenElement(HtmlTags.Span)
                                    .WithClasses("text-danger text-small")
                                    .Append(error.ErrorMessage)
                                );
                            }
                        }
                    })
                );

            output = htmlBuilder.ApplyToTagHelperOutput(output);

            var headHtmlBuilder = new HtmlBuilder.HtmlBuilder();
            headHtmlBuilder
                .StartElement(HtmlTags.Script)
                .WithAttribute("src", "https://www.google.com/recaptcha/api.js")
                .WithAttribute("async", "true")
                .WithAttribute("defer", "true");

            ViewContext.AppendIntoTheHead(headHtmlBuilder.RenderHtml());

            return base.ProcessAsync(context, output);
        }

    }
}
