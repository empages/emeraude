using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.HtmlBuilders
{
    /// <summary>
    /// Built wrapper for HTML builder which creates flag element.
    /// </summary>
    public class FlagHtmlBuilder : HtmlBuilder.HtmlBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlagHtmlBuilder"/> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trueValue"></param>
        /// <param name="falseValue"></param>
        public FlagHtmlBuilder(bool value, string trueValue = "Yes", string falseValue = "No")
        {
            this.StartElement(HtmlTags.Div)
                .WithClasses("custom-control custom-checkbox m-auto")
                .Append(x => x
                    .OpenElement(HtmlTags.Input)
                    .WithClasses("custom-control-input")
                    .WithAttribute("type", "checkbox")
                    .WithAttribute("disabled", "disabled")
                    .WithAttributeIf("checked", "checked", value))
                .Append(x => x
                    .OpenElement(HtmlTags.Label)
                    .WithClasses("custom-control-label pt-1")
                    .Append(value ? trueValue : falseValue));
        }
    }
}