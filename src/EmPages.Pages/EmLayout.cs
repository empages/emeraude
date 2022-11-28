using System.Collections.Generic;

namespace EmPages.Pages;

/// <summary>
/// EmPages layout.
/// </summary>
public class EmLayout
{
    /// <summary>
    /// Collection of all navigation items.
    /// </summary>
    public IEnumerable<EmNavigationItem> NavigationItems { get; internal set; }
}