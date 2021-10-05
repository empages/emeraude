using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <inheritdoc cref="IEmPageDataDeleteCommand{TEntity}"/>
    public class EmPageDataDeleteCommand<TEntity> : EmPageGenericEntityRequst<TEntity>, IEmPageDataDeleteCommand<TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataDeleteCommand{TEntity}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        public EmPageDataDeleteCommand(Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <inheritdoc/>
        public Guid EntityId { get; set; }
    }
}
