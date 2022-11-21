using System.Collections.Generic;

namespace EmPages.Pages.Results;

/// <summary>
/// Table page result.
/// </summary>
public class EmTablePageResult : IEmTablePageResult
{
    /// <inheritdoc/>
    public IEnumerable<IEmPageModel> Models { get; set; }

    /// <inheritdoc/>
    public int TotalCount { get; set; }

    /// <inheritdoc/>
    public int TakenCount { get; set; }

    /// <inheritdoc/>
    public int SkippedCount { get; set; }
}