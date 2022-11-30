using System;
using System.Linq.Expressions;

namespace EmPages.Pages.Pages.Table;

/// <summary>
/// Abstract implementation of page for table presentation.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmTablePage<TModel> : EmPage<TModel, EmTableViewContext<TModel>, EmTablePageResult>, IEmTablePage
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTablePage{TModel}"/> class.
    /// </summary>
    protected EmTablePage()
    {
        this.ViewContext.ConfigureAll();
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

    /// <inheritdoc/>
    public override void ValidatePageSetup()
    {
    }

    /// <summary>
    /// Adds row action for current page.
    /// </summary>
    /// <param name="actionBuilder"></param>
    protected void AddRowAction(Func<TModel, EmPageRequest, EmAction> actionBuilder) =>
        this.ViewContext.AddRowAction(actionBuilder);
}