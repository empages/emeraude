using System;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <inheritdoc cref="IEmPageDataCreateCommand{TEntity,TRequestModel}"/>
    public class EmPageDataCreateCommand<TEntity, TRequestModel> : EmPageGenericNewEntityRequest<TEntity>, IEmPageDataCreateCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataCreateCommand{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="model"></param>
        public EmPageDataCreateCommand(TRequestModel model)
        {
            this.Model = model;
        }

        /// <inheritdoc/>
        public TRequestModel Model { get; set; }
    }
}
