using System;
using Microsoft.Extensions.DependencyInjection;

namespace EmPages.Pages.Extensions;

/// <summary>
/// Extensions for service provider.
/// </summary>
public static class ServiceProviderExtensions
{
    /// <summary>
    /// Gets an EmPage.
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <param name="pageType"></param>
    /// <returns></returns>
    public static IEmPage GetPage(this IServiceProvider serviceProvider, Type pageType) =>
        (IEmPage)serviceProvider.GetRequiredService(pageType);

    /// <summary>
    /// Gets an EmPage command.
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <param name="commandType"></param>
    /// <returns></returns>
    public static IEmPageCommand GetPageCommand(this IServiceProvider serviceProvider, Type commandType) =>
        (IEmPageCommand)serviceProvider.GetRequiredService(commandType);
}