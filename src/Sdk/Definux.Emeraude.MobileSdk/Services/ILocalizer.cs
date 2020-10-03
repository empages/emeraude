namespace Definux.Emeraude.MobileSdk.Services
{
    /// <summary>
    /// Emeraude service that provides interface for access translations.
    /// </summary>
    public interface ILocalizer
    {
        /// <summary>
        /// Get translation by its key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetTranslation(string key);

        /// <summary>
        /// Get a translation by its key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
#pragma warning disable SA1201 // Elements should appear in the correct order
        string this[string key] { get; }
#pragma warning restore SA1201 // Elements should appear in the correct order
    }
}
