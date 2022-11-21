using System.Collections.Generic;

namespace EmPages.Pages.Results;

/// <summary>
/// Table page result.
/// </summary>
public interface IEmTablePageResult : IEmPageResult
{
    /// <summary>
    /// Data of the result.
    /// </summary>
    IEnumerable<IEmPageModel> Models { get; set; }

    /// <summary>
    /// Total count of all models.
    /// </summary>
    int TotalCount { get; set; }

    /// <summary>
    /// Count of the requested models.
    /// </summary>
    int TakenCount { get; set; }

    /// <summary>
    /// Count of the skipped models.
    /// </summary>
    int SkippedCount { get; set; }
}