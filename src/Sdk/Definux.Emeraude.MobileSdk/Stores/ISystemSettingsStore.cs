using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.Settings;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.Stores
{
    public interface ISystemSettingsStore
    {
        IEnumerable<ApplicationLanguage> Languages { get; }

        ApplicationLanguage SelectedLanguage { get; }

        void SelectLanguage(ApplicationLanguage language);

        void ApplyCurrentLanguage();

        event EventHandler<LanguageChangedEventArgs> LanguageChanged;
    }
}
