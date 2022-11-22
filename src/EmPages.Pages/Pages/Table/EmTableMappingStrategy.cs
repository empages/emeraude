using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmPages.Pages.Pages.Table;

/// <summary>
/// Mapping strategy for table response.
/// </summary>
internal class EmTableMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        if (page is not IEmTablePage tablePage)
        {
            throw new ArgumentNullException(nameof(page));
        }

        await tablePage.SetupAsync();
        tablePage.ValidatePageSetup();

        var pageResult = (await tablePage.FetchPageDataAsync(request)) as IEmTablePageResult;
        var viewContext = tablePage.GetViewContext() as IEmTableViewContext;
        var viewItems = (IReadOnlyList<EmTableViewItem>)viewContext?.ViewItems;

        var response = new EmTableResponseModel
        {
            Title = tablePage.ComputeTitle(null),
        };

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