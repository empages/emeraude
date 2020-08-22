using Definux.HtmlBuilder;
using Ganss.XSS;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormHiddenElement : FormElement, IFormElement
    {
        public FormHiddenElement()
            : base()
        {
            InputType = "hidden";
            KeepValue = true;
            Hidden = true;
        }

        public string InputType { get; protected set; }

        public bool KeepValue { get; protected set; }

        public override void DefineHtmlBuilder()
        {
            var sanitizer = new HtmlSanitizer();
            string valueString = sanitizer.Sanitize(Value?.ToString());

            if ((Type)DataSource == typeof(DateTime) && Value != null)
            {
                valueString = (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc) - (DateTime)Value).TotalSeconds.ToString();
            }

            HtmlBuilder.StartElement(HtmlTags.Input)
                .WithAttribute("type", InputType)
                .WithAttribute("name", TargetProperty)
                .WithAttributeIf("value", valueString, KeepValue);
        }
    }
}
