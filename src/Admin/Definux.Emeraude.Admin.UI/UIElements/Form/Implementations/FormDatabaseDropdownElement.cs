using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Emeraude.Admin.UI.Utilities;
using Definux.Utilities.Extensions;
using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    public class FormDatabaseDropdownElement : FormElement
    {
        public override void DefineHtmlBuilder()
        {
            var dbContext = (IEmContextAdapter)ServiceProvider.GetService(typeof(IEmContextAdapter));
            var databaseEntities = dbContext.GetAllEntitiesByType((Type)DataSource);
            var databaseEntitiesDictionary = Functions.GetDatabaseEntityDictionary(databaseEntities, VisibleKey);

            HtmlBuilder = new DropdownHtmlBuilder<Guid>(databaseEntitiesDictionary, TargetProperty, Value.GetGuidValueOrDefault(), IsNullable);
        }
    }
}
