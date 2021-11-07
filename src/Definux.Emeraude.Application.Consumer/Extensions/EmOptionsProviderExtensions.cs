using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Application.Consumer.Extensions
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
        public static EmConsumerOptions GetClientOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmConsumerOptions>();
    }
}