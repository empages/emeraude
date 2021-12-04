using System.Threading.Tasks;

namespace Emeraude.Infrastructure.Localization.Services;

/// <summary>
/// Service that provide translation functionality by using current or pre-specified language based on the route.
/// </summary>
public interface IEmLocalizer
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
    /// Translate key by using the specified language.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="languageCode"></param>
    /// <returns></returns>
    string TranslateKey(string key, string languageCode);

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