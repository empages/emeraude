namespace EmPages.Pages.Pages.Details;

/// <summary>
/// Details page result.
/// </summary>
public interface IEmDetailsPageResult : IEmPageResult
{
    /// <summary>
    /// Data of the result.
    /// </summary>
    public IEmPageModel Model { get; set; }
}