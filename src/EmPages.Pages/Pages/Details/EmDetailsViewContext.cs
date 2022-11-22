namespace EmPages.Pages.Pages.Details;

/// <summary>
/// Page view context representing details view.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmDetailsViewContext<TModel> : EmPageViewContextStrategy<EmDetailsViewItem, TModel>, IEmDetailsViewContext
    where TModel : class, IEmPageModel, new()
{
}