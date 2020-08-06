using Definux.Emeraude.Domain.Localization;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Localization
{
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
