using Definux.HtmlBuilder;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    [HtmlTargetElement("notification-alert", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class NotificationAlertTagHelper : TagHelper
    {
        [HtmlAttributeName("type")]
        public string Type { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var htmlBuilder = new HtmlBuilder.HtmlBuilder();
            htmlBuilder
                .StartElement(HtmlTags.Div)
                .WithClasses($"alert alert-{Type}")
                .WithAttribute("role", "alert")
                .Append(x => x
                    .OpenElement(HtmlTags.Span)
                    .Append(output.GetChildContentAsync()?.Result?.GetContent())
                );

            output = htmlBuilder.ApplyToTagHelperOutput(output);

            base.Process(context, output);
        }
    }
}
