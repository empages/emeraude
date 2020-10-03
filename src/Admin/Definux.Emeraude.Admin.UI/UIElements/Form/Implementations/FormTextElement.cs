using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders an input of type text.
    /// </summary>
    public class FormTextElement : FormElement, IFormElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormTextElement"/> class.
        /// </summary>
        public FormTextElement()
            : base()
        {
            this.InputType = "text";
            this.KeepValue = true;
        }

        /// <summary>
        /// Type of the input.
        /// </summary>
        public string InputType { get; protected set; }

        /// <summary>
        /// Flag that indicates whether the value been kept on a page refresh.
        /// </summary>
        public bool KeepValue { get; protected set; }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var sanitizer = new HtmlSanitizer();
            string valueString = sanitizer.Sanitize(this.Value?.ToString());

            this.HtmlBuilder.StartElement(HtmlTags.Input)
                .WithAttribute("type", this.InputType)
                .WithAttribute("name", this.TargetProperty)
                .WithAttribute("placeholder", $"Enter {this.Label}")
                .WithAttributeIf("value", valueString, this.KeepValue)
                .WithAttributeIf("step", "any", this.InputType?.ToLower() == "number")
                .WithClasses("form-control");
        }
    }
}
