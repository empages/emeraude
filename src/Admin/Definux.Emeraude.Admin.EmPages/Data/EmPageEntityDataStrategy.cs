using System;
using Definux.Emeraude.Admin.EmPages.Data.Requests;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataRawModel;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data
{
    /// <summary>
    /// EmPage data strategy implementation for using domain entities.
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public abstract class EmPageEntityDataStrategy<TEntity, TModel> : IEmPageDataStrategy<TModel>, IEmPageEntityDataStrategy
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildRawModelQuery(string modelId)
        {
            Guid.TryParse(modelId, out var entityId);
            return new EmPageDataRawModelQuery<TEntity, TModel>(entityId);
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildFetchQuery(EmPageDataFetchQueryRequest request)
        {
            return new EmPageDataFetchQuery<TEntity, TModel>
            {
                SearchQuery = request.SearchQuery,
                Page = request.Page,
                OrderBy = request.OrderBy,
                OrderType = request.OrderType,
            };
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildDetailsQuery(string modelId)
        {
            Guid.TryParse(modelId, out var entityId);
            return new EmPageDataDetailsQuery<TEntity, TModel>(entityId);
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildCreateCommand(TModel model)
        {
            return new EmPageDataCreateCommand<TEntity, TModel>(model);
        }
    }
}