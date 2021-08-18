using System;
using Definux.Emeraude.Interfaces.Models;
using Definux.Emeraude.Resources;
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

            if (this.DataSource is IDateModel dateModel)
            {
                sourceData = dateModel.ToDateTime();
            }
            else if (this.DataSource is DateTime dateTime)
            {
                sourceData = dateTime;
            }
            else if (this.DataSource is DateTimeOffset offset)
            {
                sourceData = offset.DateTime;
            }

            string htmlString = sourceData.HasValue ? sourceData.Value.ToString(this.dateTimeFormat, SystemFormats.DefaultCultureInfo) : string.Empty;

            this.HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(htmlString);
        }
    }
}
