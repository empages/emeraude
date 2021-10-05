using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <inheritdoc cref="IEmPageDataEditCommand{TEntity,TRequestModel}"/>
    public class EmPageDataEditCommand<TEntity, TRequestModel> : EmPageGenericEntityRequst<TEntity>, IEmPageDataEditCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataEditCommand{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        public EmPageDataEditCommand(Guid entityId, TRequestModel model)
        {
            this.EntityId = entityId;
            this.Model = model;
        }

        /// <inheritdoc/>
        public Guid EntityId { get; set; }

        /// <inheritdoc/>
        public TRequestModel Model { get; set; }
    }
}
