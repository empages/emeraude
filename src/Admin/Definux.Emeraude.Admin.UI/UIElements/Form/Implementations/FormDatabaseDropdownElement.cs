using System;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Emeraude.Admin.UI.Utilities;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a dropdown based on all entities from a table of the database.
    /// </summary>
    public class FormDatabaseDropdownElement : FormElement
    {
        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var dbContext = (IEmContextAdapter)this.ServiceProvider.GetService(typeof(IEmContextAdapter));
            var databaseEntities = dbContext.GetAllEntitiesByType((Type)this.DataSource);
            var databaseEntitiesDictionary = Functions.GetDatabaseEntityDictionary(databaseEntities, this.VisibleKey);

            this.HtmlBuilder = new DropdownHtmlBuilder<Guid>(databaseEntitiesDictionary, this.TargetProperty, this.Value.GetGuidValueOrDefault(), this.IsNullable);
        }
    }
}
