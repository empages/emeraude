using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Localization
{
    public interface ILocalizer
    {
        Task<string> TranslateKeyAsync(string key);

        Task<string> TranslateKeyAsync(string key, string languageCode);

        string TranslateKey(string key);

        string TranslateKey(string key, string languageCode);
    }
}
