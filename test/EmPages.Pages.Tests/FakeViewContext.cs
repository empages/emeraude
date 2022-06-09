namespace EmPages.Pages.Tests;

public class FakeViewContext<TModel> : EmPageViewContextStrategy<FakeViewItem, TModel>
    where TModel : class, IEmPageModel, new()
{
}