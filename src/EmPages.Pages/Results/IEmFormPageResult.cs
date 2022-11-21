namespace EmPages.Pages.Results;

/// <summary>
/// Form page result.
/// </summary>
public interface IEmFormPageResult : IEmPageResult
{
    /// <summary>
    /// Data of the result.
    /// </summary>
    public IEmPageModel Model { get; set; }
}