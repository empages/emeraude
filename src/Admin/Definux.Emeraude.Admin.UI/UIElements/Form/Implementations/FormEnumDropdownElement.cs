using System;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a dropdown based on all options from a specified enumeration.
    /// </summary>
    public class FormEnumDropdownElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var enumDictionary = EnumFunctions.GetEnumList((Type)this.DataSource);
            this.HtmlBuilder = new DropdownHtmlBuilder<int>(enumDictionary, this.TargetProperty, this.Value is null ? int.MinValue : Convert.ToInt32(this.Value), this.IsNullable);
        }
    }
}
