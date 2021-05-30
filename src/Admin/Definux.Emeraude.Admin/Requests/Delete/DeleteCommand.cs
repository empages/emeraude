using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    /// <inheritdoc cref="IDeleteCommand{TEntity}"/>
    public class DeleteCommand<TEntity> : GenericEntityRequst<TEntity>, IDeleteCommand<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCommand{TEntity}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        public DeleteCommand(Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCommand{TEntity}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="parentExpression"></param>
        public DeleteCommand(Guid entityId, Expression<Func<TEntity, bool>> parentExpression)
        {
            this.EntityId = entityId;
            this.ParentExpression = parentExpression;
        }

        /// <inheritdoc/>
        public Guid EntityId { get; set; }
    }
}
