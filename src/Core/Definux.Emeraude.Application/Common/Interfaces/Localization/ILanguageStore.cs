using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Localization;

namespace Definux.Emeraude.Application.Common.Interfaces.Localization
{
    /// <summary>
    /// Storage for all localization data - languages, translations.
    /// </summary>
    public interface ILanguageStore
    {
        /// <summary>
        /// Get all available language codes (async execution).
        /// </summary>
        /// <returns></returns>
        Task<string[]> GetAllLanguageCodesAsync();

        /// <summary>
        /// Get all available language codes.
        /// </summary>
        /// <returns></returns>
        string[] GetAllLanguageCodes();

        /// <summary>
        /// Get default language from the available ones.
        /// </summary>
        /// <returns></returns>
        Language GetDefaultLanguage();

        /// <summary>
        /// Get default language (async execution) from the available ones.
        /// </summary>
        /// <returns></returns>
        Task<Language> GetDefaultLanguageAsync();

        /// <summary>
        /// Get all available languages.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Language> GetLanguages();

        /// <summary>
        /// Get all available languages (async execution).
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Language>> GetLanguagesAsync();

        /// <summary>
        /// Get all translations for specific language in dictionary.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        Dictionary<string, string> GetLanguageTranslationDictionary(int languageId);

        /// <summary>
        /// Get all translation keys.
        /// </summary>
        /// <returns></returns>
        List<string> GetTranslationsKeys();
    }
}
