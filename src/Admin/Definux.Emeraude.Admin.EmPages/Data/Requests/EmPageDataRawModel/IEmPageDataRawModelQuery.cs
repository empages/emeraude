﻿using System;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataRawModel
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
        public Guid EntityId { get; set; }
    }
}