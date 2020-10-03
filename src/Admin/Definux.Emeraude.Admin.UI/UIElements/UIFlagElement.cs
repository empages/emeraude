using System;
using Definux.HtmlBuilder;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for flags.
    /// </summary>
    public abstract class UIFlagElement : UIElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UIFlagElement"/> class.
        /// </summary>
        public UIFlagElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            bool castedDataSource = Convert.ToBoolean(this.DataSource);

            this.HtmlBuilder.StartElement(HtmlTags.Div)
                .WithClasses("custom-control custom-checkbox m-auto")
                .Append(x => x
                    .OpenElement(HtmlTags.Input)
                    .WithClasses("custom-control-input")
                    .WithAttribute("type", "checkbox")
                    .WithAttribute("disabled", "disabled")
                    .WithAttributeIf("checked", "checked", castedDataSource))
                .Append(x => x
                    .OpenElement(HtmlTags.Label)
                    .WithClasses("custom-control-label pt-1")
                    .Append(castedDataSource ? "Yes" : "No"));
        }
    }
}
