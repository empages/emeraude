using Definux.Emeraude.Domain.Entities;
using System;

namespace Definux.Emeraude.Admin.Requests.Details
{
    public class DetailsQuery<TEntity, TRequestModel> : IDetailsQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        public DetailsQuery(Guid entityId)
        {
            EntityId = entityId;
        }

        public DetailsQuery(Guid entityId, string foreignKeyProperty, string foreignKeyValue)
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
