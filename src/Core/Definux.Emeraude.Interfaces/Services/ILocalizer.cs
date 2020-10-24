using System.Threading.Tasks;

namespace Definux.Emeraude.Interfaces.Services
{
    /// <summary>
    /// Definition of translation service.
    /// </summary>
    public interface ILocalizer
    {
        /// <summary>
        /// Get a translation by using the current language.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string this[string key] { get; }

        /// <summary>
        /// Translate key by using the current language.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string TranslateKey(string key);

        /// <summary>
        /// Translate key by using the current language (async execution).
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<string> TranslateKeyAsync(string key);

        /// <summary>
        /// Get static content by using the current language (async execution).
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<string> GetStaticContentAsync(string key);

        /// <summary>
        /// Get static content by using the current language.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetStaticContent(string key);
    }
}
