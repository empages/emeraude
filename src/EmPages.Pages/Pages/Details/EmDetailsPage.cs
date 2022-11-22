using System;
using System.Linq.Expressions;

namespace EmPages.Pages.Pages.Details;

/// <summary>
/// Abstract implementation of page for details presentation.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmDetailsPage<TModel> : EmPage<TModel, EmDetailsViewContext<TModel>, EmDetailsPageResult>, IEmDetailsPage
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

    /// <inheritdoc/>
    public override void ValidatePageSetup()
    {
    }
}