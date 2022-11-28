namespace EmPages.Pages;

/// <summary>
/// Implementation of layout item.
/// </summary>
public class EmNavigationItem
{
    /// <summary>
    /// Order of the item.
    /// </summary>
    public int Order { get; init; }

    /// <summary>
    /// Route of the item.
    /// </summary>
    public string Route { get; init; }

    /// <summary>
    /// Title of the item.
    /// </summary>
    public string Title { get; init; }

    /// <summary>
    /// Icon of the item.
    /// </summary>
    public string Icon { get; init; }
}