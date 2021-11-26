using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Models.FormView
{
    /// <summary>
    /// Implementation of form input that contains the data of the input.
    /// </summary>
    public class EmPageFormInputModel : EmPageViewItemContextModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFormInputModel"/> class.
        /// </summary>
        public EmPageFormInputModel()
        {
            this.ValidationErrors = new List<string>();
        }

        /// <summary>
        /// Label of the input.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Indicates whether the input is required or not.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Indicates whether the input could contains null or not.
        /// </summary>
        public bool AllowNullValue { get; set; }

        /// <summary>
        /// Indicates whether the input will be readonly or not.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// List of all errors from the validation process.
        /// </summary>
        public List<string> ValidationErrors { get; set; }
    }
}