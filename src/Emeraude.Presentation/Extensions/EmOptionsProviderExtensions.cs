using Emeraude.Configuration.Options;

namespace Emeraude.Presentation.Extensions;

/// <summary>
/// Extensions for <see cref="IEmOptionsProvider"/>.
/// </summary>
public static class EmOptionsProviderExtensions
{
    /// <summary>
    /// Gets Emeraude persistence options.
    /// </summary>
    /// <param name="optionsProvider"></param>
    /// <returns></returns>
    public static EmPresentationOptions GetPresentationOptions(this IEmOptionsProvider optionsProvider)
        => optionsProvider.GetOptions<EmPresentationOptions>();
}