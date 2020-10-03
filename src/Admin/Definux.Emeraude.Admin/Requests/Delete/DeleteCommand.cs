using System;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    /// <inheritdoc cref="IDeleteCommand{TEntity}"/>
    public class DeleteCommand<TEntity> : GenericEntityRequst, IDeleteCommand<TEntity>
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
        /// <param name="foreignKeyProperty"></param>
        /// <param name="foreignKeyValue"></param>
        public DeleteCommand(Guid entityId, string foreignKeyProperty, string foreignKeyValue)
        {
            this.EntityId = entityId;
            this.ForeignKeyProperty = foreignKeyProperty;
            this.ForeignKeyValue = foreignKeyValue;
        }

        /// <inheritdoc/>
        public Guid EntityId { get; set; }
    }
}
