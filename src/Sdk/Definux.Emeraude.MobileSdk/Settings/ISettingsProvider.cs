using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.Settings
{
    /// <summary>
    /// Definition of settings provider for the Emeraude Mobile SDK.
    /// </summary>
    public interface ISettingsProvider
    {
        /// <summary>
        /// List of all languages loaded in the application.
        /// </summary>
        List<ApplicationLanguage> Languages { get; }

        /// <summary>
        /// Method that add language to the collection of all languages.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="nativeName"></param>
        /// <param name="isDefault"></param>
        void AddLanguage(string code, string name, string nativeName, bool isDefault = false);
    }
}
