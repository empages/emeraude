namespace Definux.Emeraude.MobileSdk.Settings
{
    /// <summary>
    /// Mobile implementation of language domain entity.
    /// </summary>
    public class ApplicationLanguage
    {
        /// <summary>
        /// Short code of the language.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Name of the language.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Native name of the language.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Flag that indicates whether the language is default for the system.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Code;
        }
    }
}
