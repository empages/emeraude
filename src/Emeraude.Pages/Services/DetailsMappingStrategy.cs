using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Pages.ResponseModels;
using Emeraude.Pages.Views;

namespace Emeraude.Pages.Services;

/// <summary>
/// Mapping strategy for details response.
/// </summary>
internal class DetailsMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        await page.SetupAsync();
        var pageData = await page.FetchPageDataAsync(request);
        var viewItems = (IReadOnlyList<EmDetailsViewItem>)page.GetViewContext().ViewItems;

        return new EmDetailsResponseModel();
    }
}