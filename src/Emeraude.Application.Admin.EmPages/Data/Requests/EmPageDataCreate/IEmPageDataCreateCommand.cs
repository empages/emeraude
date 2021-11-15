using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataCreate
{
    /// <summary>
    /// Generic command that create an entity.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageDataCreateCommand<TEntity, TModel> : IRequest<Guid?>, IEmPageEntityMutationalRequest<TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
    }
}
