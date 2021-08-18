using System;
using System.Runtime.Versioning;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Emeraude.Interfaces.Models;
using Definux.Emeraude.Resources;
using Definux.HtmlBuilder;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a date picker.
    /// </summary>
    public class FormDateElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            this.HtmlBuilder = new DatePickerHtmlBuilder(
                this.TargetProperty,
                this.Value as IDateModel,
                StringFunctions.SplitWordsByCapitalLetters(this.TargetProperty));
        }
    }
}
