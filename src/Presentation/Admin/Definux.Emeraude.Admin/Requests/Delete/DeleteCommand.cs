using Definux.Emeraude.Domain.Entities;
using System;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    public class DeleteCommand<TEntity> : IDeleteCommand<TEntity>
        where TEntity : class, IEntity, new()
    {
        public DeleteCommand(Guid entityId)
        {
            EntityId = entityId;
        }

        public DeleteCommand(Guid entityId, string foreignKeyProperty, string foreignKeyValue)
        {
            EntityId = entityId;
            ForeignKeyProperty = foreignKeyProperty;
            ForeignKeyValue = foreignKeyValue;
        }

        public Guid EntityId { get; set; }

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
