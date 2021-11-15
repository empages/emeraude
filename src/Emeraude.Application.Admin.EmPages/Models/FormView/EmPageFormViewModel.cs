using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Models.FormView
{
    /// <summary>
    /// Model implementation for form view.
    /// </summary>
    public class EmPageFormViewModel : EmPageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFormViewModel"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EmPageFormViewModel(EmPageViewContext context)
            : base(context)
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