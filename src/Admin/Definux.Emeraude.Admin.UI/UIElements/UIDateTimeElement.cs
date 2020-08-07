using Definux.HtmlBuilder;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    public abstract class UIDateTimeElement : UIElement
    {
        private readonly string dateTimeFormat;
        private readonly string typeName;

        public UIDateTimeElement(string dateTimeFormat, string typeName)
            : base()
        {
            this.dateTimeFormat = dateTimeFormat;
            this.typeName = typeName;
        }

        public override void DefineHtmlBuilder()
        {
            DateTime? sourceData = null;

            if (DataSource != null)
            {
                sourceData = Convert.ToDateTime(DataSource);
            }

            string htmlString = sourceData.HasValue ? sourceData.Value.ToString(dateTimeFormat) : string.Empty;

            HtmlBuilder.StartElement(HtmlTags.Span)
                .Append(htmlString);
        }
    }
}
