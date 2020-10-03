using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Localization
{
    /// <summary>
    /// Service that provide translation functionality by using current language based on the route.
    /// </summary>
    public interface ILocalizer
    {
        /// <summary>
        /// Translate key by using the current language (async execution).
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<string> TranslateKeyAsync(string key);

        /// <summary>
        /// Translate key by using the specified language (async execution).
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        Task<string> TranslateKeyAsync(string key, string languageCode);

        /// <summary>
        /// Translate key by using the current language.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string TranslateKey(string key);

        /// <summary>
        /// Translate key by using the specified language.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        string TranslateKey(string key, string languageCode);
    }
}
