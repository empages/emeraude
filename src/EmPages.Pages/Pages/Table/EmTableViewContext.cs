using System;
using System.Collections.Generic;
using System.Linq;

namespace EmPages.Pages.Pages.Table;

/// <summary>
/// Page view context representing table view.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmTableViewContext<TModel> : EmPageViewContextStrategy<EmTableViewItem, TModel>, IEmTableViewContext
    where TModel : class, IEmPageModel, new()
{
    private readonly List<Func<TModel, EmPageRequest, EmAction>> rowActionsBuilders;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmTableViewContext{TModel}"/> class.
    /// </summary>
    public EmTableViewContext()
    {
        this.rowActionsBuilders = new List<Func<TModel, EmPageRequest, EmAction>>();
    }

    /// <summary>
    /// Adds row action for current table view.
    /// </summary>
    /// <param name="actionBuilder"></param>
    public void AddRowAction(Func<TModel, EmPageRequest, EmAction> actionBuilder) =>
        this.rowActionsBuilders.Add(actionBuilder);

    /// <summary>
    /// Gets row actions.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public IEnumerable<EmAction> GetRowActions(IEmPageModel model, EmPageRequest request) =>
        this.rowActionsBuilders
            .Select(x => x.Invoke(model as TModel, request))
            .ToList();
}