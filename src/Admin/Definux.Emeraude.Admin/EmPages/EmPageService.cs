using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Admin.ValuePipes;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <inheritdoc />
    public class EmPageService : IEmPageService
    {
        private readonly IServiceProvider serviceProvider;
        private readonly EmMainOptions mainOptions;

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
        public async Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(string key)
        {
            var settings = await this.FindAllSchemasDescriptionsAsync();
            return settings.FirstOrDefault(x => x.Key?.Equals(key, StringComparison.OrdinalIgnoreCase) ?? false);
        }

        /// <inheritdoc/>
        public async Task ApplyValuePipesAsync<TEntityModel>(IEnumerable<TEntityModel> models)
        {
            var propertiesValuePipes = this.ExtractPropertiesValuePipes(typeof(TEntityModel));
            foreach (var propertyValuePipes in propertiesValuePipes)
            {
                var currentPropertyValues = models.Select(x => propertyValuePipes.Property.GetValue(x));
                foreach (var (valuePipe, valuePipeParameters) in propertyValuePipes.ValuePipes)
                {
                    await valuePipe.PrepareAsync(currentPropertyValues, valuePipeParameters);
                }

                foreach (var model in models)
                {
                    foreach (var (valuePipe, _) in propertyValuePipes.ValuePipes)
                    {
                        var convertedValue = await valuePipe.ConvertAsync(propertyValuePipes.Property.GetValue(model));
                        propertyValuePipes.Property.SetValue(model, convertedValue);
                    }
                }
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

            var schemaDescriptions = new List<EmPageSchemaDescription>();
            var schemaContext = new EmPageSchemaContext();
            foreach (var schemasImplementationType in schemasImplementationsTypes)
            {
                var schema = this.serviceProvider.GetService(schemasImplementationType);
                var schemaSetupMethod = schemasImplementationType.GetMethod("SetupAsync");
                var schemaSetupResultTask = (Task)schemaSetupMethod?.Invoke(schema, new object[] { schemaContext });
                if (schemaSetupResultTask != null)
                {
                    await schemaSetupResultTask.ConfigureAwait(false);
                    var userDefinedSchemaSettings = (object)((dynamic)schemaSetupResultTask).Result as IEmPageSchemaSettings;
                    var schemaDescription = userDefinedSchemaSettings?.BuildDescription(this.mainOptions.Assemblies);
                    if (schemaDescription != null)
                    {
                        schemaDescriptions.Add(schemaDescription);
                    }
                }
            }

            return schemaDescriptions;
        }

        private IEnumerable<PropertyValuePipes> ExtractPropertiesValuePipes(Type type)
        {
            var targetProperties = type
                .GetProperties();

            var result = new List<PropertyValuePipes>();
            foreach (var property in targetProperties)
            {
                var propertyValuePipesAttributes = property
                    .GetCustomAttributes(typeof(ValuePipeAttribute), true)
                    .Select(x => (ValuePipeAttribute)x);

                this.ValidateValuePipeAttributes(propertyValuePipesAttributes);

                var orderedValuePipesAttributes = propertyValuePipesAttributes.OrderBy(x => x.Order);
                var currentPropertyValuePipe = new PropertyValuePipes
                {
                    Property = property,
                };

                foreach (var valuePipeAttribute in orderedValuePipesAttributes)
                {
                    var currentValuePipe = this.serviceProvider.GetService(valuePipeAttribute.Type) as IValuePipe;
                    var currentValuePipeParameters = valuePipeAttribute.Parameters;
                    currentPropertyValuePipe.ValuePipes.Add((currentValuePipe, currentValuePipeParameters));
                }

                result.Add(currentPropertyValuePipe);
            }

            return result;
        }

        private void ValidateValuePipeAttributes(IEnumerable<ValuePipeAttribute> attributes)
        {
            foreach (var attribute in attributes)
            {
                if (attribute.Type == null)
                {
                    throw new InvalidValuePipeException("Value Pipe Type cannot be null and must be specified.");
                }

                if (attribute.Type.GetInterfaces().All(x => x != typeof(IValuePipe)))
                {
                    throw new InvalidValuePipeException($"{attribute.Type.Name} must implements IValuePipe.");
                }
            }
        }
    }
}