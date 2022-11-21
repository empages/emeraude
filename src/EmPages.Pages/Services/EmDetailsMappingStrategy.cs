using System.Collections.Generic;
using System.Threading.Tasks;
using EmPages.Pages.ResponseModels;
using EmPages.Pages.Results;
using EmPages.Pages.Views;

namespace EmPages.Pages.Services;

/// <summary>
/// Mapping strategy for details response.
/// </summary>
internal class EmDetailsMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        await page.SetupAsync();
        var pageResult = (await page.FetchPageDataAsync(request)) as IEmDetailsPageResult;
        var viewContext = page.GetViewContext() as IEmDetailsViewContext;
        var viewItems = (IReadOnlyList<EmDetailsViewItem>)viewContext?.ViewItems;

        var response = new EmDetailsResponseModel();

        return response;
    }
}