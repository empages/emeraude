using System;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Returns datepicker input.
    /// </summary>
    [HtmlTargetElement("datepicker", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class DatePickerTagHelper : TagHelper
    {
        /// <summary>
        /// Current value of the datepicker.
        /// </summary>
        [HtmlAttributeName("value")]
        public DateTime? Value { get; set; }

        /// <summary>
        /// Target property name of the datepicker.
        /// </summary>
        [HtmlAttributeName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The placeholder text of the datepicker.
        /// </summary>
        [HtmlAttributeName("placeholder")]
        public string Placeholder { get; set; }

        /// <inheritdoc />
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var htmlBuilder = new DatePickerHtmlBuilder(this.Name, this.Value, this.Placeholder);
            output = htmlBuilder.ApplyToTagHelperOutput(output);
            base.Process(context, output);
        }
    }
}