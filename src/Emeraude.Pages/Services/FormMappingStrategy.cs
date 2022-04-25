using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Pages.ResponseModels;
using Emeraude.Pages.Views;

namespace Emeraude.Pages.Services;

/// <summary>
/// Mapping strategy for form response.
/// </summary>
internal class FormMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        await page.SetupAsync();
        var pageData = await page.FetchPageDataAsync(request);
        var viewItems = (IReadOnlyList<EmFormViewItem>)page.GetViewContext().ViewItems;

        return new EmFormResponseModel();
    }
}