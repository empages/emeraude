using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.Persistence.Options;

namespace Emeraude.Infrastructure.Persistence.Extensions;

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
    public static EmPersistenceOptions GetPersistenceOptions(this IEmOptionsProvider optionsProvider)
        => optionsProvider.GetOptions<EmPersistenceOptions>();
}