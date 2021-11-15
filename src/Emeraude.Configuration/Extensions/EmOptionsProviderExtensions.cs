using Emeraude.Configuration.Options;

namespace Emeraude.Configuration.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmOptionsProvider"/>.
    /// </summary>
    public static class EmOptionsProviderExtensions
    {
        /// <summary>
        /// Gets Emeraude main options.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <returns></returns>
        public static EmMainOptions GetMainOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmMainOptions>();
    }
}