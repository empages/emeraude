using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Emails.Options;

namespace Definux.Emeraude.Emails.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmOptionsProvider"/>.
    /// </summary>
    public static class EmOptionsProviderExtensions
    {
        /// <summary>
        /// Gets Emeraude email options.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <returns></returns>
        public static EmEmailOptions GetEmailOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmEmailOptions>();
    }
}