using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormTimeElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            TimeSpan? timeValue = null;

            if (Value != null)
            {
                timeValue = (TimeSpan)Value;
            }

            Guid itemId = Guid.NewGuid();

            HtmlBuilder.StartElement(HtmlTags.Div)
                .WithId($"timepicker-{itemId}")
                .WithClasses("input-group date")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithClasses("input-group")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Input)
                        .WithAttribute("type", "text")
                        .WithAttribute("name", TargetProperty)
                        .WithClasses("form-control timepicker-popup")
                        .WithAttributeIf("value", timeValue?.ToString(SystemFormats.TimeFormat), timeValue.HasValue)
                    )
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Div)
                        .WithClasses("input-group-addon input-group-append")
                        .Append(xxx => xxx
                            .OpenElement(HtmlTags.Span)
                            .WithClasses("mdi mdi-clock input-group-text")
                        )
                    )
                );
        }
    }
}
