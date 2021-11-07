namespace Definux.Emeraude.Infrastructure.Localization.Services
{
    /// <summary>
    /// Application resource builder for all languages.
    /// </summary>
    public interface ILanguagesResourceManager
    {
        /// <summary>
        /// Build all language resources.
        /// </summary>
        void BuildResources();

        /// <summary>
        /// Gets translation resource for specified language code and translation key.
        /// </summary>
        /// <param name="translationKey"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        string GetTranslationResource(string translationKey, string languageCode);
    }
}