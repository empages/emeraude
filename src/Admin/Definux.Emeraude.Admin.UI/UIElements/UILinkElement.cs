using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for links.
    /// </summary>
    public class UILinkElement : UIElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UILinkElement"/> class.
        /// </summary>
        public UILinkElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            string sourceString = string.Empty;
            var sanitizer = new HtmlSanitizer();

            if (this.DataSource != null)
            {
                sourceString = sanitizer.Sanitize(this.DataSource.ToString());
            }

            this.HtmlBuilder.StartElement(HtmlTags.A)
                .WithAttribute("href", sourceString)
                .WithAttribute("target", "_blank")
                .Append(sourceString);
        }
    }
}
