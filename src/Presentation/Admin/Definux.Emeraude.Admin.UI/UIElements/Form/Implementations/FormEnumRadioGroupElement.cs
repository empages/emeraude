using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.HtmlBuilder;
using Definux.Utilities.Functions;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormEnumRadioGroupElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            var enumDictionary = EnumFunctions.GetEnumList((Type)DataSource);
            HtmlBuilder = new RadioGroupHtmlBuilder<int>(enumDictionary, TargetProperty, Convert.ToInt32(Value));
        }
    }
}
