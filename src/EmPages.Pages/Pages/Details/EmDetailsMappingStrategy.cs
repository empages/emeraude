using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmPages.Pages.Pages.Details;

/// <summary>
/// Mapping strategy for details response.
/// </summary>
internal class EmDetailsMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        if (page is not IEmDetailsPage detailsPage)
        {
            throw new ArgumentNullException(nameof(page));
        }

        await detailsPage.SetupAsync();
        detailsPage.ValidatePageSetup();

        var pageResult = (await detailsPage.FetchPageDataAsync(request)) as IEmDetailsPageResult;
        if (pageResult.Model is null)
        {
            throw new EmPageNotFoundException("Model behind the page does not exist");
        }

        var viewContext = detailsPage.GetViewContext() as IEmDetailsViewContext;
        var viewItems = (IReadOnlyList<EmDetailsViewItem>)viewContext?.ViewItems;

        var response = new EmDetailsResponseModel
        {
            Title = detailsPage.ComputeTitle(pageResult.Model),
        };

        var fieldIndex = 0;
        foreach (var viewItem in viewItems)
        {
            response.Fields.Add(new EmDetailsResponseField
            {
                Index = fieldIndex,
                Label = viewItem.Label,
                Value = pageResult.Model.GetPropertyValue(viewItem.SourceName),
            });

            response.Components.Add(new EmResponseComponent(viewItem.Component, fieldIndex));

            fieldIndex++;
        }

        var pageActions = viewContext.GetPageActions(new List<IEmPageModel> { pageResult.Model }, request);
        foreach (var pageAction in pageActions)
        {
            response.Actions.Add(new EmResponseAction(pageAction));
        }

        var typeDescriptions = viewContext.ExtractTypeDescriptions(request);
        foreach (var typeDescription in typeDescriptions)
        {
            response.TypeDescriptions.Add(typeDescription);
        }

        return response;
    }
}