using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Create
{
    /// <inheritdoc cref="ICreateCommand{TEntity, TRequestModel}"/>
    public class CreateCommand<TEntity, TRequestModel> : GenericNewEntityRequest<TEntity>, ICreateCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommand{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="model"></param>
        public CreateCommand(TRequestModel model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommand{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="parentProperty"></param>
        /// <param name="parentId"></param>
        public CreateCommand(TRequestModel model, string parentProperty, Guid? parentId)
        {
            this.Model = model;
            this.ParentProperty = parentProperty;
            this.ParentId = parentId;
        }

        /// <inheritdoc/>
        public TRequestModel Model { get; set; }
    }
}
