using Emeraude.Application.ClientBuilder.Options;
using Emeraude.Configuration.Options;

namespace Emeraude.Application.ClientBuilder.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmOptionsProvider"/>.
    /// </summary>
    public static class EmOptionsProviderExtensions
    {
        /// <summary>
        /// Gets Emeraude client builder options.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <returns></returns>
        public static EmClientBuilderOptions GetClientBuilderOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmClientBuilderOptions>();
    }
}