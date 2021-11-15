using System.Threading.Tasks;
using Emeraude.Infrastructure.Localization.Persistence.Entities;

namespace Emeraude.Infrastructure.Localization.Services
{
    /// <summary>
    /// Helper service accessor that provides the language extracted from the current request.
    /// </summary>
    public interface ICurrentLanguageProvider
    {
        /// <summary>
        /// Returns current request language.
        /// </summary>
        /// <returns></returns>
        Language GetCurrentLanguage();

        /// <summary>
        /// Returns current request language.
        /// </summary>
        /// <returns></returns>
        Task<Language> GetCurrentLanguageAsync();
    }
}
