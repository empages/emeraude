using System;
using System.Web;
using Definux.HtmlBuilder;
using Ganss.XSS;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for details cards for showing HTML content.
    /// </summary>
    public class DetailsFieldHtmlContentElement : UIElement, IDetailsFieldElement
    {
        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;

        public override void DefineHtmlBuilder()
        {
            string sourceString = string.Empty;
            var sanitizer = new HtmlSanitizer();

            if (this.DataSource != null)
            {
                sourceString = sanitizer.Sanitize(this.DataSource.ToString());
            }

            sourceString = HttpUtility.HtmlDecode(sourceString);
            this.HtmlBuilder.StartElement(HtmlTags.Div)
                .Append(sourceString);
        }
    }
}