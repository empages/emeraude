using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Render notification alert for container for the content inside.
    /// </summary>
    [HtmlTargetElement("notification-alert", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class NotificationAlertTagHelper : TagHelper
    {
        /// <summary>
        /// Type of the notification (primary, secondary, success, danger, warning, info, light, dark).
        /// </summary>
        [HtmlAttributeName("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Div)
                .WithClasses($"alert alert-{this.Type}")
                .WithAttribute("role", "alert")
                .Append(x => x
                    .OpenElement(HtmlTags.Span)
                    .Append(output.GetChildContentAsync()?.Result?.GetContent()));

            output = htmlBuilder.ApplyToTagHelperOutput(output);

            base.Process(context, output);
        }
    }
}
