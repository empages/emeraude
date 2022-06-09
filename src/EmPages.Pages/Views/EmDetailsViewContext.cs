namespace EmPages.Pages.Views;

/// <summary>
/// Page view context representing details view.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmDetailsViewContext<TModel> : EmPageViewContextStrategy<EmDetailsViewItem, TModel>
    where TModel : class, IEmPageModel, new()
{
}