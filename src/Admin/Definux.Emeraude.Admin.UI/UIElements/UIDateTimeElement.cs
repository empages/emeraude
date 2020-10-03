using System;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for date and time.
    /// </summary>
    public abstract class UIDateTimeElement : UIElement
    {
        private readonly string dateTimeFormat;
        private readonly string typeName;

        /// <summary>
        /// Initializes a new instance of the <see cref="UIDateTimeElement"/> class.
        /// </summary>
        /// <param name="dateTimeFormat"></param>
        /// <param name="typeName"></param>
        public UIDateTimeElement(string dateTimeFormat, string typeName)
            : base()
        {
            this.dateTimeFormat = dateTimeFormat;
            this.typeName = typeName;
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            DateTime? sourceData = null;

            if (this.DataSource != null)
            {
                sourceData = Convert.ToDateTime(this.DataSource);
            }

            string htmlString = sourceData.HasValue ? sourceData.Value.ToString(this.dateTimeFormat) : string.Empty;

            this.HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(htmlString);
        }
    }
}
