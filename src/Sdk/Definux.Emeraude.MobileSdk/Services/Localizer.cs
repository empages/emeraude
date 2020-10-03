using System;
using System.Globalization;
using System.Resources;
using Definux.Emeraude.MobileSdk.Stores;

namespace Definux.Emeraude.MobileSdk.Services
{
    /// <inheritdoc cref="ILocalizer"/>
    public class Localizer : ILocalizer
    {
        private readonly ResourceManager resourceManager;
        private readonly ISystemSettingsStore systemSettingsStore;
        private CultureInfo cultureInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Localizer"/> class.
        /// </summary>
        /// <param name="resourceManager"></param>
        /// <param name="systemSettingsStore"></param>
        public Localizer(ResourceManager resourceManager, ISystemSettingsStore systemSettingsStore)
        {
            this.resourceManager = resourceManager;
            this.systemSettingsStore = systemSettingsStore;
            this.systemSettingsStore.LanguageChanged += this.SystemSettingsStoreLanguageChanged;
        }

        /// <inheritdoc/>
        public string this[string key] => this.GetTranslation(key);

        /// <inheritdoc/>
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

        private void SystemSettingsStoreLanguageChanged(object sender, Events.LanguageChangedEventArgs e)
        {
            this.cultureInfo = new CultureInfo(e.LanguageCode);
        }
    }
}
