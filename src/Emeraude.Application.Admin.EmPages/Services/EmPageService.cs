using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Models;
using Emeraude.Application.Admin.EmPages.Schema;

namespace Emeraude.Application.Admin.EmPages.Services;

/// <inheritdoc />
public class EmPageService : IEmPageService
{
    private readonly IServiceProvider serviceProvider;
    private readonly IEmPageSchemaFactory schemaFactory;

    private IEnumerable<EmPageSchemaDescription> schemaDescriptions;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageService"/> class.
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <param name="schemaFactory"></param>
    public EmPageService(
        IServiceProvider serviceProvider,
        IEmPageSchemaFactory schemaFactory)
    {
        this.serviceProvider = serviceProvider;
        this.schemaFactory = schemaFactory;
    }

    /// <inheritdoc />
    public async Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(string route)
    {
        await this.LoadSchemasIfEmptyAsync();
        var schemaDescription = this.schemaDescriptions?.FirstOrDefault(x => x.Route?.Equals(route, StringComparison.OrdinalIgnoreCase) ?? false);
        if (schemaDescription == null)
        {
            throw new EmPageNotFoundException($"A schema with route: '{route}' cannot be found");
        }

        return schemaDescription;
    }

    /// <inheritdoc/>
    public async Task<EmPageSchemaDescription> FindSchemaDescriptionAsync(Type modelType)
    {
        await this.LoadSchemasIfEmptyAsync();
        var schemaDescription = this.schemaDescriptions?.FirstOrDefault(x => x.ModelType == modelType);
        if (schemaDescription == null)
        {
            throw new EmPageNotFoundException($"A schema for model of type: '{modelType?.FullName}' cannot be found");
        }

        return schemaDescription;
    }

    /// <inheritdoc/>
    public EmPageSchemaDescription FindSchemaDescriptionByContract(Type modelType)
        => this.schemaDescriptions?.FirstOrDefault(x => x.ModelType == modelType);

    /// <inheritdoc/>
    public async Task ApplyValuePipesAsync<TEmPageModel>(IEnumerable<TEmPageModel> models, IEnumerable<IValuePipedViewItem> viewItems)
    {
        var modelType = typeof(TEmPageModel);
        var propertiesValuePipes = this.ExtractPropertiesValuePipes(viewItems);

        // Each property of the model is evaluated separately.
        foreach (var propertyValuePipes in propertiesValuePipes)
        {
            var modelProperty = modelType.GetProperty(propertyValuePipes.PropertyName);
            var currentPropertyValues = models.Select(x => modelProperty?.GetValue(x));

            // We are preparing the data in the value pipes in order to minimize work with the database.
            // Duplicated value pipes will be prepared with same values. Consider cache in the pipe implementation.
            foreach (var (valuePipe, valuePipeParameters) in propertyValuePipes.ValuePipes)
            {
                await valuePipe.PrepareAsync(currentPropertyValues, valuePipeParameters);
            }

            // For each model we are executing value pipes for each piped item.
            foreach (var model in models)
            {
                foreach (var (valuePipe, _) in propertyValuePipes.ValuePipes)
                {
                    var convertedValue = await valuePipe.ConvertAsync(modelProperty?.GetValue(model));
                    modelProperty?.SetValue(model, convertedValue);
                }
            }
        }
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<EmPageSimpleModel>> GetEmPagesListAsync()
    {
        await this.LoadSchemasIfEmptyAsync();
        var resultModels = new List<EmPageSimpleModel>();
        var orderedSchemaDescriptions = this.schemaDescriptions.OrderByDescending(x => x.PriorityIndex);
        foreach (var schemaDescription in orderedSchemaDescriptions)
        {
            if (!schemaDescription.UseAsFeature)
            {
                var currentEmPageModel = new EmPageSimpleModel
                {
                    Route = schemaDescription.Route,
                    Title = schemaDescription.Title,
                    Description = schemaDescription.Description,
                };
                resultModels.Add(currentEmPageModel);
            }
        }

        return resultModels;
    }

    private async Task LoadSchemasIfEmptyAsync()
    {
        if (this.schemaDescriptions == null || !this.schemaDescriptions.Any())
        {
            this.schemaDescriptions = await this.schemaFactory.CreateSchemasInstancesAsync();
        }
    }

    private IEnumerable<PropertyValuePipes> ExtractPropertiesValuePipes(IEnumerable<IValuePipedViewItem> valuePipedViewItems)
    {
        if (valuePipedViewItems == null)
        {
            throw new ArgumentNullException(nameof(valuePipedViewItems));
        }

        var valuePipedViewItemsWithRegisteredPipes = valuePipedViewItems.Where(x => x.ValuePipes.Any());

        var result = new List<PropertyValuePipes>();
        foreach (var viewItem in valuePipedViewItemsWithRegisteredPipes)
        {
            var currentPropertyValuePipe = new PropertyValuePipes
            {
                PropertyName = ((IViewItem)viewItem).SourceName,
            };

            foreach (var (valuePipeType, valuePipeParameters) in viewItem.ValuePipes)
            {
                var currentValuePipe = this.serviceProvider.GetService(valuePipeType) as IValuePipe;
                currentPropertyValuePipe.ValuePipes.Add((currentValuePipe, valuePipeParameters));
            }

            result.Add(currentPropertyValuePipe);
        }

        return result;
    }
}