using System;
using Definux.Emeraude.Interfaces.Models;
using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Built wrapper for HTML builder for date picker input.
    /// </summary>
    public class DatePickerHtmlBuilder : HtmlBuilder.HtmlBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatePickerHtmlBuilder"/> class.
        /// </summary>
        /// <param name="targetProperty"></param>
        /// <param name="value"></param>
        /// <param name="placeholder"></param>
        public DatePickerHtmlBuilder(string targetProperty, IDateModel value, string placeholder)
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
                        .WithClasses("form-control bg-white")
                        .WithAttribute("type", "text")
                        .WithAttribute("readonly", "readonly")
                        .WithAttribute("placeholder", placeholder)
                        .WithAttribute("value", value?.ToDateTime().ToString(SystemFormats.ShortDateFormat)))
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
                    .WithAttribute("value", value?.ToDateTime().ToString(SystemFormats.DateModelFormat)));
        }
    }
}