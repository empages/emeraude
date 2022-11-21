using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmPages.Pages.Extensions;
using EmPages.Pages.ResponseModels;
using EmPages.Pages.Results;
using EmPages.Pages.Views;

namespace EmPages.Pages.Services;

/// <summary>
/// Mapping strategy for table response.
/// </summary>
internal class EmTableMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        await page.SetupAsync();
        var pageResult = (await page.FetchPageDataAsync(request)) as IEmTablePageResult;
        var viewContext = page.GetViewContext() as IEmTableViewContext;
        var viewItems = (IReadOnlyList<EmTableViewItem>)viewContext?.ViewItems;

        var response = new EmTableResponseModel();

        var rowIndex = 0;
        foreach (var model in pageResult.Models)
        {
            var row = new EmTableResponseRow
            {
                Index = rowIndex,
            };
            var cellIndex = 0;

            foreach (var viewItem in viewItems)
            {
                var cell = new EmTableResponseCell
                {
                    Index = cellIndex,
                    Value = model.GetPropertyValue(viewItem.SourceName),
                };

                row.Cells.Add(cell);

                if (rowIndex == 0)
                {
                    response.Header.Cells.Add(new EmTableResponseHeaderCell
                    {
                        Index = cellIndex,
                        Title = viewItem.Label,
                    });
                    response.Components.Add(new EmResponseComponent(viewItem.Component, cellIndex));
                }

                cellIndex++;
            }

            var rowActions = viewContext.GetRowActions(model, request);
            foreach (var rowAction in rowActions)
            {
                row.Actions.Add(new EmResponseAction(rowAction));
            }

            response.Rows.Add(row);
            rowIndex++;
        }

        var pageActions = viewContext.GetPageActions(pageResult.Models, request);
        foreach (var pageAction in pageActions)
        {
            response.Actions.Add(new EmResponseAction(pageAction));
        }

        return response;
    }
}