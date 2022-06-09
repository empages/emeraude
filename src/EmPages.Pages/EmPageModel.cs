namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of page model.
/// </summary>
public abstract class EmPageModel : IEmPageModel
{
    /// <inheritdoc/>
    public string Id { get; set; }
}