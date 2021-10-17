using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;
using Definux.Emeraude.Admin.EmPages.UI.Utilities;
using Definux.Emeraude.Admin.UI.Models;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.Services
{
    /// <summary>
    /// <inheritdoc cref="IEmPageManager"/>
    /// </summary>
    public partial class EmPageManager
    {
        /// <inheritdoc cref="RetrieveTableViewModelAsync"/>
        public async Task<EmPageTableViewModel> RetrieveTableViewModelAsync(
            string route,
            IDictionary<string, StringValues> query,
            EmPageDataFilter filter = null,
            bool featureMode = false)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
            if (!schemaDescription.TableView.IsActive || (!featureMode && schemaDescription.UseAsFeature))
            {
                return null;
            }

            var model = new EmPageTableViewModel(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            foreach (var tableViewItem in schemaDescription.TableView.ViewItems)
            {
                model.HeadModel.Cells.Add(new EmPageTableHeadCellModel
                {
                    Name = tableViewItem.Title,
                    Order = tableViewItem.Order,
                });
            }

            var actions = schemaDescription.ModelActions ?? new List<EmPageAction>();
            model.HasActions = actions.Any();
            if (model.HasActions)
            {
                foreach (var action in actions)
                {
                    model.RowActions.Add(this.BuildRowAction(action, route));
                }
            }

            this.MapToViewModel(schemaDescription.TableView, model);

            if (schemaDescription.DataManagerType != null)
            {
                var dataManager = this.GetDataManagerInstance(schemaDescription);
                var fetchQuery = new EmPageDataFetchQueryBody(query)
                {
                    Filter = filter,
                };

                var requestResult = await dataManager.FetchAsync(fetchQuery);
                if (requestResult != null)
                {
                    foreach (var item in requestResult.Items)
                    {
                        var rowModel = this.BuildTableRow(item, model);
                        model.Rows.Add(rowModel);
                    }

                    model.PaginationModel = new PaginationModel(requestResult.CurrentPage, requestResult.PagesCount);
                }
            }

            return model;
        }

        /// <inheritdoc cref="RetrieveFeatureTableViewModelAsync"/>
        public async Task<EmPageTableViewModel> RetrieveFeatureTableViewModelAsync(EmPageDetailsFeatureModel feature, IDictionary<string, StringValues> query)
        {
            return await this.RetrieveTableViewModelAsync(feature.Context.Route, query, feature.Filter, true);
        }

        private ActionModel BuildRowAction(EmPageAction action, string route)
        {
            return new ()
            {
                Title = action.Name,
                ActionUrl = action.BuildActionUrlFormat(route),
                Order = action.Order,
                ActionHttpMethod = action.Method,
                OpenOnSeparatePage = action.SingleContext,
                ConfirmationMessage = action.ConfirmationMessage,
            };
        }

        private EmPageTableRowModel BuildTableRow(EmPageModelResponse item, EmPageTableViewModel model)
        {
            var rowModel = new EmPageTableRowModel
            {
                Identifier = item.Identifier,
            };

            var fieldIndex = 0;
            foreach (var field in item.Fields)
            {
                if (!model.PropertyComponentPair.ContainsKey(field.Property))
                {
                    continue;
                }

                rowModel.Cells.Add(this.BuildTableRowCell(field, fieldIndex, model));
                fieldIndex++;
            }

            rowModel.Actions.AddRange(model.RowActions.Select(this.BuildRowAction));
            this.SetDataRelatedPlaceholders(rowModel.Actions, item);

            return rowModel;
        }

        private EmPageTableCellModel BuildTableRowCell(EmPageModelResponseField field, int fieldIndex, EmPageTableViewModel model) =>
            new ()
            {
                Order = fieldIndex,
                Value = field.Value,
                Property = field.Property,
                Type = model.PropertyTypePair[field.Property],
                Component = model.PropertyComponentPair[field.Property],
                Parameters = model.PropertyParametersPair[field.Property],
            };

        private ActionModel BuildRowAction(ActionModel action) =>
            new ()
            {
                Title = action.Title,
                ActionUrl = action.ActionUrl,
                Order = action.Order,
                OpenOnSeparatePage = action.OpenOnSeparatePage,
                ActionHttpMethod = action.ActionHttpMethod,
                ConfirmationMessage = action.ConfirmationMessage,
            };
    }
}