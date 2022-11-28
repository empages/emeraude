using System.Collections.Generic;

namespace EmPages.Pages;

/// <summary>
/// Service for access the layout.
/// </summary>
public interface IEmLayoutService
{
    /// <summary>
    /// Gets the layout.
    /// </summary>
    /// <returns></returns>
    EmLayout GetLayout();
}