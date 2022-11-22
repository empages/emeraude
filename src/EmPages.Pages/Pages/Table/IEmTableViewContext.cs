using System.Collections.Generic;

namespace EmPages.Pages.Pages.Table;

/// <summary>
/// Contract that represents table view context specifications.
/// </summary>
public interface IEmTableViewContext : IEmPageViewContextStrategy
{
    /// <summary>
    /// Gets row actions.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    IEnumerable<EmAction> GetRowActions(IEmPageModel model, EmPageRequest request);
}