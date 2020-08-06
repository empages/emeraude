using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Utilities.Functions;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormEnumDropdownElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            var enumDictionary = EnumFunctions.GetEnumList((Type)DataSource);
            HtmlBuilder = new DropdownHtmlBuilder<int>(enumDictionary, TargetProperty, Value is null ? int.MinValue : Convert.ToInt32(Value), IsNullable);
        }
    }
}
