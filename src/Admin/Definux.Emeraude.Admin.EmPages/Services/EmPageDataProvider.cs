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
using Definux.Emeraude.Application.Logger;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.Services
{
    /// <inheritdoc cref="IEmPageDataProvider" />
    public class EmPageDataProvider : IEmPageDataProvider
    {
        private readonly IEmPageService emPageService;
        private readonly IServiceProvider serviceProvider;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataProvider"/> class.
        /// </summary>
        /// <param name="emPageService"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="logger"></param>
        public EmPageDataProvider(
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
                    int fieldIndex = 0;
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
                var result = new EmPageFormViewData();
                var formViewItems = type switch
                {
                    EmPageFormType.CreateForm => schemaDescription.FormView.CreateFormViewItems,
                    EmPageFormType.EditForm => schemaDescription.FormView.EditFormViewItems,
                    _ => new List<FormViewItem>()
                };

                foreach (var formViewItem in formViewItems)
                {
                    result.Inputs.Add(new EmPageFormInputModel
                    {
                        Label = formViewItem.Title,
                        Component = formViewItem.Component,
                    });
                }

                return result;
            }

            return emptyResult;
        }

        private IEmPageDataManager GetDataManagerInstance(EmPageSchemaDescription schemaDescription)
            => this.serviceProvider.GetService(schemaDescription.DataManagerType) as IEmPageDataManager;
    }
}