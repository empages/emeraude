using System;
using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for texts.
    /// </summary>
    public abstract class UITextElement : UIElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UITextElement"/> class.
        /// </summary>
        public UITextElement()
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

            this.HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(sourceString);
        }
    }
}
