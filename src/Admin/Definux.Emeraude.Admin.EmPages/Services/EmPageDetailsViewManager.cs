using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Data;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.Schema.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView;
using Definux.Emeraude.Admin.EmPages.UI.Utilities;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.Services
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

            this.MapToViewModel(schemaDescription.DetailsView, model);

            foreach (var feature in schemaDescription.DetailsView.Features)
            {
                var detailsFeature = this.BuildFeature(feature);
                var featureSchema = this.emPageService.FindSchemaDescriptionByContract(feature.EmPageBasedLinkConfiguration?.Item2?.DeclaringType);
                detailsFeature.Filter = this.BuildFeatureFilter(feature, rawModel);
                detailsFeature.EmPageRoute = featureSchema?.Route;
                model.Features.Add(detailsFeature);
            }

            this.SetDataRelatedPlaceholders(model.Context.Breadcrumbs, rawModel);
            this.SetDataRelatedPlaceholders(model.Context.NavbarActions, rawModel);
            if (model.Features.Any())
            {
                foreach (var feature in model.Features)
                {
                    this.SetDataRelatedPlaceholders(feature.Context.Breadcrumbs, rawModel);
                }
            }

            var detailsResult = await dataManager.DetailsAsync(modelId);
            if (detailsResult != null)
            {
                foreach (var field in detailsResult.Fields)
                {
                    if (model.PropertyComponentPair.ContainsKey(field.Property))
                    {
                        model.Fields.Add(this.BuildField(schemaDescription, field, model));
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
            if (feature.EmPageBasedLinkConfiguration == null ||
                feature.EmPageBasedLinkConfiguration.Item1 == null ||
                feature.EmPageBasedLinkConfiguration.Item2 == null)
            {
                return new EmPageDataFilter();
            }

            var targetModelType = feature.EmPageBasedLinkConfiguration.Item2.DeclaringType;
            var schemaDescription = this.emPageService.FindSchemaDescriptionByContract(targetModelType);
            var dataManager = this.GetDataManagerInstance(schemaDescription);
            var property = feature.EmPageBasedLinkConfiguration.Item2;
            var value = feature.EmPageBasedLinkConfiguration.Item1.GetValue(model);
            var filter = new EmPageDataFilter
            {
                [property] = value,
            };

            return filter;
        }
    }
}