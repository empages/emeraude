using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    public class ErrorNotificationHtmlBuilder : HtmlBuilder.HtmlBuilder
    {
        public ErrorNotificationHtmlBuilder(string message)
        {
            this.StartElement(HtmlTags.Div)
                .WithClasses("w-100 float-left")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("alert alert-danger my-1")
                    .WithAttribute("role", "alert")
                    .Append(message)
                );
        }
    }
}
