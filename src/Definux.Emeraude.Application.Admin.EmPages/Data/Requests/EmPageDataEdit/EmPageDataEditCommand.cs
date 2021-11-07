using System;
using Definux.Emeraude.Application.Admin.EmPages.Schema;
using Definux.Emeraude.Contracts;

namespace Definux.Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <inheritdoc cref="IEmPageDataEditCommand{TEntity,TModel}"/>
    public class EmPageDataEditCommand<TEntity, TModel> : IEmPageDataEditCommand<TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataEditCommand{TEntity,TModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        public EmPageDataEditCommand(Guid entityId, TModel model)
        {
            this.EntityId = entityId;
            this.Model = model;
        }

        /// <inheritdoc/>
        public Guid EntityId { get; set; }

        /// <inheritdoc/>
        public TModel Model { get; set; }
    }
}
