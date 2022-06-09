using System;
using System.Linq.Expressions;
using EmPages.Pages.Results;
using EmPages.Pages.Views;

namespace EmPages.Pages.Pages;

/// <summary>
/// Abstract implementation of page for details presentation.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmDetailsPage<TModel> : EmPage<TModel, EmDetailsViewContext<TModel>, EmDetailsPageResult<TModel>>
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmDetailsPage{TModel}"/> class.
    /// </summary>
    /// <param name="options"></param>
    protected EmDetailsPage(IEmPagesOptions options)
        : base(options)
    {
        this.ViewContext.ConfigureAll(options);
    }

    /// <summary>
    /// Configure model property to details field.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="itemAction"></param>
    /// <returns></returns>
    public EmDetailsPage<TModel> ConfigureField(
        Expression<Func<TModel, object>> property,
        Action<EmDetailsViewItem> itemAction)
    {
        this.ViewContext.Configure(property, itemAction);
        return this;
    }
}