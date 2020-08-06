using Definux.Emeraude.MobileSdk.Stores;
using System;
using System.Globalization;
using System.Resources;

namespace Definux.Emeraude.MobileSdk.Services
{
    public class Localizer : ILocalizer
    {
        private readonly ResourceManager resourceManager;
        private readonly ISystemSettingsStore systemSettingsStore;
        private CultureInfo cultureInfo;

        public string this[string key] => this.GetTranslation(key);

        public Localizer(ResourceManager resourceManager, ISystemSettingsStore systemSettingsStore)
        {
            this.resourceManager = resourceManager;
            this.systemSettingsStore = systemSettingsStore;
            this.systemSettingsStore.LanguageChanged += SystemSettingsStore_LanguageChanged;
        }

        private void SystemSettingsStore_LanguageChanged(object sender, Events.LanguageChangedEventArgs e)
        {
            this.cultureInfo = new CultureInfo(e.LanguageCode);
        }

        public string GetTranslation(string key)
        {
            try
            {
                string result = this.resourceManager.GetString(key, this.cultureInfo);
                if (string.IsNullOrEmpty(result))
                {
                    return key;
                }

                return result;
            }
            catch (Exception)
            {
                return key;
            }
        }
    }
}
