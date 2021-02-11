using System;
using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Built wrapper for HTML builder for date picker input.
    /// </summary>
    public class DatePickerHtmlBuilder : HtmlBuilder.HtmlBuilder
    {
        public DatePickerHtmlBuilder(string targetProperty, DateTime? value, string placeholder)
        {
            var pickerId = Guid.NewGuid().ToString().Replace("-", string.Empty);

            this.StartElement(HtmlTags.Div)
                .WithClasses("datepicker-popup-container")
                .Append(x => x
                    .OpenElement(HtmlTags.Div)
                    .WithId($"datepicker-popup-{pickerId}")
                    .WithClasses("input-group date datepicker datepicker-popup")
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Input)
                        .WithClasses("form-control")
                        .WithAttribute("type", "text")
                        .WithAttribute("placeholder", placeholder)
                        .WithAttribute("value", value?.ToString(SystemFormats.ShortDateFormat)))
                    .Append(xx => xx
                        .OpenElement(HtmlTags.Span)
                        .WithClasses("input-group-addon input-group-append border-left")
                        .Append(xxx => xxx
                            .OpenElement(HtmlTags.Span)
                            .WithClasses("mdi mdi-calendar input-group-text p-2"))))
                .Append(x => x
                    .OpenElement(HtmlTags.Input)
                    .WithId($"datepicker-popup-{pickerId}-hidden")
                    .WithAttribute("type", "hidden")
                    .WithAttribute("name", targetProperty)
                    .WithAttribute("value", this.GetUnixTimeStamp(value)));
        }

        private string GetUnixTimeStamp(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                return ((int)dateTime.Value.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            }

            return null;
        }
    }
}