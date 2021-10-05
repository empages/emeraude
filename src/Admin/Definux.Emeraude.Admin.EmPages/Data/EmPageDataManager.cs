using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Exceptions;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Services;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Models;
using Definux.Emeraude.Resources;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data
{
    /// <summary>
    /// <inheritdoc cref="IEmPageDataManager"/>
    /// </summary>
    /// <typeparam name="TEntity">Entity from the domain model.</typeparam>
    /// <typeparam name="TModel">EmPage model for the selected entity.</typeparam>
    public abstract class EmPageDataManager<TEntity, TModel> : IEmPageDataManager
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataManager{TEntity, TModel}"/> class.
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="emPageService"></param>
        protected EmPageDataManager(IMediator mediator, IEmPageService emPageService)
        {
            this.Mediator = mediator;
            this.EmPageService = emPageService;
        }

        /// <summary>
        /// Disables <see cref="Fetch"/> action.
        /// </summary>
        protected bool DisableFetchAction { get; set; }

        /// <summary>
        /// Disables <see cref="Details"/> action.
        /// </summary>
        protected bool DisableDetailsAction { get; set; }

        /// <summary>
        /// <inheritdoc cref="IEmPageService"/>
        /// </summary>
        protected IMediator Mediator { get; }

        /// <summary>
        /// <inheritdoc cref="IEmPageService"/>
        /// </summary>
        protected IEmPageService EmPageService { get; }

        /// <inheritdoc />
        public virtual async Task<TableViewDataRequestResult> FetchAsync(EmPageDataFetchQueryRequest request)
        {
            if (this.DisableFetchAction)
            {
                throw new EmPageDisabledOperationException($"Fetch is disabled for {this.GetType().FullName}");
            }

            var schema = await this.GetSchemaAsync();

            request.OrderBy = this.InterceptOrderProperty(request.OrderBy);
            var entitiesResult = await this.FetchEntitiesAsync(request);
            var result = new TableViewDataRequestGenericResult<TModel>(entitiesResult);

            result.Items = this.ConsolidateModelResponsesFields(result.Items, schema.TableView.ViewItems);
            return result;
        }

        /// <inheritdoc />
        public virtual async Task<EmPageModelResponse> DetailsAsync(Guid id)
        {
            if (this.DisableDetailsAction)
            {
                throw new EmPageDisabledOperationException($"Details is disabled for {this.GetType().FullName}");
            }

            var schema = await this.GetSchemaAsync();
            var model = await this.GetEntityDetailsAsync(id);
            if (model == null)
            {
                throw new EmPageNotFoundException($"Details for entity with ID: {id} of {this.GetType().FullName} are not found.");
            }

            var modelResponse = new EmPageModelResponse(model);
            modelResponse = this.ConsolidateModelResponseFields(modelResponse, schema.DetailsView.ViewItems);

            return modelResponse;
        }

        /// <summary>
        /// Method that return the instance of <see cref="IEmPageDataFetchQuery{TEntity,TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="fetchQuery"></param>
        /// <returns></returns>
        protected virtual IEmPageDataFetchQuery<TEntity, TModel> GetFetchQuery(EmPageDataFetchQueryRequest fetchQuery)
        {
            return new EmPageDataFetchQuery<TEntity, TModel>
            {
                SearchQuery = fetchQuery.SearchQuery,
                Page = fetchQuery.Page,
                OrderBy = fetchQuery.OrderBy,
                OrderType = fetchQuery.OrderType,
            };
        }

        /// <summary>
        /// Fetch action executor.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected virtual async Task<PaginatedList<TModel>> FetchEntitiesAsync(EmPageDataFetchQueryRequest request)
        {
            return await this.Mediator.Send(this.GetFetchQuery(request));
        }

        /// <summary>
        /// Method that return the instance of <see cref="IEmPageDataDetailsQuery{TEntity,TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual IEmPageDataDetailsQuery<TEntity, TModel> GetDetailsQuery(Guid entityId)
        {
            return new EmPageDataDetailsQuery<TEntity, TModel>(entityId);
        }

        /// <summary>
        /// Details action executor.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        protected virtual async Task<TModel> GetEntityDetailsAsync(Guid entityId)
        {
            return await this.Mediator.Send(this.GetDetailsQuery(entityId));
        }

        /// <summary>
        /// Return list of all order properties for current entity.
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> GetOrderProperties()
        {
            return typeof(TEntity)
                .GetProperties()
                .Where(x => (DefaultValues.OrderTypes.Contains(x.PropertyType) || x.PropertyType.IsEnum) && x.GetSetMethod() != null)
                .Select(x => x.Name)
                .Where(x => x != nameof(IEntity.Id))
                .ToList();
        }

        /// <summary>
        /// Gets current EmPage schema.
        /// </summary>
        /// <returns></returns>
        protected async Task<EmPageSchemaDescription> GetSchemaAsync()
            => await this.EmPageService.FindSchemaDescriptionAsync(typeof(TEntity), typeof(TModel));

        private string InterceptOrderProperty(string property)
        {
            var allowedProperties = this.GetOrderProperties();
            return allowedProperties.Contains(property) ? property : null;
        }

        private EmPageModelResponse ConsolidateModelResponseFields(EmPageModelResponse modelResponse, IEnumerable<IViewItem> modelViewItems)
        {
            var fieldsForViewItems =
                modelResponse
                    .Fields
                    .Where(x => modelViewItems.Select(y => y.SourceName).Contains(x.Property));

            modelResponse.Fields = fieldsForViewItems;

            return modelResponse;
        }

        private IEnumerable<EmPageModelResponse> ConsolidateModelResponsesFields(
            IEnumerable<EmPageModelResponse> modelResponses,
            IEnumerable<IViewItem> modelViewItems)
        {
            List<EmPageModelResponse> resultModelResponses = new List<EmPageModelResponse>();
            foreach (var modelResponse in modelResponses)
            {
                this.ConsolidateModelResponseFields(modelResponse, modelViewItems);
                resultModelResponses.Add(modelResponse);
            }

            return resultModelResponses;
        }
    }
}