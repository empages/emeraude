using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Details
{
    /// <inheritdoc cref="IDetailsQuery{TEntity, TRequestModel}"/>
    public class DetailsQuery<TEntity, TRequestModel> : GenericEntityRequst<TEntity>, IDetailsQuery<TEntity, TRequestModel>
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
        /// <param name="parentExpression"></param>
        public DetailsQuery(Guid entityId, Expression<Func<TEntity, bool>> parentExpression)
        {
            this.EntityId = entityId;
            this.ParentExpression = parentExpression;
        }

        /// <summary>
        /// Id of the entity.
        /// </summary>
        public Guid EntityId { get; set; }
    }
}