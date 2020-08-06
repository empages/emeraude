using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.Settings;
using Definux.Emeraude.MobileSdk.Stores;
using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Definux.Emeraude.MobileSdk.Stores
{
    public class SystemSettingsStore : ISystemSettingsStore
    {
        private readonly ISettingsProvider settingsProvider;

        private const string LanguageSettingsKey = "system.language";

        public SystemSettingsStore(ISettingsProvider settingsProvider)
        {
            this.settingsProvider = settingsProvider;
            Languages = this.settingsProvider.Languages;
        }

        public IEnumerable<ApplicationLanguage> Languages { get; private set; }

        public ApplicationLanguage SelectedLanguage { get; private set; }

        public void SelectLanguage(ApplicationLanguage language)
        {
            if (SelectedLanguage != language)
            {
                SelectedLanguage = language;
                CrossSettings.Current.AddOrUpdateValue(LanguageSettingsKey, language.Code);
                LanguageChanged?.Invoke(this, new LanguageChangedEventArgs(language.Code));
            }
        }

        public void ApplyCurrentLanguage()
        {
            string languageFromSettings = Languages.Where(x => x.IsDefault).Select(x => x.Code).FirstOrDefault();
            if (CrossSettings.Current.Contains(LanguageSettingsKey))
            {
                languageFromSettings = CrossSettings.Current.GetValueOrDefault(LanguageSettingsKey, languageFromSettings);
            }

            SelectLanguage(Languages.FirstOrDefault(x => x.Code == languageFromSettings));
        }

        public event EventHandler<LanguageChangedEventArgs> LanguageChanged;
    }
}
