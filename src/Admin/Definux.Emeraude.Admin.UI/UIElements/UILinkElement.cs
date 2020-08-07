using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    public class UILinkElement : UIElement
    {
        public UILinkElement()
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

            HtmlBuilder.StartElement(HtmlTags.A)
                .WithAttribute("href", sourceString)
                .WithAttribute("target", "_blank")
                .Append(sourceString);
        }
    }
}
