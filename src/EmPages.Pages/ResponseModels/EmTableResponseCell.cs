namespace EmPages.Pages.ResponseModels;

/// <summary>
/// EmPage table response cell.
/// </summary>
public class EmTableResponseCell
{
    /// <summary>
    /// Cell index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Cell value.
    /// </summary>
    public object Value { get; set; }
}