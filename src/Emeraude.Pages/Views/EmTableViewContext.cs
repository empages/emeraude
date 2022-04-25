using System;
using System.Collections.Generic;

namespace Emeraude.Pages.Views;

/// <summary>
/// Page view context representing table view.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmTableViewContext<TModel> : EmPageViewContextStrategy<EmTableViewItem, TModel>
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
    /// List of all action that each row has.
    /// </summary>
    public IReadOnlyList<Func<TModel, EmPageRequest, EmAction>> RowActions => this.rowActionsBuilders;

    /// <summary>
    /// Adds row action for current table view.
    /// </summary>
    /// <param name="actionBuilder"></param>
    public void AddRowAction(Func<TModel, EmPageRequest, EmAction> actionBuilder) =>
        this.rowActionsBuilders.Add(actionBuilder);
}