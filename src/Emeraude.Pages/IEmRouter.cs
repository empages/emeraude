namespace Emeraude.Pages;

/// <summary>
/// Router service that handles routes storing and matching.
/// </summary>
public interface IEmRouter
{
    /// <summary>
    /// Finds a page descriptor for requested route, otherwise null.
    /// </summary>
    /// <param name="route"></param>
    /// <returns></returns>
    EmPageDescriptor RouteToPage(string route);
}