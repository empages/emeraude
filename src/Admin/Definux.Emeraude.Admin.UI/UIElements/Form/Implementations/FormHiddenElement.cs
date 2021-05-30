using System;
using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a hidden input.
    /// </summary>
    public class FormHiddenElement : FormElement, IFormElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormHiddenElement"/> class.
        /// </summary>
        public FormHiddenElement()
            : base()
        {
            this.InputType = "hidden";
            this.KeepValue = true;
            this.Hidden = true;
        }

        /// <inheritdoc cref="FormTextElement.InputType"/>
        public string InputType { get; protected set; }

        /// <inheritdoc cref="FormTextElement.KeepValue"/>
        public bool KeepValue { get; protected set; }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var sanitizer = new HtmlSanitizer();
            string valueString = sanitizer.Sanitize(this.Value?.ToString());

            if ((Type)this.DataSource == typeof(DateTime) && this.Value != null)
            {
                valueString = (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc) - (DateTime)this.Value).TotalSeconds.ToString();
            }

            this.HtmlBuilder.StartElement(HtmlTags.Input)
                .WithAttribute("type", this.InputType)
                .WithAttribute("name", this.TargetProperty)
                .WithAttributeIf("value", valueString, this.KeepValue);
        }
    }
}
