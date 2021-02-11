using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Definux.Emeraude.Admin.UI.TagHelpers
{
    /// <summary>
    /// Returns readonly checkbox for flag value.
    /// </summary>
    [HtmlTargetElement("flag", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class FlagTagHelper : TagHelper
    {
        /// <summary>
        /// Value of the flag.
        /// </summary>
        [HtmlAttributeName("value")]
        public bool Value { get; set; }

        /// <summary>
        /// True value of the flag. Default value is 'Yes'.
        /// </summary>
        [HtmlAttributeName("true")]
        public string TrueValue { get; set; } = "Yes";

        /// <summary>
        /// False value of the flag. Default value is 'No'.
        /// </summary>
        [HtmlAttributeName("false")]
        public string FalseValue { get; set; } = "No";

        /// <inheritdoc />
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var flagHtmlBuilder = new FlagHtmlBuilder(this.Value, this.TrueValue, this.FalseValue);
            output = flagHtmlBuilder.ApplyToTagHelperOutput(output);
            base.Process(context, output);
        }
    }
}