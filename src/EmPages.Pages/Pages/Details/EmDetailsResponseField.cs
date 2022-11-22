namespace EmPages.Pages.Pages.Details;

/// <summary>
/// EmPage form response input.
/// </summary>
public class EmDetailsResponseField
{
    /// <summary>
    /// Field index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Label of the field.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Field value.
    /// </summary>
    public object Value { get; set; }
}