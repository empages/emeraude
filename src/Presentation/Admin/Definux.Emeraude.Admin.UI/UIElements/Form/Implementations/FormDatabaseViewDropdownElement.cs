using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Emeraude.Admin.UI.UIElements.Form.Helpers;
using Definux.Utilities.Extensions;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormDatabaseViewDropdownElement : FormElement
    {
        public FormDatabaseViewDropdownElement()
            : base()
        {

        }

        public override void DefineHtmlBuilder()
        {
            var entitySample = (IFormElementDatabaseView)ServiceProvider.GetService((Type)DataSource);

            HtmlBuilder = new DropdownHtmlBuilder<Guid>((Dictionary<Guid, string>)entitySample, TargetProperty, Value.GetGuidValueOrDefault(), IsNullable);
        }
    }
}
