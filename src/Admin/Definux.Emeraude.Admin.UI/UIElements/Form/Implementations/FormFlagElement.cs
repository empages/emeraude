using System;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a checkbox representing a flag.
    /// </summary>
    public class FormFlagElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            this.HtmlBuilder.StartElement(HtmlTags.Div)
                .WithClasses("row m-0")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("custom-control custom-checkbox")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Input)
                        .WithId(this.TargetProperty)
                        .WithClasses("custom-control-input")
                        .WithAttribute("type", "checkbox")
                        .WithAttribute("name", this.TargetProperty)
                        .WithAttribute("value", "true")
                        .WithAttributeIf("checked", "checked", Convert.ToBoolean(this.Value)))
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Label)
                        .WithClasses("custom-control-label")
                        .WithAttribute("for", this.TargetProperty)
                        .Append(this.Label)));
        }
    }
}