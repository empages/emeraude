﻿using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDelete;

/// <summary>
/// Generic command that delete an entity.
/// </summary>
/// <typeparam name="TEntity">Target entity.</typeparam>
/// <typeparam name="TModel">EmPage model.</typeparam>
public interface IEmPageDataDeleteCommand<TEntity, TModel> : IRequest<bool>, IEmPageEntityRequest<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Id of the entity.
    /// </summary>
    Guid EntityId { get; set; }
}