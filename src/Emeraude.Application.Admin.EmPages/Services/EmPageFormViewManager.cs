using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Models.FormView;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Schema.FormView;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Application.Exceptions;
using Emeraude.Essentials.Helpers;
using Microsoft.Extensions.Primitives;

namespace Emeraude.Application.Admin.EmPages.Services;

/// <summary>
/// <inheritdoc cref="IEmPageManager"/>
/// </summary>
public partial class EmPageManager
{
    /// <inheritdoc cref="RetrieveFormViewModelAsync"/>
    public async Task<EmPageFormViewModel> RetrieveFormViewModelAsync(EmPageFormType type, string route, string modelId, IDictionary<string, StringValues> query)
    {
        // Retrieve schema
        var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
        if (!schemaDescription.FormView.IsActive)
        {
            throw new EmPageNotFoundException($"There is no active 'Form View' for schema with route '{route}'");
        }

        EmPageOperation operationType = EmPageOperation.CreateModel;
        switch (type)
        {
            case EmPageFormType.CreateForm when !schemaDescription.FormView.IsCreateFormActive:
            case EmPageFormType.EditForm when !schemaDescription.FormView.IsEditFormActive:
                throw new EmPageNotFoundException($"There are no defined '{StringUtilities.SplitWordsByCapitalLetters(type.ToString())} View' items for schema with route '{route}'");
            case EmPageFormType.CreateForm:
                operationType = EmPageOperation.CreateModel;
                break;
            case EmPageFormType.EditForm:
                operationType = EmPageOperation.EditModel;
                break;
        }

        await this.EmPageOperationAuthorizationGuardAsync(operationType, schemaDescription);

        var model = new EmPageFormViewModel(new EmPageViewContext
        {
            Route = schemaDescription.Route,
            Title = schemaDescription.Title,
        });

        this.MapToViewModel(schemaDescription.FormView, model);
        await this.MapToFormViewModelAsync(schemaDescription.FormView, model);

        var breadcrumbsIndicesForHide = schemaDescription
            .FormView
            .Breadcrumbs
            .Select((x, i) => new { Index = i, Hide = x.HideContextually })
            .Where(x => x.Hide && type == EmPageFormType.CreateForm)
            .Select(x => x.Index);

        model.Context.Breadcrumbs = model.Context.Breadcrumbs
            .Where((_, i) => !breadcrumbsIndicesForHide.Contains(i)).ToList();

        // Set built-in placeholders
        foreach (var breadcrumb in model.Context.Breadcrumbs)
        {
            if (EmPagesPlaceholders.TryGetFormActionPlaceholder(
                    breadcrumb.Title,
                    type,
                    out var foundPlaceholderValue))
            {
                breadcrumb.Title = foundPlaceholderValue;
            }
        }

        // Retrieve data
        var dataManager = this.GetDataManagerInstance(schemaDescription);
        IEnumerable<FormViewItem> formViewItems;
        IEmPageModel rawModel = Activator.CreateInstance(schemaDescription.ModelType) as IEmPageModel;

        switch (type)
        {
            case EmPageFormType.CreateForm:
                formViewItems = schemaDescription.FormView.CreateFormViewItems;
                break;
            case EmPageFormType.EditForm:
                formViewItems = schemaDescription.FormView.EditFormViewItems;
                rawModel = await dataManager.GetRawModelAsync(modelId);
                if (rawModel == null)
                {
                    throw new EmPageNotFoundException($"The model for schema with route: '{route}' and Id: '{modelId}' cannot be found");
                }

                model.Identifier = rawModel?.Id;
                this.SetDataRelatedPlaceholders(model.Context.Breadcrumbs, rawModel, schemaDescription);
                this.SetDataRelatedPlaceholders(model.Context.NavbarActions, rawModel, schemaDescription);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }

        foreach (var formViewItem in formViewItems)
        {
            model.Inputs.Add(this.BuildFormInput(formViewItem, schemaDescription, rawModel, model));
        }

        return model;
    }

    /// <inheritdoc cref="SubmitFormViewModelAsync"/>
    public async Task<EmPageFormSubmissionResponse> SubmitFormViewModelAsync(string route, EmPageFormType type, JsonElement payload)
    {
        var response = new EmPageFormSubmissionResponse();
        try
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
            var dataManage = this.GetDataManagerInstance(schemaDescription);
            var model = this.GetModelFromPayload(payload, schemaDescription);

            switch (type)
            {
                case EmPageFormType.CreateForm:
                    response.MutatedModelId = await dataManage.CreateAsync(model);
                    break;
                case EmPageFormType.EditForm:
                    response.MutatedModelId = await dataManage.EditAsync(model.Id, model);
                    break;
                default:
                    throw new InvalidOperationException("Invalid behavior of EmPage form submission");
            }
        }
        catch (ValidationException ex)
        {
            foreach (var (property, errors) in ex.Failures)
            {
                response.ValidationErrors[property] = errors;
            }
        }
        catch (Exception ex)
        {
            response.OperationError = ex.Message;
        }

        return response;
    }

    private async Task MapToFormViewModelAsync(
        FormViewDescription sourceDescription,
        EmPageFormViewModel model)
    {
        foreach (var viewItem in sourceDescription.ViewItems)
        {
            if (viewItem.SelectableCustomDataSourceType != null)
            {
                var selectableCustomDataSourceInstance = this.serviceProvider.GetService(viewItem.SelectableCustomDataSourceType) as IFormViewSelectableCustomDataSource;
                if (selectableCustomDataSourceInstance != null)
                {
                    await selectableCustomDataSourceInstance.PrepareDataAsync();
                    model.ModelSelectableCustomDataMap[viewItem.SelectableCustomDataSourceType.FullName] =
                        await selectableCustomDataSourceInstance.GetItemsAsync(model);
                }
            }
        }
    }

    private EmPageFormInputModel BuildFormInput(
        FormViewItem formViewItem,
        EmPageSchemaDescription schemaDescription,
        IEmPageModel rawModel,
        EmPageFormViewModel viewModel) =>
        new ()
        {
            Label = formViewItem.Title ?? formViewItem.SourceName,
            Readonly = formViewItem.Readonly,
            Hidden = formViewItem.Hidden,
            AllowNullValue = formViewItem.IsNullable,
            Required = formViewItem.Required,
            Order = formViewItem.Order,
            Property = formViewItem?.SourceName,
            Value = schemaDescription.ModelType.GetProperty(formViewItem.SourceName)?.GetValue(rawModel),
            Component = viewModel.PropertyComponentMap.FirstOrDefault(x => x.Property == formViewItem.SourceName)?.Value,
            Parameters = viewModel.PropertyParametersMap.FirstOrDefault(x => x.Property == formViewItem.SourceName)?.Value,
        };

    private IEmPageModel GetModelFromPayload(JsonElement payload, EmPageSchemaDescription schemaDescription)
    {
        return payload.Deserialize(schemaDescription.ModelType, this.jsonOptions.JsonSerializerOptions) as IEmPageModel;
    }
}