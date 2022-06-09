using System.Collections.Generic;

namespace EmPages.Pages;

/// <summary>
/// Implementation of command request.
/// </summary>
public class EmPageCommandRequest : EmPageRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageCommandRequest"/> class.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="modelsIds"></param>
    /// <param name="routeParameters"></param>
    /// <param name="queryParameters"></param>
    public EmPageCommandRequest(
        IEmPageModel model,
        IEnumerable<string> modelsIds,
        IDictionary<string, object> routeParameters,
        IDictionary<string, object> queryParameters)
        : base(routeParameters, queryParameters)
    {
        this.Model = model;
        this.ModelsIds = modelsIds;
    }

    /// <summary>
    /// Request model. Applicable for pages with single rendered model.
    /// </summary>
    public IEmPageModel Model { get; }

    /// <summary>
    /// Collection of all models passed via tha command request.
    /// Applicable for pages with multiple rendered models.
    /// </summary>
    public IEnumerable<string> ModelsIds { get; }

    /// <summary>
    /// Gets casted model based on page definition.
    /// </summary>
    /// <typeparam name="TModel">Model type.</typeparam>
    /// <returns></returns>
    public TModel GetModel<TModel>()
        where TModel : class, IEmPageModel, new() => this.Model as TModel;
}