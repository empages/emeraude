using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.Settings
{
    /// <summary>
    /// Implementation of <see cref="ISettingsProvider"/>.
    /// </summary>
    public class EmeraudeMobileSettings : ISettingsProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmeraudeMobileSettings"/> class.
        /// </summary>
        public EmeraudeMobileSettings()
        {
            this.Languages = new List<ApplicationLanguage>();
        }

        /// <inheritdoc/>
        public List<ApplicationLanguage> Languages { get; }

        /// <inheritdoc/>
        public void AddLanguage(string code, string name, string nativeName, bool isDefault = false)
        {
            this.Languages.Add(new ApplicationLanguage
            {
                Code = code,
                Name = name,
                NativeName = nativeName,
                IsDefault = isDefault,
            });
        }
    }
}
