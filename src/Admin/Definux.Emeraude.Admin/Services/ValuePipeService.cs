using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.ValuePipes;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.Services
{
    /// <inheritdoc />
    public class ValuePipeService : IValuePipeService
    {
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuePipeService"/> class.
        /// </summary>
        /// <param name="serviceProvider"></param>
        public ValuePipeService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
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

        private IEnumerable<PropertyValuePipes> ExtractPropertiesValuePipes(Type type)
        {
            var targetProperties = type
                .GetProperties()
                .Where(x => x.HasAttribute<ValuePipeAttribute>());

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