namespace Definux.Emeraude.MobileSdk.FormModels.Abstractions
{
    /// <summary>
    /// Error definition class for form model.
    /// </summary>
    public class FormModelError
    {
        /// <summary>
        /// Key of the error - the name of the property or the error is general - use empty string.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Error text.
        /// </summary>
        public string Error { get; set; }
    }
}
