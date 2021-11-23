using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Models.DetailsView;
using Emeraude.Application.Admin.EmPages.Models.IndexView;
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
        /// <inheritdoc/>
        public async Task<EmPageIndexViewModel> RetrieveIndexViewModelAsync(
            string route,
            IDictionary<string, StringValues> query,
            EmPageDataFilter filter = null,
            bool featureMode = false)
        {
            return await this.RetrieveTableViewModelAsync(route, query, filter, featureMode);
        }

        /// <inheritdoc/>
        public async Task<EmPageIndexViewModel> RetrieveFeatureIndexViewModelAsync(
            EmPageDetailsFeatureModel feature,
            EmPageDetailsViewModel parentDetailsViewModel,
            IDictionary<string, StringValues> query)
        {
            return await this.RetrieveFeatureTableViewModelAsync(feature, parentDetailsViewModel, query);
        }

        private async Task<EmPageIndexViewModel> RetrieveTableViewModelAsync(
            string route,
            IDictionary<string, StringValues> query,
            EmPageDataFilter filter,
            bool featureMode)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
            if (!schemaDescription.IndexView.IsActive || (!featureMode && schemaDescription.UseAsFeature))
            {
                return null;
            }

            var modelContext = new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            };

            var model = new EmPageIndexViewModel(modelContext)
            {
                TableViewModel = new EmPageTableViewModel(),
            };

            var headCells = new List<EmPageTableHeadCellModel>();
            foreach (var tableViewItem in schemaDescription.IndexView.ViewItems)
            {
                headCells.Add(new EmPageTableHeadCellModel
                {
                    Name = tableViewItem.Title,
                    Order = tableViewItem.Order,
                    Identifier = tableViewItem.SourceName,
                });
            }

            model.TableViewModel.HeadModel.Cells.AddRange(headCells.OrderBy(x => x.Order));

            var actions = schemaDescription.ModelActions ?? new List<EmPageAction>();
            model.TableViewModel.HasActions = actions.Any();
            if (model.TableViewModel.HasActions)
            {
                foreach (var action in actions)
                {
                    model.TableViewModel.RowActions.Add(this.BuildRowAction(action, route));
                }
            }

            this.MapToViewModel(schemaDescription.IndexView, model);

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
                        model.TableViewModel.Rows.Add(rowModel);
                    }

                    model.TableViewModel.PaginationModel = new PaginationModel(requestResult.CurrentPage, requestResult.PagesCount);
                }
            }

            return model;
        }

        private async Task<EmPageIndexViewModel> RetrieveFeatureTableViewModelAsync(
            EmPageDetailsFeatureModel feature,
            EmPageDetailsViewModel parentDetailsViewModel,
            IDictionary<string, StringValues> query)
        {
            var viewModel = await this.RetrieveTableViewModelAsync(feature.Context.Route, query, feature.Filter, true);
            if (viewModel == null)
            {
                return null;
            }

            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(parentDetailsViewModel.Context.Route);
            var dataManager = this.GetDataManagerInstance(schemaDescription);
            var parentModel = await dataManager.GetRawModelAsync(parentDetailsViewModel.Identifier);
            this.SetDataRelatedPlaceholders(viewModel.Context.Breadcrumbs, parentModel, schemaDescription);

            return viewModel;
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

        private EmPageTableRowModel BuildTableRow(EmPageModelResponse item, EmPageIndexViewModel model, EmPageSchemaDescription schemaDescription)
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

            rowModel.Actions.AddRange(model.TableViewModel.RowActions.Select(this.BuildRowAction));
            this.SetDataRelatedPlaceholders(rowModel.Actions, item, schemaDescription);

            return rowModel;
        }

        private EmPageTableCellModel BuildTableRowCell(EmPageModelResponseField field, EmPageIndexViewModel model) =>
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