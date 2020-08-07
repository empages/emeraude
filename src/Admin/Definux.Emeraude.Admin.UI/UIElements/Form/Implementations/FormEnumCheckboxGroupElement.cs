using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.HtmlBuilder;
using Definux.Utilities.Functions;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormEnumCheckboxGroupElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            Type enumType = (Type)DataSource;
            var enumDictionary = EnumFunctions.GetEnumList(enumType);

            HtmlBuilder = new CheckboxGroupHtmlBuilder<int>(enumDictionary, TargetProperty, (int[])Value);
        }
    }
}
