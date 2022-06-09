using System;
using System.Linq.Expressions;
using EmPages.Pages.Results;
using EmPages.Pages.Views;

namespace EmPages.Pages.Pages;

/// <summary>
/// Abstract implementation of page for table presentation.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmTablePage<TModel> : EmPage<TModel, EmTableViewContext<TModel>, EmTablePageResult<TModel>>
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTablePage{TModel}"/> class.
    /// </summary>
    /// <param name="options"></param>
    protected EmTablePage(IEmPagesOptions options)
        : base(options)
    {
        this.ViewContext.ConfigureAll(options);
    }

    /// <summary>
    /// Configure model property to table column.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="itemAction"></param>
    /// <returns></returns>
    public EmTablePage<TModel> ConfigureColumn(
        Expression<Func<TModel, object>> property,
        Action<EmTableViewItem> itemAction)
    {
        this.ViewContext.Configure(property, itemAction);
        return this;
    }

    /// <summary>
    /// Adds row action for current page.
    /// </summary>
    /// <param name="actionBuilder"></param>
    public void AddRowAction(Func<TModel, EmPageRequest, EmAction> actionBuilder) =>
        this.ViewContext.AddRowAction(actionBuilder);
}