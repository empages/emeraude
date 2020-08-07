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
                    .WithClasses("form-check form-check-flat col-4")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Label)
                        .WithClasses("form-check-label")
                        .Append(xxx => xxx
                            .OpenElement(HtmlTags.Input)
                            .WithId($"flat-checkbox-{Guid.NewGuid()}")
                            .WithAttribute("type", "checkbox")
                            .WithAttribute("name", TargetProperty)
                            .WithAttributeIf("checked", "checked", Convert.ToBoolean(Value))
                            .WithAttribute("value", "true")
                            .WithClasses("form-check-input")
                        )
                        .Append($" {this.Label} ")
                        .Append(xxx => xxx
                            .OpenElement(HtmlTags.I)
                            .WithClasses("input-helper")
                        )
                    )
                );
        }
    }
}
