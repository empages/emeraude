namespace EmPages.Pages;

/// <summary>
/// Contract that defines an item from the layout.
/// </summary>
public interface IEmLayoutItem
{
    /// <summary>
    /// Layout context of the target object.
    /// </summary>
    /// <returns></returns>
    EmLayoutContext BuildLayoutContext();
}