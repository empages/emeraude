using System;
using System.Collections.Generic;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.Settings;

namespace Definux.Emeraude.MobileSdk.Stores
{
    /// <summary>
    /// Store used for managing the built-in settings of the application.
    /// </summary>
    public interface ISystemSettingsStore
    {
        /// <summary>
        /// Event which is triggered when the selected language is changed.
        /// </summary>
        event EventHandler<LanguageChangedEventArgs> LanguageChanged;

        /// <summary>
        /// List of all registered languages.
        /// </summary>
        IEnumerable<ApplicationLanguage> Languages { get; }

        /// <summary>
        /// Currently selected language of the application.
        /// </summary>
        ApplicationLanguage SelectedLanguage { get; }

        /// <summary>
        /// Set the specified language as selected one.
        /// </summary>
        /// <param name="language"></param>
        void SelectLanguage(ApplicationLanguage language);

        /// <summary>
        /// Load previously selected language from the settubgs.
        /// </summary>
        void ApplyCurrentLanguage();
    }
}
