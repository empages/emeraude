using Emeraude.Configuration.Options;
using Emeraude.Presentation.PortalGateway.Options;

namespace Emeraude.Presentation.PortalGateway.Extensions;

/// <summary>
/// Extensions for <see cref="IEmOptionsProvider"/>.
/// </summary>
public static class EmOptionsProviderExtensions
{
    /// <summary>
    /// Gets Emeraude portal gateway options.
    /// </summary>
    /// <param name="optionsProvider"></param>
    /// <returns></returns>
    public static EmPortalGatewayOptions GetPortalGatewayOptions(this IEmOptionsProvider optionsProvider)
        => optionsProvider.GetOptions<EmPortalGatewayOptions>();
}