using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.Identity.Options;

namespace Emeraude.Infrastructure.Identity.Extensions;

/// <summary>
/// Extensions for <see cref="IEmOptionsProvider"/>.
/// </summary>
public static class EmOptionsProviderExtensions
{
    /// <summary>
    /// Gets Emeraude identity options.
    /// </summary>
    /// <param name="optionsProvider"></param>
    /// <returns></returns>
    public static EmIdentityOptions GetIdentityOptions(this IEmOptionsProvider optionsProvider)
        => optionsProvider.GetOptions<EmIdentityOptions>();
}