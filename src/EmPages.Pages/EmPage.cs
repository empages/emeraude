using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of EmPages page.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
/// <typeparam name="TViewContext">View context type.</typeparam>
/// <typeparam name="TPageResult">Result type.</typeparam>
public abstract class EmPage<TModel, TViewContext, TPageResult> : IEmPage<TModel, TViewContext, TPageResult>
    where TModel : class, IEmPageModel, new()
    where TViewContext : class, IEmPageViewContextStrategy<TModel>, new()
    where TPageResult : class, IEmPageResult, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPage{TModel, TViewContext, TPageResult}"/> class.
    /// </summary>
    /// <param name="options"></param>
    protected EmPage(IEmPagesOptions options)
    {
        this.Options = options;
        this.Permissions = new List<string>();
        this.ViewContext = new TViewContext();
    }

    /// <inheritdoc/>
    public string Title { get; protected set; }

    /// <inheritdoc/>
    public IList<string> Permissions { get; }

    /// <inheritdoc/>
    public Type ModelType => typeof(TModel);

    /// <inheritdoc/>
    public TViewContext ViewContext { get; }

    /// <summary>
    /// Page options.
    /// </summary>
    protected IEmPagesOptions Options { get; }

    /// <inheritdoc/>
    public abstract Task SetupAsync();

    /// <inheritdoc/>
    public async Task<IEmPageResult> FetchPageDataAsync(EmPageRequest request) =>
        await this.FetchDataAsync(request);

    /// <inheritdoc/>
    public IEmPageViewContextStrategy GetViewContext() => this.ViewContext;

    /// <inheritdoc/>
    public string ComputeTitle(IEmPageModel model) =>
        this.ComputeTitle(model as TModel);

    /// <inheritdoc/>
    public virtual string ComputeTitle(TModel model) => this.Title;

    /// <inheritdoc/>
    public abstract Task<TPageResult> FetchDataAsync(EmPageRequest request);

    /// <inheritdoc/>
    public abstract void ValidatePageSetup();

    /// <summary>
    /// Adds an action for current page.
    /// </summary>
    /// <param name="actionBuilder"></param>
    protected void AddAction(Func<IEnumerable<TModel>, EmPageRequest, EmAction> actionBuilder) =>
        this.ViewContext.AddAction(actionBuilder);
}