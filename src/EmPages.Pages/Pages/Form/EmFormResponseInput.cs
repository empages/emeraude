namespace EmPages.Pages.Pages.Form;

/// <summary>
/// EmPage form response input.
/// </summary>
public class EmFormResponseInput
{
    /// <summary>
    /// Input index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Label of the input.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Input value.
    /// </summary>
    public object Value { get; set; }

    /// <summary>
    /// Input flag that indicates whether the input is required.
    /// </summary>
    public bool Required { get; set; }
}