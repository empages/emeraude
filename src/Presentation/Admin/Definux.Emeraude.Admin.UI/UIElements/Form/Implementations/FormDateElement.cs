using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormDateElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            DateTime? dateValue = null;

            if (Value != null)
            {
                dateValue = Convert.ToDateTime(Value);
            }

            HtmlBuilder.StartElement(HtmlTags.Div)
                .WithId($"datepicker-popup-{Guid.NewGuid()}")
                .WithClasses("input-group date datepicker datepicker-popup")
                .Append(x => x
                    .OpenElement(HtmlTags.Input)
                    .WithAttribute("type", "text")
                    .WithAttribute("name", $"{TargetProperty}")
                    .WithAttributeIf("value", dateValue?.ToString(SystemFormats.ShortDateFormat), dateValue.HasValue)
                    .WithClasses("form-control")
                )
                .Append(x => x
                    .OpenElement(HtmlTags.Span)
                    .WithClasses("input-group-addon input-group-append border-left")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Span)
                        .WithClasses("mdi mdi-calendar input-group-text")
                    )
                );
        }
    }
}
