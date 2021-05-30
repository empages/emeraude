using System;

namespace Definux.Emeraude.MobileSdk.Events
{
    /// <summary>
    /// Event args implementation for language change event.
    /// </summary>
    public class LanguageChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageChangedEventArgs"/> class.
        /// </summary>
        /// <param name="languageCode"></param>
        public LanguageChangedEventArgs(string languageCode)
        {
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Short code of the langauge.
        /// </summary>
        public string LanguageCode { get; set; }
    }
}
