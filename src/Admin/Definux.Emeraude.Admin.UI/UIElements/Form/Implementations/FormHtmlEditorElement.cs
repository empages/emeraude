using System;
using Definux.HtmlBuilder;
using Ganss.XSS;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders HTML editor.
    /// </summary>
    public class FormHtmlEditorElement : FormElement, IFormElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormHtmlEditorElement"/> class.
        /// </summary>
        public FormHtmlEditorElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var editorId = Guid.NewGuid().ToString().Replace("-", string.Empty);
            this.HtmlBuilder.StartElement(HtmlTags.Div)
                .Append(x => x.OpenElement(HtmlTags.Div)
                    .WithId(editorId)
                    .WithClasses("trumbowyg-editor-selector"))
                .Append(x => x.OpenElement(HtmlTags.Input)
                    .WithAttribute("type", "hidden")
                    .WithAttribute("name", this.TargetProperty)
                    .WithAttribute("value", this.Value?.ToString() ?? string.Empty)
                    .WithId($"trumbowyg-editor-hidden-input-{editorId}"));
        }
    }
}