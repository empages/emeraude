using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.Settings;
using Plugin.Settings;

namespace Definux.Emeraude.MobileSdk.Stores
{
    /// <inheritdoc cref="SystemSettingsStore"/>
    public class SystemSettingsStore : ISystemSettingsStore
    {
        private const string LanguageSettingsKey = "system.language";

        private readonly ISettingsProvider settingsProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemSettingsStore"/> class.
        /// </summary>
        /// <param name="settingsProvider"></param>
        public SystemSettingsStore(ISettingsProvider settingsProvider)
        {
            this.settingsProvider = settingsProvider;
            this.Languages = this.settingsProvider.Languages;
        }

        /// <inheritdoc/>
        public event EventHandler<LanguageChangedEventArgs> LanguageChanged;

        /// <inheritdoc/>
        public IEnumerable<ApplicationLanguage> Languages { get; private set; }

        /// <inheritdoc/>
        public ApplicationLanguage SelectedLanguage { get; private set; }

        /// <inheritdoc/>
        public void SelectLanguage(ApplicationLanguage language)
        {
            if (this.SelectedLanguage != language)
            {
                this.SelectedLanguage = language;
                CrossSettings.Current.AddOrUpdateValue(LanguageSettingsKey, language.Code);
                this.LanguageChanged?.Invoke(this, new LanguageChangedEventArgs(language.Code));
            }
        }

        /// <inheritdoc/>
        public void ApplyCurrentLanguage()
        {
            string languageFromSettings = this.Languages.Where(x => x.IsDefault).Select(x => x.Code).FirstOrDefault();
            if (CrossSettings.Current.Contains(LanguageSettingsKey))
            {
                languageFromSettings = CrossSettings.Current.GetValueOrDefault(LanguageSettingsKey, languageFromSettings);
            }

            this.SelectLanguage(this.Languages.FirstOrDefault(x => x.Code == languageFromSettings));
        }
    }
}
