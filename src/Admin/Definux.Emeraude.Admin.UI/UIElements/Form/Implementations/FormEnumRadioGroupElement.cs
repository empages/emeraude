using System;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a radio group based on all options from a specified enumeration.
    /// </summary>
    public class FormEnumRadioGroupElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var enumDictionary = EnumFunctions.GetEnumList((Type)this.DataSource);
            this.HtmlBuilder = new RadioGroupHtmlBuilder<int>(enumDictionary, this.TargetProperty, Convert.ToInt32(this.Value));
        }
    }
}
