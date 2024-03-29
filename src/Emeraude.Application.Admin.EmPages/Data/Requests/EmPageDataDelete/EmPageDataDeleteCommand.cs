﻿using System;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDelete;

/// <inheritdoc cref="IEmPageDataDeleteCommand{TEntity, TModel}"/>
public class EmPageDataDeleteCommand<TEntity, TModel> : IEmPageDataDeleteCommand<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataDeleteCommand{TEntity, TModel}"/> class.
    /// </summary>
    /// <param name="entityId"></param>
    public EmPageDataDeleteCommand(Guid entityId)
    {
        this.EntityId = entityId;
    }

    /// <inheritdoc/>
    public Guid EntityId { get; set; }
}