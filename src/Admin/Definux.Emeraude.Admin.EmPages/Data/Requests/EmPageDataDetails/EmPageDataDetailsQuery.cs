using System;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails
{
    /// <inheritdoc cref="IEmPageDataDetailsQuery{TEntity,TRequestModel}"/>
    public class EmPageDataDetailsQuery<TEntity, TRequestModel> : EmPageGenericEntityRequst<TEntity>, IEmPageDataDetailsQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataDetailsQuery{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        public EmPageDataDetailsQuery(Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <summary>
        /// Id of the entity.
        /// </summary>
        public Guid EntityId { get; set; }
    }
}