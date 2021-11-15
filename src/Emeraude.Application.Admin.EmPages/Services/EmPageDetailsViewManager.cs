using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Models.DetailsView;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Schema.DetailsView;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Microsoft.Extensions.Primitives;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <summary>
    /// <inheritdoc cref="IEmPageManager"/>
    /// </summary>
    public partial class EmPageManager
    {
        /// <inheritdoc cref="RetrieveDetailsViewModelAsync"/>
        public async Task<EmPageDetailsViewModel> RetrieveDetailsViewModelAsync(
            string route,
            string modelId,
            IDictionary<string, StringValues> query,
            EmPageDataFilter filter = null,
            bool featureMode = false)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(route);
            if (!schemaDescription.DetailsView.IsActive)
            {
                return null;
            }

            if (schemaDescription.DataManagerType == null)
            {
                return null;
            }

            var model = new EmPageDetailsViewModel(new EmPageViewContext
            {
                Route = schemaDescription.Route,
                Title = schemaDescription.Title,
            });

            var dataManager = this.GetDataManagerInstance(schemaDescription);
            var rawModel = await dataManager.GetRawModelAsync(modelId);

            if (rawModel == null)
            {
                return null;
            }

            this.MapToViewModel(schemaDescription.DetailsView, model);

            foreach (var feature in schemaDescription.DetailsView.Features)
            {
                var detailsFeature = this.BuildFeature(feature);
                detailsFeature.Filter = this.BuildFeatureFilter(feature, rawModel);
                model.Features.Add(detailsFeature);
            }

            this.SetDataRelatedPlaceholders(model.Context.Breadcrumbs, rawModel, schemaDescription);
            this.SetDataRelatedPlaceholders(model.Context.NavbarActions, rawModel, schemaDescription);
            if (model.Features.Any())
            {
                foreach (var feature in model.Features)
                {
                    this.SetDataRelatedPlaceholders(feature.Context.Breadcrumbs, rawModel, schemaDescription);
                }
            }

            var detailsResult = await dataManager.DetailsAsync(modelId);
            if (detailsResult != null)
            {
                foreach (var field in detailsResult.Fields)
                {
                    if (model.PropertyComponentMap.Any(x => x.Property == field.Property))
                    {
                        model.Fields.Add(this.BuildField(schemaDescription, field, model));
                    }
                }
            }

            if (schemaDescription.UseAsFeature)
            {
                var parentSchemaDescription = schemaDescription.ParentSchema;
                var parentDataManager = this.GetDataManagerInstance(parentSchemaDescription);
                IEmPageModel parentRawModel = null;
                if (schemaDescription.ParentRelation.ReferenceDirection == EmPageFeatureReferenceDirection.FromSourceToParent)
                {
                    parentRawModel = await parentDataManager.GetRawModelAsync(schemaDescription.ParentRelation.SourceProperty.GetValue(rawModel)?.ToString());
                }
                else if (schemaDescription.ParentRelation.ReferenceDirection == EmPageFeatureReferenceDirection.FromParentToSource)
                {
                    parentRawModel = await parentDataManager.GetRawModelAsync(new EmPageDataFilter
                    {
                        [schemaDescription.ParentRelation.ParentProperty] = schemaDescription.ParentRelation.SourceProperty.GetValue(rawModel)?.ToString(),
                    });
                }

                this.SetDataRelatedPlaceholders(model.Context.Breadcrumbs, parentRawModel, parentSchemaDescription);
                this.SetDataRelatedPlaceholders(model.Context.NavbarActions, parentRawModel, parentSchemaDescription);
                if (model.Features.Any())
                {
                    foreach (var feature in model.Features)
                    {
                        this.SetDataRelatedPlaceholders(feature.Context.Breadcrumbs, parentRawModel, parentSchemaDescription);
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
                Component = model.PropertyComponentMap.FirstOrDefault(x => x.Property == field.Property)?.Value,
                Parameters = model.PropertyParametersMap.FirstOrDefault(x => x.Property == field.Property)?.Value,
            };
        }

        private EmPageDetailsFeatureModel BuildFeature(EmPageFeatureDescription feature)
        {
            var detailsFeature = new EmPageDetailsFeatureModel
            {
                Context = new EmPageViewContext
                {
                    Route = feature.Route,
                    Title = feature.Title,
                },
                RouteSegmentsAmount = feature.RouteSegmentsAmount,
                Component = feature.FeatureComponentType,
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

        private EmPageDataFilter BuildFeatureFilter(EmPageFeatureDescription feature, IEmPageModel model)
        {
            if (feature.EmPageBasedRelation == null)
            {
                return new EmPageDataFilter();
            }

            var property = feature.EmPageBasedRelation.SourceProperty;
            var value = feature.EmPageBasedRelation.ParentProperty.GetValue(model);

            var filter = new EmPageDataFilter
            {
                [property] = value,
            };

            return filter;
        }
    }
}