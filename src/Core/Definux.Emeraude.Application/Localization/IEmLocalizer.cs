using System.Threading.Tasks;
using Definux.Emeraude.Interfaces.Services;

namespace Definux.Emeraude.Application.Localization
{
    /// <summary>
    /// Service that provide translation functionality by using current language based on the route.
    /// </summary>
    public interface IEmLocalizer : ILocalizer
    {
        /// <summary>
        /// Translate key by using the specified language (async execution).
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        Task<string> TranslateKeyAsync(string key, string languageCode);

        /// <summary>
        /// Translate key by using the specified language.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        string TranslateKey(string key, string languageCode);

        /// <summary>
        /// Get static content by using the specified language (async execution).
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        Task<string> GetStaticContentAsync(string key, string languageCode);

        /// <summary>
        /// Get static content by using the specified language.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        string GetStaticContent(string key, string languageCode);
    }
}
