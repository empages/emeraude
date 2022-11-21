using System;
using System.Linq.Expressions;
using EmPages.Pages.Results;
using EmPages.Pages.Views;

namespace EmPages.Pages.Pages;

/// <summary>
/// Abstract implementation of page for form presentation.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmFormPage<TModel> : EmPage<TModel, EmFormViewContext<TModel>, EmFormPageResult>
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmFormPage{TModel}"/> class.
    /// </summary>
    /// <param name="options"></param>
    protected EmFormPage(IEmPagesOptions options)
        : base(options)
    {
        this.ViewContext.ConfigureAll(options);
    }

    /// <summary>
    /// Configure model property to form field.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="itemAction"></param>
    /// <returns></returns>
    public EmFormPage<TModel> ConfigureInput(
        Expression<Func<TModel, object>> property,
        Action<EmFormViewItem> itemAction)
    {
        this.ViewContext.Configure(property, itemAction);
        return this;
    }
}