using Definux.HtmlBuilder;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    public abstract class UIFlagElement : UIElement
    {
        public UIFlagElement()
            : base()
        {

        }

        public override void DefineHtmlBuilder()
        {
            bool castedDataSource = Convert.ToBoolean(DataSource);

            HtmlBuilder.StartElement(HtmlTags.Div)
                .WithClasses("custom-control custom-checkbox m-auto")
                .Append(x => x
                    .OpenElement(HtmlTags.Input)
                    .WithClasses("custom-control-input")
                    .WithAttribute("type", "checkbox")
                    .WithAttribute("disabled", "disabled")
                    .WithAttributeIf("checked", "checked", castedDataSource))
                .Append(x => x
                    .OpenElement(HtmlTags.Label)
                    .WithClasses("custom-control-label pt-1")
                    .Append(castedDataSource ? "Yes" : "No")
                 );
        }
    }
}
