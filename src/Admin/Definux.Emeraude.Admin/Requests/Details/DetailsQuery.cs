using System;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Details
{
    /// <inheritdoc cref="IDetailsQuery{TEntity, TRequestModel}"/>
    public class DetailsQuery<TEntity, TRequestModel> : GenericEntityRequst, IDetailsQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsQuery{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        public DetailsQuery(Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsQuery{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="foreignKeyProperty"></param>
        /// <param name="foreignKeyValue"></param>
        public DetailsQuery(Guid entityId, string foreignKeyProperty, string foreignKeyValue)
        {
            this.EntityId = entityId;
            this.ForeignKeyProperty = foreignKeyProperty;
            this.ForeignKeyValue = foreignKeyValue;
        }

        /// <summary>
        /// Id of the entity.
        /// </summary>
        public Guid EntityId { get; set; }
    }
}