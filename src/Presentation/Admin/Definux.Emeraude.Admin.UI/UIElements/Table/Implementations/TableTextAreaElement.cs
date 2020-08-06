using Definux.HtmlBuilder;
using Ganss.XSS;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    public class TableTextAreaElement : UIElement, ITableElement
    {
        public TableTextAreaElement()
            : base()
        {

        }

        public override void DefineHtmlBuilder()
        {
            string sourceString = string.Empty;
            var sanitizer = new HtmlSanitizer();

            if (DataSource != null)
            {
                sourceString = sanitizer.Sanitize(DataSource.ToString());
            }

            HtmlBuilder.StartElement(HtmlTags.Button)
                .WithAttribute("type", "button")
                .WithClasses("btn p-1")
                .WithDataAttribute("placement", "right")
                .WithDataAttribute("toggle", "popover")
                .WithDataAttribute("content", sourceString)
                .Append("See Content");
        }
    }
}
