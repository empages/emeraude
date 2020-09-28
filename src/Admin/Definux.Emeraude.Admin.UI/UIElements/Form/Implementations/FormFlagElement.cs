using Definux.HtmlBuilder;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormFlagElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            HtmlBuilder.StartElement(HtmlTags.Div)
                .WithClasses("row m-0")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("custom-control custom-checkbox")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Input)
                        .WithId(this.TargetProperty)
                        .WithClasses("custom-control-input")
                        .WithAttribute("type", "checkbox")
                        .WithAttribute("name", TargetProperty)
                        .WithAttributeIf("checked", "checked", Convert.ToBoolean(Value)))
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Label)
                        .WithClasses("custom-control-label")
                        .WithAttribute("for", this.TargetProperty)
                        .Append(this.Label)
                 ));
        }
    }
}
