using Emeraude.Configuration.Options;

namespace Emeraude.Application.Admin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmOptionsProvider"/>.
    /// </summary>
    public static class EmOptionsProviderExtensions
    {
        /// <summary>
        /// Gets Emeraude admin options.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <returns></returns>
        public static EmAdminOptions GetAdminOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmAdminOptions>();
    }
}