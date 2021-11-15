using Emeraude.Configuration.Options;

namespace Emeraude.Infrastructure.FileStorage.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmOptionsProvider"/>.
    /// </summary>
    public static class EmOptionsProviderExtensions
    {
        /// <summary>
        /// Gets Emeraude files options.
        /// </summary>
        /// <param name="optionsProvider"></param>
        /// <returns></returns>
        public static EmFilesOptions GetFilesOptions(this IEmOptionsProvider optionsProvider)
            => optionsProvider.GetOptions<EmFilesOptions>();
    }
}