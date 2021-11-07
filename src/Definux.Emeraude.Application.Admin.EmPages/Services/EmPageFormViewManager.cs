using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Admin.EmPages.Models;
using Definux.Emeraude.Application.Admin.EmPages.Models.FormView;
using Definux.Emeraude.Application.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Admin.EmPages.Schema.FormView;
using Definux.Emeraude.Application.Admin.EmPages.Shared;
using Definux.Emeraude.Application.Admin.EmPages.Utilities;
using Definux.Emeraude.Application.Exceptions;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Application.Admin.EmPages.Services
{
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
            if (!schemaDescription.FormView.IsActive || schemaDescription.UseAsFeature)
            {
                return null;
            }

            switch (type)
            {
                case EmPageFormType.CreateForm when !schemaDescription.FormView.IsCreateFormActive:
                case EmPageFormType.EditForm when !schemaDescription.FormView.IsEditFormActive:
                    return null;
            }

            var model = new EmPageFormViewModel(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            this.MapToViewModel(schemaDescription.FormView, model);
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
            if (schemaDescription.DataManagerType != null)
            {
                var dataManager = this.GetDataManagerInstance(schemaDescription);
                IEnumerable<FormViewItem> formViewItems = new List<FormViewItem>();
                IEmPageModel rawModel = Activator.CreateInstance(schemaDescription.ModelType) as IEmPageModel;

                switch (type)
                {
                    case EmPageFormType.CreateForm:
                        formViewItems = schemaDescription.FormView.CreateFormViewItems;
                        break;
                    case EmPageFormType.EditForm:
                        formViewItems = schemaDescription.FormView.EditFormViewItems;
                        rawModel = await dataManager.GetRawModelAsync(modelId);
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
            }

            return model;
        }

        /// <inheritdoc cref="SubmitFormViewModelAsync"/>
        public async Task<EmPageFormSubmissionResponse> SubmitFormViewModelAsync(EmPageFormType formType, EmPageFormViewModel viewModel)
        {
            var response = new EmPageFormSubmissionResponse();
            try
            {
                var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(viewModel.Context.Route);
                var model = this.BuildModel(viewModel.Inputs, schemaDescription.ModelType);
                var dataManage = this.GetDataManagerInstance(schemaDescription);
                response.MutatedModelId = (await dataManage.CreateAsync(model))?.ToString();
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

            viewModel.ClearErrors();

            this.MapValidationErrorsToModelInputs(
                viewModel.Inputs,
                response.ValidationErrors,
                out var nonMappedErrors);

            if (nonMappedErrors != null && nonMappedErrors.Any())
            {
                viewModel.NonMappedFormErrors.AddRange(nonMappedErrors);
            }

            return response;
        }

        private EmPageFormInputModel BuildFormInput(
            FormViewItem formViewItem,
            EmPageSchemaDescription schemaDescription,
            IEmPageModel rawModel,
            EmPageFormViewModel viewModel) =>
            new ()
            {
                Label = formViewItem.Title ?? formViewItem.SourceName,
                Order = formViewItem.Order,
                Property = formViewItem?.SourceName,
                Value = schemaDescription.ModelType.GetProperty(formViewItem.SourceName)?.GetValue(rawModel),
                Component = viewModel.PropertyComponentMap.FirstOrDefault(x => x.Property == formViewItem.SourceName)?.Value,
                Parameters = viewModel.PropertyParametersMap.FirstOrDefault(x => x.Property == formViewItem.SourceName)?.Value,
            };

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