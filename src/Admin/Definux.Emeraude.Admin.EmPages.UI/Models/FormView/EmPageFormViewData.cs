using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.FormView
{
    /// <summary>
    /// Data implementation for form view.
    /// </summary>
    public class EmPageFormViewData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFormViewData"/> class.
        /// </summary>
        public EmPageFormViewData()
        {
            this.Inputs = new List<EmPageFormInputModel>();
            this.NonMappedFormErrors = new List<string>();
        }

        /// <summary>
        /// Inputs of form view.
        /// </summary>
        public List<EmPageFormInputModel> Inputs { get; set; }

        /// <summary>
        /// List of all form errors that are not related to the input models.
        /// </summary>
        public List<string> NonMappedFormErrors { get; set; }

        /// <summary>
        /// Clears all errors related to this form view data.
        /// </summary>
        public void ClearErrors()
        {
            this.NonMappedFormErrors.Clear();
            foreach (var input in this.Inputs)
            {
                input.ValidationErrors.Clear();
            }
        }
    }
}