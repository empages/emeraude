using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Configuration.Extensions;
using Emeraude.Configuration.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <inheritdoc />
    public class EmPageService : IEmPageService
    {
        private readonly IServiceProvider serviceProvider;
        private readonly EmMainOptions mainOptions;

        private IEnumerable<EmPageSchemaDescription> schemaDescriptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageService"/> class.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <param name="optionsProvider"></param>
        public EmPageService(IServiceProvider serviceProvider, IEmOptionsProvider optionsProvider)
        {
            this.serviceProvider = serviceProvider;
            this.mainOptions = optionsProvider.GetMainOptions();
        }

        /// <inheritdoc />
        public async Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(string route)
        {
            await this.LoadSchemasIfEmptyAsync();
            return this.schemaDescriptions?.FirstOrDefault(x => x.Route?.Equals(route, StringComparison.OrdinalIgnoreCase) ?? false);
        }

        /// <inheritdoc/>
        public async Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(Type modelType)
        {
            await this.LoadSchemasIfEmptyAsync();
            return this.schemaDescriptions?.FirstOrDefault(x => x.ModelType == modelType);
        }

        /// <inheritdoc/>
        public EmPageSchemaDescription FindSchemaDescriptionByContract(Type modelType)
            => this.schemaDescriptions?.FirstOrDefault(x => x.ModelType == modelType);

        /// <inheritdoc/>
        public async Task ApplyValuePipesAsync<TEmPageModel>(IEnumerable<TEmPageModel> models, IEnumerable<IValuePipedViewItem> viewItems)
        {
            var modelType = typeof(TEmPageModel);
            var propertiesValuePipes = this.ExtractPropertiesValuePipes(modelType, viewItems);
            foreach (var propertyValuePipes in propertiesValuePipes)
            {
                var modelProperty = modelType.GetProperty(propertyValuePipes.PropertyName);
                var currentPropertyValues = models.Select(x => modelProperty?.GetValue(x));
                foreach (var (valuePipe, valuePipeParameters) in propertyValuePipes.ValuePipes)
                {
                    await valuePipe.PrepareAsync(currentPropertyValues, valuePipeParameters);
                }

                foreach (var model in models)
                {
                    foreach (var (valuePipe, _) in propertyValuePipes.ValuePipes)
                    {
                        var convertedValue = await valuePipe.ConvertAsync(modelProperty?.GetValue(model));
                        modelProperty.SetValue(model, convertedValue);
                    }
                }
            }
        }

        private async Task LoadSchemasIfEmptyAsync()
        {
            if (this.schemaDescriptions == null || !this.schemaDescriptions.Any())
            {
                this.schemaDescriptions = await this.FindAllSchemasDescriptionsAsync();
            }
        }

        private async Task<IEnumerable<EmPageSchemaDescription>> FindAllSchemasDescriptionsAsync()
        {
            var schemaType = typeof(IEmPageSchema<>);

            var schemasImplementationsTypes = this.mainOptions.Assemblies
                .SelectMany(x => x
                    .GetExportedTypes()
                    .Where(y => y.IsClass && y.GetInterfaces()
                        .Any(z => z.IsGenericType && z.GetGenericTypeDefinition() == schemaType))
                    .ToList())
                .ToList();

            var foundSchemaDescriptions = new List<EmPageSchemaDescription>();
            foreach (var schemasImplementationType in schemasImplementationsTypes)
            {
                var schema = this.serviceProvider.GetService(schemasImplementationType);
                var schemaSetupMethod = schemasImplementationType.GetMethod("SetupAsync");
                var schemaSetupResultTask = (Task)schemaSetupMethod?.Invoke(schema, new object[] { });
                if (schemaSetupResultTask != null)
                {
                    await schemaSetupResultTask.ConfigureAwait(false);
                    var userDefinedSchemaSettings = (object)((dynamic)schemaSetupResultTask).Result as IEmPageSchemaSettings;
                    var schemaDescription = userDefinedSchemaSettings?.BuildDescription(this.mainOptions.Assemblies);
                    if (schemaDescription != null)
                    {
                        foundSchemaDescriptions.Add(schemaDescription);
                    }
                }
            }

            foreach (var schemaDescription in foundSchemaDescriptions)
            {
                if (schemaDescription.UseAsFeature)
                {
                    schemaDescription.ParentSchema =
                        foundSchemaDescriptions.FirstOrDefault(x => x.DetailsView.Features.Any(y => y.Route == schemaDescription.Route));

                    var relatedFeature = schemaDescription.ParentSchema.DetailsView.Features.First(x => x.Route == schemaDescription.Route);
                    schemaDescription.ParentRelation = relatedFeature.EmPageBasedRelation;

                    var newBreadcrumbIndex = 0;
                    var parentSchemaFeatureBreadcrumbs = relatedFeature.Breadcrumbs;

                    foreach (var parentDetailsViewBreadcrumb in parentSchemaFeatureBreadcrumbs)
                    {
                        var currentParentBreadcrumb = new EmPageBreadcrumb
                        {
                            Title = parentDetailsViewBreadcrumb.Title,
                            Href = parentDetailsViewBreadcrumb.Href,
                            IsActive = true,
                            HideContextually = parentDetailsViewBreadcrumb.HideContextually,
                            Order = parentDetailsViewBreadcrumb.Order - 1000,
                        };

                        schemaDescription.IndexView.Breadcrumbs.Insert(newBreadcrumbIndex, currentParentBreadcrumb);
                        schemaDescription.DetailsView.Breadcrumbs.Insert(newBreadcrumbIndex, currentParentBreadcrumb);
                        schemaDescription.FormView.Breadcrumbs.Insert(newBreadcrumbIndex, currentParentBreadcrumb);
                        newBreadcrumbIndex++;
                    }
                }
            }

            return foundSchemaDescriptions;
        }

        private IEnumerable<PropertyValuePipes> ExtractPropertiesValuePipes(Type type, IEnumerable<IValuePipedViewItem> valuePipedViewItems)
        {
            if (valuePipedViewItems == null)
            {
                throw new ArgumentNullException(nameof(valuePipedViewItems));
            }

            var valuePipedViewItemsWithRegisteredPipes = valuePipedViewItems.Where(x => x.ValuePipes.Any());

            var result = new List<PropertyValuePipes>();
            var scopedServiceProvider = this.serviceProvider.CreateScope().ServiceProvider;
            foreach (var viewItem in valuePipedViewItemsWithRegisteredPipes)
            {
                var currentPropertyValuePipe = new PropertyValuePipes
                {
                    PropertyName = ((IViewItem)viewItem).SourceName,
                };

                foreach (var (valuePipeType, valuePipeParameters) in viewItem.ValuePipes)
                {
                    var currentValuePipe = scopedServiceProvider.GetService(valuePipeType) as IValuePipe;
                    currentPropertyValuePipe.ValuePipes.Add((currentValuePipe, valuePipeParameters));
                }

                result.Add(currentPropertyValuePipe);
            }

            return result;
        }
    }
}