using System.Collections.Generic;

namespace Emeraude.Pages.Results;

/// <summary>
/// Table page result.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmTablePageResult<TModel> : IEmPageResult
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Data of the result.
    /// </summary>
    public IEnumerable<TModel> Models { get; set; }

    /// <summary>
    /// Total count of all models.
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// Count of the requested models.
    /// </summary>
    public int TakenCount { get; set; }

    /// <summary>
    /// Count of the skipped models.
    /// </summary>
    public int SkippedCount { get; set; }
}