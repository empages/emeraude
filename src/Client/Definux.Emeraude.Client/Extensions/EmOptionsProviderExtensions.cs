using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Client.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmOptionsProvider"/>.
    /// </summary>
    public static class EmOptionsProviderExtensions
    {
        /// <summary>
        /// Gets Emeraude client options.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <returns></returns>
        public static EmClientOptions GetClientOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmClientOptions>();
    }
}