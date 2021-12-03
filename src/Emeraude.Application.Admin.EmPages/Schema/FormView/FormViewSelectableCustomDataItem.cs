namespace Emeraude.Application.Admin.EmPages.Schema.FormView
{
    /// <summary>
    /// Implementation class for custom data mapped to specified item id in order to be selected.
    /// </summary>
    public class FormViewSelectableCustomDataItem
    {
        /// <summary>
        /// Identifier of the data.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Value of the custom data.
        /// </summary>
        public object Data { get; set; }
    }
}