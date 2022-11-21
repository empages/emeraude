namespace EmPages.Pages.Extensions;

/// <summary>
/// Extensions for <see cref="EmPageRequest"/>.
/// </summary>
public static class EmPageRequestExtensions
{
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