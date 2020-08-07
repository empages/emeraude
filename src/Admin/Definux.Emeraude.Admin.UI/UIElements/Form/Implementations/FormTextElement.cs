using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormTextElement : FormElement, IFormElement
    {
        public FormTextElement()
            : base()
        {
            InputType = "text";
            KeepValue = true;
        }

        public string InputType { get; protected set; }

        public bool KeepValue { get; protected set; }

        public override void DefineHtmlBuilder()
        {
            var sanitizer = new HtmlSanitizer();
            string valueString = sanitizer.Sanitize(Value?.ToString());

            HtmlBuilder.StartElement(HtmlTags.Input)
                .WithAttribute("type", InputType)
                .WithAttribute("name", TargetProperty)
                .WithAttribute("placeholder", $"Enter {Label}")
                .WithAttributeIf("value", valueString, KeepValue)
                .WithAttributeIf("step", "any", InputType?.ToLower() == "number")
                .WithClasses("form-control");
        }
    }
}
