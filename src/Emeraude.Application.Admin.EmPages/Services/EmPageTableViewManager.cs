using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Models.DetailsView;
using Emeraude.Application.Admin.EmPages.Models.TableView;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Application.Admin.Models;
using Microsoft.Extensions.Primitives;

namespace Emeraude.Application.Admin.EmPages.Services
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

            var headCells = new List<EmPageTableHeadCellModel>();
            foreach (var tableViewItem in schemaDescription.TableView.ViewItems)
            {
                headCells.Add(new EmPageTableHeadCellModel
                {
                    Name = tableViewItem.Title,
                    Order = tableViewItem.Order,
                    Identifier = tableViewItem.SourceName,
                });
            }

            model.HeadModel.Cells.AddRange(headCells.OrderBy(x => x.Order));

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
                        var rowModel = this.BuildTableRow(item, model, schemaDescription);
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

        private EmPageTableRowModel BuildTableRow(EmPageModelResponse item, EmPageTableViewModel model, EmPageSchemaDescription schemaDescription)
        {
            var rowModel = new EmPageTableRowModel
            {
                Identifier = item.Identifier,
            };

            var cells = new List<EmPageTableCellModel>();

            foreach (var field in item.Fields)
            {
                if (model.PropertyComponentMap.All(x => x.Property != field.Property))
                {
                    continue;
                }

                cells.Add(this.BuildTableRowCell(field, model));
            }

            rowModel.Cells.AddRange(cells.OrderBy(x => x.Order));

            rowModel.Actions.AddRange(model.RowActions.Select(this.BuildRowAction));
            this.SetDataRelatedPlaceholders(rowModel.Actions, item, schemaDescription);

            return rowModel;
        }

        private EmPageTableCellModel BuildTableRowCell(EmPageModelResponseField field, EmPageTableViewModel model) =>
            new ()
            {
                Order = model.PropertyOrderMap.FirstOrDefault(x => x.Property == field.Property)?.Value ?? 0,
                Value = field.Value,
                Property = field.Property,
                Component = model.PropertyComponentMap.FirstOrDefault(x => x.Property == field.Property)?.Value,
                Parameters = model.PropertyParametersMap.FirstOrDefault(x => x.Property == field.Property)?.Value,
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