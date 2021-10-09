using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Schema.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Models.FormView;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Essentials.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.Services
{
    /// <inheritdoc cref="IEmPageDataService" />
    public class EmPageDataService : IEmPageDataService
    {
        private readonly IEmPageService emPageService;
        private readonly IServiceProvider serviceProvider;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataService"/> class.
        /// </summary>
        /// <param name="emPageService"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="logger"></param>
        public EmPageDataService(
            IEmPageService emPageService,
            IServiceProvider serviceProvider,
            IEmLogger logger)
        {
            this.emPageService = emPageService;
            this.serviceProvider = serviceProvider;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<EmPageTableViewData> RetrieveTableViewDataAsync(string entityKey, IDictionary<string, StringValues> query, EmPageTableViewSchema schema)
        {
            var emptyResult = new EmPageTableViewData();
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);
            if (schemaDescription.DataManagerType != null)
            {
                var dataManager = this.GetDataManagerInstance(schemaDescription);
                var requestResult = await dataManager.FetchAsync(new EmPageDataFetchQueryRequest(query));
                if (requestResult != null)
                {
                    var result = new EmPageTableViewData();
                    foreach (var item in requestResult.Items)
                    {
                        var rowModel = new EmPageTableRowModel
                        {
                            Identifier = item.Identifier,
                        };

                        int fieldIndex = 0;
                        foreach (var field in item.Fields)
                        {
                            if (schema.PropertyComponentPair.ContainsKey(field.Property))
                            {
                                rowModel.Cells.Add(new EmPageTableCellModel
                                {
                                    Order = fieldIndex,
                                    Value = field.Value,
                                    Property = field.Property,
                                    Type = schema.PropertyTypePair[field.Property],
                                    Component = schema.PropertyComponentPair[field.Property],
                                    Parameters = schema.PropertyParametersPair[field.Property],
                                });

                                fieldIndex++;
                            }
                        }

                        foreach (var action in schema.RowActions)
                        {
                            rowModel.Actions.Add(new ActionModel
                            {
                                Title = action.Title,
                                Order = action.Order,
                                ActionUrl = string.Format(action.ActionUrl, rowModel.Identifier),
                                ActionHttpMethod = action.ActionHttpMethod,
                                OpenOnSeparatePage = action.OpenOnSeparatePage,
                                ConfirmationMessage = action.ConfirmationMessage,
                            });
                        }

                        result.Rows.Add(rowModel);
                    }

                    result.PaginationModel = new PaginationModel(requestResult.CurrentPage, requestResult.PagesCount);

                    return result;
                }
            }

            return emptyResult;
        }

        /// <inheritdoc/>
        public async Task<EmPageDetailsViewData> RetrieveDetailsViewDataAsync(string entityKey, string entityId, IDictionary<string, StringValues> query, EmPageDetailsViewSchema schema)
        {
            var emptyResult = new EmPageDetailsViewData();
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);
            if (schemaDescription.DataManagerType != null)
            {
                var dataManager = this.GetDataManagerInstance(schemaDescription);
                Guid.TryParse(entityId, out var parsedEntityId);
                var requestResult = await dataManager.DetailsAsync(parsedEntityId);
                if (requestResult != null)
                {
                    var result = new EmPageDetailsViewData();
                    foreach (var field in requestResult.Fields)
                    {
                        if (schema.PropertyComponentPair.ContainsKey(field.Property))
                        {
                            var schemaViewItem = schemaDescription
                                .DetailsView
                                .ViewItems
                                .FirstOrDefault(x => x.SourceName == field.Property);
                            result.Fields.Add(new EmPageDetailsFieldModel
                            {
                                Title = schemaViewItem?.Title ?? field.Property,
                                Order = schemaViewItem?.Order ?? 0,
                                Value = field.Value,
                                Property = field.Property,
                                Type = schema.PropertyTypePair[field.Property],
                                Component = schema.PropertyComponentPair[field.Property],
                                Parameters = schema.PropertyParametersPair[field.Property],
                            });
                        }
                    }

                    return result;
                }
            }

            return emptyResult;
        }

        /// <inheritdoc/>
        public async Task<EmPageFormViewData> RetrieveFormViewDataAsync(
            EmPageFormType type,
            string entityKey,
            string entityId,
            IDictionary<string, StringValues> query,
            EmPageFormViewSchema schema)
        {
            var emptyResult = new EmPageFormViewData();
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);
            if (schemaDescription.DataManagerType != null)
            {
                var dataManager = this.GetDataManagerInstance(schemaDescription);
                var result = new EmPageFormViewData();
                IEnumerable<FormViewItem> formViewItems = new List<FormViewItem>();

                IEmPageModel model = Activator.CreateInstance(schemaDescription.ModelType) as IEmPageModel;
                switch (type)
                {
                    case EmPageFormType.CreateForm:
                        formViewItems = schemaDescription.FormView.CreateFormViewItems;
                        break;
                    case EmPageFormType.EditForm:
                        formViewItems = schemaDescription.FormView.EditFormViewItems;
                        Guid.TryParse(entityId, out var parsedEntityId);
                        model = await dataManager.GetRawModelAsync(parsedEntityId);
                        break;
                }

                foreach (var formViewItem in formViewItems)
                {
                    result.Inputs.Add(new EmPageFormInputModel
                    {
                        Label = formViewItem.Title ?? formViewItem.SourceName,
                        Order = formViewItem.Order,
                        Property = formViewItem?.SourceName,
                        Value = schemaDescription.ModelType.GetProperty(formViewItem.SourceName).GetValue(model),
                        Type = schema.PropertyTypePair[formViewItem.SourceName],
                        Component = schema.PropertyComponentPair[formViewItem.SourceName],
                        Parameters = schema.PropertyParametersPair[formViewItem.SourceName],
                    });
                }

                return result;
            }

            return emptyResult;
        }

        /// <inheritdoc/>
        public async Task<EmPageFormSubmissionResponse> SubmitFormViewDataAsync(
            EmPageFormType formType,
            EmPageFormViewSchema schema,
            EmPageFormViewData formViewData)
        {
            var response = new EmPageFormSubmissionResponse();
            try
            {
                var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(schema.Context.Key);
                var model = this.BuildModel(formViewData.Inputs, schemaDescription.ModelType);
                var dataManage = this.GetDataManagerInstance(schemaDescription);
                response.MutatedModelId = (await dataManage.CreateAsync(model))?.ToString();
            }
            catch (ValidationException e)
            {
                foreach (var (property, errors) in e.Failures)
                {
                    response.ValidationErrors[property] = errors;
                }
            }
            catch (Exception e)
            {
                response.OperationError = e.Message;
            }

            formViewData.ClearErrors();

            this.MapValidationErrorsToModelInputs(
                formViewData.Inputs,
                response.ValidationErrors,
                out var nonMappedErrors);

            if (nonMappedErrors != null && nonMappedErrors.Any())
            {
                formViewData.NonMappedFormErrors.AddRange(nonMappedErrors);
            }

            return response;
        }

        private IEmPageModel BuildModel(IEnumerable<EmPageFormInputModel> inputs, Type modelType) =>
            DictionaryUtilities.NewClassInstanceFromDictionary(
                modelType,
                inputs.ToDictionary(k => k.Property, v => v.Value)) as IEmPageModel;

        private IEmPageDataManager GetDataManagerInstance(EmPageSchemaDescription schemaDescription) =>
            this.serviceProvider.GetService(schemaDescription.DataManagerType) as IEmPageDataManager;

        private void MapValidationErrorsToModelInputs(
            IEnumerable<EmPageFormInputModel> inputModels,
            IDictionary<string, string[]> errors,
            out IEnumerable<string> unmappedErrors)
        {
            var mappedKeys = new List<string>();
            foreach (var inputModel in inputModels)
            {
                var errorKey = $"Model.{inputModel.Property}";
                if (!errors.ContainsKey(errorKey))
                {
                    continue;
                }

                inputModel.ValidationErrors.AddRange(errors[errorKey]);
                mappedKeys.Add(errorKey);
            }

            if (mappedKeys.Count != errors.Count)
            {
                unmappedErrors = errors
                    .Where(x => !mappedKeys.Contains(x.Key))
                    .SelectMany(x => x.Value);
            }
            else
            {
                unmappedErrors = new List<string>();
            }
        }
    }
}