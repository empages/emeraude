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
        }

        /// <summary>
        /// Inputs of form view.
        /// </summary>
        public List<EmPageFormInputModel> Inputs { get; set; }
    }
}