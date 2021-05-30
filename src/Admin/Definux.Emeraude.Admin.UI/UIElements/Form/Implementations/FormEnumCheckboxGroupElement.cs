using System;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.HtmlBuilder;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a checkbox group based on all options from a specified enumeration.
    /// </summary>
    public class FormEnumCheckboxGroupElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            Type enumType = (Type)this.DataSource;
            var enumDictionary = EnumFunctions.GetEnumList(enumType);

            this.HtmlBuilder = new CheckboxGroupHtmlBuilder<int>(enumDictionary, this.TargetProperty, (int[])this.Value);
        }
    }
}
