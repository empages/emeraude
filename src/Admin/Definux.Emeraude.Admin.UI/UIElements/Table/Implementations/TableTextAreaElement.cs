using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> that shows text area for tables.
    /// </summary>
    public class TableTextAreaElement : UIElement, ITableElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableTextAreaElement"/> class.
        /// </summary>
        public TableTextAreaElement()
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

            this.HtmlBuilder.StartElement(HtmlTags.Button)
                .WithAttribute("type", "button")
                .WithClasses("btn p-1")
                .WithDataAttribute("placement", "right")
                .WithDataAttribute("toggle", "popover")
                .WithDataAttribute("content", sourceString)
                .Append("See Content");
        }
    }
}
