using System.Collections.Generic;
using System.Globalization;

namespace Definux.Emeraude.MobileSdk.Settings
{
    public class EmeraudeMobileSettings : ISettingsProvider
    {
        public EmeraudeMobileSettings()
        {
            Languages = new List<ApplicationLanguage>();
        }

        public List<ApplicationLanguage> Languages { get; }

        public void AddLanguage(string code, string name, string nativeName, bool isDefault = false)
        {
            Languages.Add(new ApplicationLanguage
            {
                Code = code,
                Name = name,
                NativeName = nativeName,
                IsDefault = isDefault
            });
        }
    }
}
