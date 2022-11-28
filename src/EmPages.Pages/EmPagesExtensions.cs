using System.Collections.Generic;
using System.Linq;

namespace EmPages.Pages;

/// <summary>
/// Extensions for <see cref="IEmPageModel"/>.
/// </summary>
public static class EmPagesExtensions
{
    /// <summary>
    /// Gets EmPage Model property value.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="property"></param>
    /// <returns></returns>
    public static object GetPropertyValue(this IEmPageModel model, string property) =>
        model.GetType().GetProperty(property)?.GetValue(model) ?? default;

    /// <summary>
    /// Gets current request pagination page index.
    /// Default value is equal to <see cref="EmPageConstants.PaginationPageDefaultIndex"/>.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static int GetPaginationPageIndex(this EmPageRequest request) =>
        request.GetParameter<int>(
            EmPageConstants.PaginationPageParameterKey,
            EmPageConstants.PaginationPageDefaultIndex);

    /// <summary>
    /// Gets current request pagination page size.
    /// Default value is equal to <see cref="EmPageConstants.PaginationPageDefaultSize"/>.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static int GetPaginationPageSize(this EmPageRequest request) =>
        request.GetParameter<int>(
            EmPageConstants.PaginationPageSizeParameterKey,
            EmPageConstants.PaginationPageDefaultSize);

    /// <summary>
    /// Converts current request to a page request.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="descriptor"></param>
    /// <returns></returns>
    public static EmPageRequest ToPageRequest(this EmRequest request, EmPageDescriptor descriptor)
    {
        var routeSegments = new EmPageRoute(request.Route).Segments;
        var rawRouteSegments = descriptor.PageRoute.Segments;
        var segmentCount = routeSegments.Count();
        var parameters = request.Parameters.ToDictionary(x => x.Key, x => x.Value);
        for (int i = 0; i < segmentCount; i++)
        {
            if (rawRouteSegments.ElementAt(i).Dynamic)
            {
                parameters[rawRouteSegments.ElementAt(i).Value] = routeSegments.ElementAt(i).Value;
            }
        }

        return new EmPageRequest(parameters);
    }

    /// <summary>
    /// Get current request page model.
    /// </summary>
    /// <param name="request"></param>
    /// <typeparam name="TModel">Model type.</typeparam>
    /// <returns></returns>
    public static TModel GetModel<TModel>(this EmPageRequest request)
        where TModel : class, IEmPageModel, new() =>
        request.GetParameter<TModel>(EmPageConstants.RequestModelParameterKey);

    /// <summary>
    /// Get current request page models.
    /// </summary>
    /// <param name="request"></param>
    /// <typeparam name="TModel">Model type.</typeparam>
    /// <returns></returns>
    public static IEnumerable<TModel> GetModels<TModel>(this EmPageRequest request)
        where TModel : class, IEmPageModel, new() =>
        request.GetParameter<IEnumerable<TModel>>(EmPageConstants.RequestModelsParameterKey);
}