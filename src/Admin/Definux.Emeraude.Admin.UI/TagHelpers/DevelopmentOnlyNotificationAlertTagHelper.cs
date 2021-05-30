using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Warning alert for pages which will be seen only in development.
    /// </summary>
    [HtmlTargetElement("development-only-notification-alert", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class DevelopmentOnlyNotificationAlertTagHelper : TagHelper
    {
        private const string WarningMessage = "The current page is available only in a development environment. After deployment access to this page will be denied.";

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Div)
                .WithClasses($"alert alert-warning")
                .WithAttribute("role", "alert")
                .Append(x => x
                    .OpenElement(HtmlTags.Span)
                    .Append(WarningMessage));

            output = htmlBuilder.ApplyToTagHelperOutput(output);

            base.Process(context, output);
        }
    }
}
