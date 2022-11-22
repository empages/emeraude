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
            EmPageConstants.PaginationPageQueryKey,
            EmPageConstants.PaginationPageDefaultIndex);

    /// <summary>
    /// Gets current request pagination page size.
    /// Default value is equal to <see cref="EmPageConstants.PaginationPageDefaultSize"/>.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static int GetPaginationPageSize(this EmPageRequest request) =>
        request.GetParameter<int>(
            EmPageConstants.PaginationPageSizeQueryKey,
            EmPageConstants.PaginationPageDefaultSize);
}