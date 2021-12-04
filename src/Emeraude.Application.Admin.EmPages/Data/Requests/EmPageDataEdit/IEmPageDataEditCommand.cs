using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataEdit;

/// <summary>
/// Generic query that edit an entity.
/// </summary>
/// <typeparam name="TEntity">Target entity.</typeparam>
/// <typeparam name="TModel">EmPage model.</typeparam>
public interface IEmPageDataEditCommand<TEntity, TModel> : IRequest<Guid?>, IEmPageEntityMutationalRequest<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Id of the entity.
    /// </summary>
    Guid EntityId { get; set; }
}