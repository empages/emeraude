using System;

namespace Definux.Emeraude.MobileSdk.Events
{
    public class LanguageChangedEventArgs : EventArgs
    {
        public LanguageChangedEventArgs(string languageCode)
        {
            LanguageCode = languageCode;
        }

        public string LanguageCode { get; set; }
    }
}
