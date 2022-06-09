namespace EmPages.Pages.Views;

/// <summary>
/// Page view context representing form view.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmFormViewContext<TModel> : EmPageViewContextStrategy<EmFormViewItem, TModel>
    where TModel : class, IEmPageModel, new()
{
}