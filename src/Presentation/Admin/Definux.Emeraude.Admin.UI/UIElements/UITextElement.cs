using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    public abstract class UITextElement : UIElement
    {
        public UITextElement()
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

            HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(sourceString);
        }
    }
}
