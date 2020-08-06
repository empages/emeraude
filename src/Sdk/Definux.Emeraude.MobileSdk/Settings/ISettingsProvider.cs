using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.Settings
{
    public interface ISettingsProvider
    {
        List<ApplicationLanguage> Languages { get; }
    }
}
