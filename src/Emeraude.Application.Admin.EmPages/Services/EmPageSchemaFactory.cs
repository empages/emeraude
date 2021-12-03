using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Configuration.Extensions;
using Emeraude.Configuration.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <inheritdoc />
    public class EmPageSchemaFactory : IEmPageSchemaFactory
    {
        private readonly IEnumerable<Type> schemasTypes;
        private readonly IServiceProvider serviceProvider;
        private readonly EmMainOptions mainOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageSchemaFactory"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <param name="serviceProvider"></param>
        public EmPageSchemaFactory(
            IEmOptionsProvider optionsProvider,
            IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.mainOptions = optionsProvider.GetMainOptions();
            this.schemasTypes = this.FetchSchemaTypes();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<EmPageSchemaDescription>> CreateSchemasInstancesAsync()
        {
            return await this.BuildSchemasAsync();
        }

        private async Task<IEnumerable<EmPageSchemaDescription>> BuildSchemasAsync()
        {
            var scopedServiceProvider = this.serviceProvider.CreateAsyncScope().ServiceProvider;
            var foundSchemaDescriptions = new List<EmPageSchemaDescription>();
            foreach (var schemasImplementationType in this.schemasTypes)
            {
                var schema = scopedServiceProvider.GetService(schemasImplementationType);
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

            this.ConsolidateSchemas(foundSchemaDescriptions);

            return foundSchemaDescriptions;
        }

        private IEnumerable<Type> FetchSchemaTypes()
        {
            var schemaType = typeof(IEmPageSchema<>);

            var foundSchemaTypes = this.mainOptions
                .Assemblies
                .Distinct()
                .SelectMany(x => x
                    .GetExportedTypes()
                    .Where(y => y.IsClass && y.GetInterfaces()
                        .Any(z => z.IsGenericType && z.GetGenericTypeDefinition() == schemaType))
                    .ToList())
                .ToList();

            return foundSchemaTypes;
        }

        private void ConsolidateSchemas(IEnumerable<EmPageSchemaDescription> schemaDescriptions)
        {
            foreach (var schemaDescription in schemaDescriptions)
            {
                if (schemaDescription.UseAsFeature)
                {
                    schemaDescription.ParentSchema =
                        schemaDescriptions.FirstOrDefault(x => x.DetailsView.Features.Any(y => y.Route == schemaDescription.Route));

                    if (schemaDescription.ParentSchema == null)
                    {
                        throw new EmPageInvalidSchemaDefinitionException($"EmPage with route '{schemaDescription.Route}' is used as a feature but the system cannot find its parent schema");
                    }

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
        }
    }
}