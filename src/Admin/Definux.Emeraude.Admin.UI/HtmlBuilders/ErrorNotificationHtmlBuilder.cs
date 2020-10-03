using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Built wrapper for HTML builder which creates error notification element with error message.
    /// </summary>
    public class ErrorNotificationHtmlBuilder : HtmlBuilder.HtmlBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNotificationHtmlBuilder"/> class.
        /// </summary>
        /// <param name="message"></param>
        public ErrorNotificationHtmlBuilder(string message)
        {
            this.StartElement(HtmlTags.Div)
                .WithClasses("w-100 float-left")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("alert alert-danger my-1")
                    .WithAttribute("role", "alert")
                    .Append(message));
        }
    }
}
