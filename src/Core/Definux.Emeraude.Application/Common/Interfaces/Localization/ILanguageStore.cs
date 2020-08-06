using Definux.Emeraude.Domain.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Localization
{
    public interface ILanguageStore
    {
        Task<string[]> GetAllLanguageCodesAsync();

        string[] GetAllLanguageCodes();

        Language GetDefaultLanguage();

        Task<Language> GetDefaultLanguageAsync();

        IEnumerable<Language> GetLanguages();

        Task<IEnumerable<Language>> GetLanguagesAsync();

        Dictionary<string, string> GetLanguageTranslationDictionary(int languageId);

        List<string> GetTranslationsKeys();
    }
}
