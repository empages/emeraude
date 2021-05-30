using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Edit
{
    /// <inheritdoc cref="IEditCommand{TEntity, TRequestModel}"/>
    public class EditCommand<TEntity, TRequestModel> : GenericEntityRequst<TEntity>, IEditCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditCommand{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        public EditCommand(Guid entityId, TRequestModel model)
        {
            this.EntityId = entityId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCommand{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="model"></param>
        /// <param name="parentExpression"></param>
        public EditCommand(Guid entityId, TRequestModel model, Expression<Func<TEntity, bool>> parentExpression)
        {
            this.EntityId = entityId;
            this.Model = model;
            this.ParentExpression = parentExpression;
        }

        /// <inheritdoc/>
        public Guid EntityId { get; set; }

        /// <inheritdoc/>
        public TRequestModel Model { get; set; }
    }
}
