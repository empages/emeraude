using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data.Requests;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Essentials.Models;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data
{
    /// <summary>
    /// <inheritdoc cref="IEmPageDataManager"/>
    /// </summary>
    /// <typeparam name="TModel">EmPage model for the selected entity.</typeparam>
    public abstract class EmPageDataManager<TModel> : IEmPageDataManager
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataManager{TModel}"/> class.
        /// </summary>
        /// <param name="dataStrategy"></param>
        /// <param name="mediator"></param>
        /// <param name="emPageService"></param>
        protected EmPageDataManager(
            IEmPageDataStrategy<TModel> dataStrategy,
            IMediator mediator,
            IEmPageService emPageService)
        {
            this.DataStrategy = dataStrategy;
            this.Mediator = mediator;
            this.EmPageService = emPageService;
        }

        /// <summary>
        /// Data strategy that defines the data accessors and mutators of the manager.
        /// </summary>
        protected IEmPageDataStrategy<TModel> DataStrategy { get; set; }

        /// <summary>
        /// Disables <see cref="FetchAsync"/> operation.
        /// </summary>
        protected bool DisableFetchOperation { get; set; }

        /// <summary>
        /// Disables <see cref="DetailsAsync"/> operation.
        /// </summary>
        protected bool DisableDetailsOperation { get; set; }

        /// <summary>
        /// Disables <see cref="CreateAsync"/> operation.
        /// </summary>
        protected bool DisableCreateOperation { get; set; }

        /// <summary>
        /// Disables <see cref="EditAsync"/> operation.
        /// </summary>
        protected bool DisableEditOperation { get; set; }

        /// <summary>
        /// <inheritdoc cref="IEmPageService"/>
        /// </summary>
        protected IMediator Mediator { get; }

        /// <summary>
        /// <inheritdoc cref="IEmPageService"/>
        /// </summary>
        protected IEmPageService EmPageService { get; }

        /// <inheritdoc/>
        public virtual async Task<IEmPageModel> GetRawModelAsync(string modelId)
        {
            this.TriggerDataStrategyGuard();
            var rawModelQuery = this.DataStrategy.BuildRawModelQuery(modelId);
            return await this.ExecuteDataStrategyRequestAsync<TModel>(rawModelQuery);
        }

        /// <inheritdoc/>
        public async Task<IEmPageModel> GetRawModelAsync(EmPageDataFilter filter)
        {
            this.TriggerDataStrategyGuard();
            var rawModelQuery = this.DataStrategy.BuildRawModelQuery(filter);
            return await this.ExecuteDataStrategyRequestAsync<TModel>(rawModelQuery);
        }

        /// <inheritdoc />
        public virtual async Task<TableViewDataRequestResult> FetchAsync(EmPageDataFetchQueryBody request)
        {
            if (this.DisableFetchOperation)
            {
                throw new EmPageDisabledOperationException($"Fetch operation is disabled for {this.GetType().FullName}");
            }

            var schema = await this.GetSchemaAsync();

            request.OrderBy = this.InterceptOrderProperty(request.OrderBy);
            var entitiesResult = await this.FetchEntitiesAsync(request);
            var result = new TableViewDataRequestGenericResult<TModel>(entitiesResult);

            result.Items = this.ConsolidateModelResponsesFields(result.Items, schema.IndexView.ViewItems);
            return result;
        }

        /// <inheritdoc />
        public virtual async Task<EmPageModelResponse> DetailsAsync(string modelId)
        {
            if (this.DisableDetailsOperation)
            {
                throw new EmPageDisabledOperationException($"Details operation is disabled for {this.GetType().FullName}");
            }

            var schema = await this.GetSchemaAsync();
            var model = await this.GetEntityDetailsAsync(modelId);
            if (model == null)
            {
                throw new EmPageNotFoundException($"Details page for model with ID: {modelId} of {this.GetType().FullName} is not found");
            }

            var modelResponse = new EmPageModelResponse(model);
            modelResponse = this.ConsolidateModelResponseFields(modelResponse, schema.DetailsView.ViewItems);

            return modelResponse;
        }

        /// <inheritdoc />
        public virtual async Task<string> CreateAsync(IEmPageModel model)
        {
            if (this.DisableCreateOperation)
            {
                throw new EmPageDisabledOperationException($"Create is disabled for {this.GetType().FullName}");
            }

            var mutatedModelId = await this.CreateModelAsync(model as TModel);
            return mutatedModelId;
        }

        /// <inheritdoc/>
        public async Task<string> EditAsync(string modelId, IEmPageModel model)
        {
            if (this.DisableEditOperation)
            {
                throw new EmPageDisabledOperationException($"Edit is disabled for {this.GetType().FullName}");
            }

            var mutatedModelId = await this.EditModelAsync(modelId, model as TModel);
            return mutatedModelId;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteAsync(string modelId)
        {
            this.TriggerDataStrategyGuard();
            var deleteCommand = this.DataStrategy.BuildDeleteCommand(modelId);
            await this.BeforeDeleteAsync(modelId);
            var deleted = await this.ExecuteDataStrategyRequestAsync<bool>(deleteCommand);
            await this.AfterDeletedAsync(deleted, modelId);
            return deleted;
        }

        /// <summary>
        /// Executes an operation before the data strategy request.
        /// The purpose of that method is to intercept the delete operation.
        /// The default implementation is empty.
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        protected virtual async Task BeforeDeleteAsync(string modelId)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Executes an operation after the data strategy request.
        /// The purpose of that operation is to execute a custom code after delete operation.
        /// The default implementation is empty.
        /// </summary>
        /// <param name="succeeded"></param>
        /// <param name="modelId"></param>
        /// <returns></returns>
        protected virtual async Task AfterDeletedAsync(bool succeeded, string modelId)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Fetch operation executor.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected virtual async Task<PaginatedList<TModel>> FetchEntitiesAsync(EmPageDataFetchQueryBody request)
        {
            this.TriggerDataStrategyGuard();
            var fetchQuery = this.DataStrategy.BuildFetchQuery(request);
            return await this.ExecuteDataStrategyRequestAsync<PaginatedList<TModel>>(fetchQuery);
        }

        /// <summary>
        /// Details operation executor.
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        protected virtual async Task<TModel> GetEntityDetailsAsync(string modelId)
        {
            this.TriggerDataStrategyGuard();
            var detailsQuery = this.DataStrategy.BuildDetailsQuery(modelId);
            return await this.ExecuteDataStrategyRequestAsync<TModel>(detailsQuery);
        }

        /// <summary>
        /// Create operation executor.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task<string> CreateModelAsync(TModel model)
        {
            this.TriggerDataStrategyGuard();
            await this.BeforeCreateAsync(model);
            var createCommand = this.DataStrategy.BuildCreateCommand(model);
            var resultId = (await this.ExecuteDataStrategyRequestAsync<object>(createCommand))?.ToString();
            await this.AfterCreatedAsync(resultId, model);
            return resultId;
        }

        /// <summary>
        /// Executes an operation before the data strategy request.
        /// The purpose of that method is to intercept the create operation.
        /// The default implementation is empty.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task BeforeCreateAsync(TModel model)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Executes an operation after the data strategy request.
        /// The purpose of that operation is to execute a custom code after create operation.
        /// The default implementation is empty.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task AfterCreatedAsync(string modelId, TModel model)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Edit operation executor.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task<string> EditModelAsync(string modelId, TModel model)
        {
            this.TriggerDataStrategyGuard();
            await this.BeforeEditAsync(modelId, model);
            var editCommand = this.DataStrategy.BuildEditCommand(modelId, model);
            var resultId = (await this.ExecuteDataStrategyRequestAsync<object>(editCommand))?.ToString();
            await this.AfterEditedAsync(resultId, model);
            return resultId;
        }

        /// <summary>
        /// Executes an operation before the data strategy request.
        /// The purpose of that method is to intercept the edit operation.
        /// The default implementation is empty.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task BeforeEditAsync(string modelId, TModel model)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Executes an operation after the data strategy request.
        /// The purpose of that operation is to execute a custom code after edit operation.
        /// The default implementation is empty.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual async Task AfterEditedAsync(string modelId, TModel model)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Return list of all order properties for current entity.
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> GetOrderProperties()
        {
            return new List<string>
            {
                nameof(IEmPageModel.Id),
            };
        }

        /// <summary>
        /// Executes data strategy request and cast the response.
        /// </summary>
        /// <param name="request"></param>
        /// <typeparam name="TResponse">Response type of the request.</typeparam>
        /// <returns></returns>
        protected async Task<TResponse> ExecuteDataStrategyRequestAsync<TResponse>(IEmPageRequest<TModel> request)
        {
            var response = await this.Mediator.Send(request);
            return (TResponse)response;
        }

        /// <summary>
        /// Gets current EmPage schema.
        /// </summary>
        /// <returns></returns>
        protected async Task<EmPageSchemaDescription> GetSchemaAsync()
            => await this.EmPageService.FindSchemaDescriptionAsync(typeof(TModel));

        /// <summary>
        /// Guard that is checking whether the <see cref="DataStrategy"/> has implementation.
        /// </summary>
        /// <exception cref="EmPageUndefinedDataStrategyException"><inheritdoc cref="EmPageUndefinedDataStrategyException"/></exception>
        protected void TriggerDataStrategyGuard()
        {
            if (this.DataStrategy == null)
            {
                throw new EmPageUndefinedDataStrategyException($"{this.GetType().FullName} has no defined data strategy.");
            }
        }

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