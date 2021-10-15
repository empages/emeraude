using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.Services
{
    /// <summary>
    /// <inheritdoc cref="IEmPageManager"/>
    /// </summary>
    public partial class EmPageManager
    {
        /// <inheritdoc cref="RetrieveDetailsViewModelAsync"/>
        public async Task<EmPageDetailsViewModel> RetrieveDetailsViewModelAsync(string route, string modelId, IDictionary<string, StringValues> query)
        {
            // Retrieve schema
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
            if (!schemaDescription.DetailsView.IsActive)
            {
                return null;
            }

            var model = new EmPageDetailsViewModel(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            this.MapToViewModel(schemaDescription.DetailsView, model);

            foreach (var feature in schemaDescription.DetailsView.Features)
            {
                model.Features.Add(this.BuildFeature(feature));
            }

            // Retrieve data
            if (schemaDescription.DataManagerType != null)
            {
                var dataManager = this.GetDataManagerInstance(schemaDescription);
                var rawModel = await dataManager.GetRawModelAsync(modelId);
                this.SetDataRelatedPlaceholders(model.Context.Breadcrumbs, rawModel);
                this.SetDataRelatedPlaceholders(model.Context.NavbarActions, rawModel);
                if (model.Features.Any())
                {
                    foreach (var feature in model.Features)
                    {
                        this.SetDataRelatedPlaceholders(feature.Context.Breadcrumbs, rawModel);
                    }
                }

                var requestResult = await dataManager.DetailsAsync(modelId);
                if (requestResult != null)
                {
                    foreach (var field in requestResult.Fields)
                    {
                        if (model.PropertyComponentPair.ContainsKey(field.Property))
                        {
                            model.Fields.Add(this.BuildField(schemaDescription, field, model));
                        }
                    }
                }
            }

            return model;
        }

        private EmPageDetailsFieldModel BuildField(
            EmPageSchemaDescription schemaDescription,
            EmPageModelResponseField field,
            EmPageDetailsViewModel model)
        {
            var schemaViewItem = schemaDescription
                .DetailsView
                .ViewItems
                .FirstOrDefault(x => x.SourceName == field.Property);

            return new EmPageDetailsFieldModel
            {
                Title = schemaViewItem?.Title ?? field.Property,
                Order = schemaViewItem?.Order ?? 0,
                Value = field.Value,
                Property = field.Property,
                Type = model.PropertyTypePair[field.Property],
                Component = model.PropertyComponentPair[field.Property],
                Parameters = model.PropertyParametersPair[field.Property],
            };
        }

        private EmPageDetailsFeature BuildFeature(Schema.EmPageFeature feature)
        {
            var detailsFeature = new EmPageDetailsFeature
            {
                Context = new EmPageViewContext
                {
                    Route = feature.Route,
                    Title = feature.Title,
                },
            };

            foreach (var pageAction in feature.PageActions)
            {
                detailsFeature.Context.NavbarActions.Add(this.MapAction(pageAction, detailsFeature.Context.Route));
            }

            foreach (var breadcrumb in feature.Breadcrumbs)
            {
                detailsFeature.Context.Breadcrumbs.Add(this.MapBreadcrumb(breadcrumb));
            }

            return detailsFeature;
        }
    }
}