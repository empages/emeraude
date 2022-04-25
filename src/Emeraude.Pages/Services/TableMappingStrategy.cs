using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Pages.ResponseModels;
using Emeraude.Pages.Views;

namespace Emeraude.Pages.Services;

/// <summary>
/// Mapping strategy for table response.
/// </summary>
internal class TableMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        await page.SetupAsync();
        var pageData = await page.FetchPageDataAsync(request);
        var viewItems = (IReadOnlyList<EmTableViewItem>)page.GetViewContext().ViewItems;

        return new EmTableResponseModel();
    }
}