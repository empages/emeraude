using Definux.Emeraude.Domain.Entities;
using System;

namespace Definux.Emeraude.Admin.Requests.Edit
{
    public class EditCommand<TEntity, TRequestModel> : IEditCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        public EditCommand(Guid entityId, TRequestModel model)
        {
            EntityId = entityId;
            Model = model;
        }

        public EditCommand(Guid entityId, TRequestModel model, string foreignKeyProperty, string foreignKeyValue)
        {
            EntityId = entityId;
            Model = model;
            ForeignKeyProperty = foreignKeyProperty;
            ForeignKeyValue = foreignKeyValue;
        }

        public Guid EntityId { get; set; }

        public TRequestModel Model { get; set; }

        public bool ValidateParent
        {
            get
            {
                return !string.IsNullOrWhiteSpace(ForeignKeyProperty) && !string.IsNullOrWhiteSpace(ForeignKeyValue);
            }
        }

        public string ForeignKeyProperty { get; set; }

        public string ForeignKeyValue { get; set; }
    }
}
