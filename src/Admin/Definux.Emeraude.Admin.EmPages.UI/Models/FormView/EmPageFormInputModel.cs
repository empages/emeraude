using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.FormView
{
    /// <summary>
    /// Implementation of form input that contains the data of the input.
    /// </summary>
    public class EmPageFormInputModel : EmPageViewItemContextModel
    {
        /// <summary>
        /// Label of the input.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Indicates whether the input is required or not.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Indicates whether the input will be readonly or not.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// List of all errors from the validation process.
        /// </summary>
        public IEnumerable<string> ValidationErrors { get; set; }
    }
}