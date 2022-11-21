using System.Collections.Generic;
using System.Threading.Tasks;
using EmPages.Pages.ResponseModels;
using EmPages.Pages.Results;
using EmPages.Pages.Views;

namespace EmPages.Pages.Services;

/// <summary>
/// Mapping strategy for form response.
/// </summary>
internal class EmFormMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        await page.SetupAsync();
        var pageResult = (await page.FetchPageDataAsync(request)) as IEmFormPageResult;
        var viewContext = page.GetViewContext() as IEmFormViewContext;
        var viewItems = (IReadOnlyList<EmFormViewItem>)viewContext?.ViewItems;

        var response = new EmTableResponseModel();

        return response;
    }
}