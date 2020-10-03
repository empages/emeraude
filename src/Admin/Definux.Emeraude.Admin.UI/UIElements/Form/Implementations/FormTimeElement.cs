using System;
using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a time picker.
    /// </summary>
    public class FormTimeElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            TimeSpan? timeValue = null;

            if (this.Value != null)
            {
                timeValue = (TimeSpan)this.Value;
            }

            Guid itemId = Guid.NewGuid();

            this.HtmlBuilder.StartElement(HtmlTags.Div)
                .WithId($"timepicker-{itemId}")
                .WithClasses("input-group date")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("input-group")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Input)
                        .WithAttribute("type", "text")
                        .WithAttribute("name", this.TargetProperty)
                        .WithClasses("form-control timepicker-popup")
                        .WithAttributeIf("value", timeValue?.ToString(SystemFormats.TimeFormat), timeValue.HasValue))
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Div)
                        .WithClasses("input-group-addon input-group-append")
                        .Append(xxx => xxx
                            .OpenElement(HtmlTags.Span)
                            .WithClasses("mdi mdi-clock input-group-text"))));
        }
    }
}
