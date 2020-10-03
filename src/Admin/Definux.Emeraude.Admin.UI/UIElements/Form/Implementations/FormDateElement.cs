using System;
using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a date picker.
    /// </summary>
    public class FormDateElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            DateTime? dateValue = null;

            if (this.Value != null)
            {
                dateValue = Convert.ToDateTime(this.Value);
            }

            this.HtmlBuilder.StartElement(HtmlTags.Div)
                .WithId($"datepicker-popup-{Guid.NewGuid()}")
                .WithClasses("input-group date datepicker datepicker-popup")
                .Append(x => x
                    .OpenElement(HtmlTags.Input)
                    .WithAttribute("type", "text")
                    .WithAttribute("name", $"{this.TargetProperty}")
                    .WithAttributeIf("value", dateValue?.ToString(SystemFormats.ShortDateFormat), dateValue.HasValue)
                    .WithClasses("form-control"))
                .Append(x => x
                    .OpenElement(HtmlTags.Span)
                    .WithClasses("input-group-addon input-group-append border-left")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Span)
                        .WithClasses("mdi mdi-calendar input-group-text")));
        }
    }
}
