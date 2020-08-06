using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Emeraude.Admin.UI.Utilities;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormDatabaseCheckboxGroupElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            var dbContext = (IEmContextAdapter)ServiceProvider.GetService(typeof(IEmContextAdapter));
            var databaseEntities = dbContext.GetAllEntitiesByType((Type)DataSource);
            var databaseEntitiesDictionary = Functions.GetDatabaseEntityDictionary(databaseEntities, VisibleKey);

            HtmlBuilder = new CheckboxGroupHtmlBuilder<Guid>(databaseEntitiesDictionary, TargetProperty, (Guid[])Value);
        }
    }
}
