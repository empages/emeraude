using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmPages.Pages.Pages.Form;

/// <summary>
/// Mapping strategy for form response.
/// </summary>
internal class EmFormMappingStrategy : IEmMappingStrategy
{
    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request)
    {
        if (page is not IEmFormPage formPage)
        {
            throw new ArgumentNullException(nameof(page));
        }

        await formPage.SetupAsync();
        formPage.ValidatePageSetup();

        var pageResult = (await formPage.FetchPageDataAsync(request)) as IEmFormPageResult;
        if (pageResult.Model is null)
        {
            throw new EmPageNotFoundException("Model behind the page does not exist");
        }

        var viewContext = formPage.GetViewContext() as IEmFormViewContext;
        var viewItems = (IReadOnlyList<EmFormViewItem>)viewContext?.ViewItems;

        var response = new EmFormResponseModel
        {
            Title = formPage.ComputeTitle(pageResult.Model),
            SubmitCommand = formPage.SubmitCommandName,
        };

        var inputIndex = 0;
        foreach (var viewItem in viewItems)
        {
            response.Inputs.Add(new EmFormResponseInput
            {
                Index = inputIndex,
                Label = viewItem.Label,
                Required = viewItem.Required,
                Value = pageResult.Model.GetPropertyValue(viewItem.SourceName),
            });

            response.Components.Add(new EmResponseComponent(viewItem.Component, inputIndex));

            inputIndex++;
        }

        var pageActions = viewContext.GetPageActions(new List<IEmPageModel> { pageResult.Model }, request);
        foreach (var pageAction in pageActions)
        {
            response.Actions.Add(new EmResponseAction(pageAction));
        }

        return response;
    }
}