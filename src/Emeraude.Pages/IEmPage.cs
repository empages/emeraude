using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Emeraude.Pages;

/// <summary>
/// Base contract for Emeraude page.
/// </summary>
public interface IEmPage
{
    /// <summary>
    /// Title of the page.
    /// </summary>
    string Title { get; }

    /// <summary>
    /// List of all page actions builders for the current schema.
    /// </summary>
    IReadOnlyList<Func<EmPageRequest, EmAction>> ActionsBuilders { get; }

    /// <summary>
    /// List of permissions that user have to have in order to access the page behind that schema.
    /// </summary>
    IList<string> Permissions { get; }

    /// <summary>
    /// Target model type of the page.
    /// </summary>
    Type ModelType { get; }

    /// <summary>
    /// Initialization method that must be used for initialization of all page properties.
    /// </summary>
    /// <returns></returns>
    Task SetupAsync();

    /// <summary>
    /// Fetch data required for the page.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEmPageResult> FetchPageDataAsync(EmPageRequest request);

    /// <summary>
    /// Gets view context.
    /// </summary>
    /// <returns></returns>
    IEmPageViewContextStrategy GetViewContext();
}

/// <summary>
/// Contract for Emeraude page.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
/// <typeparam name="TViewContext">View context type.</typeparam>
/// <typeparam name="TPageResult">Result type.</typeparam>
public interface IEmPage<TModel, out TViewContext, TPageResult> : IEmPage
    where TModel : class, IEmPageModel, new()
    where TViewContext : class, IEmPageViewContextStrategy<TModel>, new()
    where TPageResult : class, IEmPageResult, new()
{
    /// <summary>
    /// The view context strategy that will be used for rendering the page.
    /// </summary>
    TViewContext ViewContext { get; }

    /// <summary>
    /// Computes title to use runtime value from the page model.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    string ComputeTitle(TModel model);

    /// <summary>
    /// Fetch data required for the page.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<TPageResult> FetchDataAsync(EmPageRequest request);
}