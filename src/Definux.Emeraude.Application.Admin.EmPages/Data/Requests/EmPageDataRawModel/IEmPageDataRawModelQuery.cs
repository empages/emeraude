using System;
using System.Linq.Expressions;
using Definux.Emeraude.Application.Admin.EmPages.Schema;
using Definux.Emeraude.Contracts;
using MediatR;

namespace Definux.Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataRawModel
{
    /// <summary>
    /// Query that gets the raw EmPage model.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageDataRawModelQuery<TEntity, TModel> : IRequest<TModel>, IEmPageEntityRequest<TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        Guid EntityId { get; set; }

        /// <summary>
        /// Expression for finding an entity.
        /// </summary>
        Expression<Func<TEntity, bool>> FilterExpression { get; set; }
    }
}