using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Models.DetailsView;
using Emeraude.Application.Admin.EmPages.Models.IndexView;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Application.Admin.Models;
using Emeraude.Essentials.Extensions;
using Microsoft.Extensions.Primitives;

namespace Emeraude.Application.Admin.EmPages.Services;

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
        var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
        if (schemaDescription.IndexView.CustomViewComponent == null)
        {
            return await this.RetrieveTableViewModelAsync(route, query, filter, featureMode);
        }

        return await this.RetrieveCustomViewModelAsync(route, query, filter, featureMode);
    }

    /// <inheritdoc/>
    public async Task<EmPageIndexViewModel> RetrieveFeatureIndexViewModelAsync(
        EmPageDetailsFeatureModel feature,
        EmPageDetailsViewModel parentDetailsViewModel,
        IDictionary<string, StringValues> query)
    {
        var viewModel = await this.RetrieveIndexViewModelAsync(feature.Context.Route, query, feature.Filter, true);
        if (viewModel == null)
        {
            throw new EmPageNotFoundException($"A feature model for schema with route '{feature.Context.Route}' cannot be found");
        }

        var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(parentDetailsViewModel.Context.Route);

        await this.EmPageOperationAuthorizationGuardAsync(EmPageOperation.GetModels, schemaDescription);

        var dataManager = this.GetDataManagerInstance(schemaDescription);
        var parentModel = await dataManager.GetRawModelAsync(parentDetailsViewModel.Identifier);

        this.SetDataRelatedPlaceholders(viewModel.Context.NavbarActions, parentModel, schemaDescription);

        return viewModel;
    }

    private async Task<EmPageIndexViewModel> RetrieveCustomViewModelAsync(
        string route,
        IDictionary<string, StringValues> query,
        EmPageDataFilter filter,
        bool featureMode)
    {
        var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
        await this.RetrieveIndexViewGuard(schemaDescription, featureMode);

        var modelContext = new EmPageViewContext
        {
            Route = schemaDescription.Route,
            Title = schemaDescription.Title,
        };

        var model = new EmPageIndexViewModel(modelContext)
        {
            CustomViewModel = new EmPageCustomViewModel
            {
                ComponentName = schemaDescription.IndexView.CustomViewComponent.Name,
                Parameters = schemaDescription.IndexView.CustomViewComponent.Parameters.Select(x => new PropertyMap<object>(x.Key, x.Value)).ToList(),
            },
        };

        this.MapToViewModel(schemaDescription.IndexView, model);

        return model;
    }

    private async Task<EmPageIndexViewModel> RetrieveTableViewModelAsync(
        string route,
        IDictionary<string, StringValues> query,
        EmPageDataFilter filter,
        bool featureMode)
    {
        var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
        await this.RetrieveIndexViewGuard(schemaDescription, featureMode);

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

        foreach (var orderProperty in schemaDescription.IndexView.OrderProperties)
        {
            model.TableViewModel.OrderProperties[orderProperty.Key] = orderProperty.Value;
        }

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
                IEmPageModel parentRawModel = null;
                var parentId = query.GetValueOrDefault(EmPagesConstants.ParentQueryParam).FirstOrDefault();
                if (schemaDescription.ParentSchema != null && !string.IsNullOrWhiteSpace(parentId))
                {
                    var parentDataManager = this.GetDataManagerInstance(schemaDescription.ParentSchema);
                    parentRawModel = await parentDataManager.GetRawModelAsync(parentId);
                }

                foreach (var item in requestResult.Items)
                {
                    var rowModel = await this.BuildTableRowAsync(item, model, schemaDescription, parentRawModel);
                    model.TableViewModel.Rows.Add(rowModel);
                }

                model.TableViewModel.PaginationModel = new PaginationModel(requestResult.CurrentPage, requestResult.PagesCount);
            }
        }

        return model;
    }

    private async Task RetrieveIndexViewGuard(EmPageSchemaDescription schemaDescription, bool featureMode)
    {
        if (!schemaDescription.IndexView.IsActive)
        {
            throw new EmPageNotFoundException($"There is no active 'Index View' for schema with route '{schemaDescription.Route}'");
        }

        if (!featureMode && schemaDescription.UseAsFeature)
        {
            throw new EmPageNotFoundException($"The schema with route '{schemaDescription.Route}' is defined to be used as a feature so it cannot be used for 'Index View'");
        }

        await this.EmPageOperationAuthorizationGuardAsync(EmPageOperation.GetModels, schemaDescription);
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

    private async Task<EmPageTableRowModel> BuildTableRowAsync(EmPageModelResponse item, EmPageIndexViewModel model, EmPageSchemaDescription schemaDescription, IEmPageModel parentModel)
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

        if (schemaDescription.ParentSchema != null && parentModel != null)
        {
            this.SetDataRelatedPlaceholders(rowModel.Actions, parentModel, schemaDescription.ParentSchema);
        }

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