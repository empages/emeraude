namespace EmPages.Pages.Results;

/// <summary>
/// Details page result.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmDetailsPageResult<TModel> : IEmPageResult
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Data of the result.
    /// </summary>
    public TModel Model { get; set; }
}