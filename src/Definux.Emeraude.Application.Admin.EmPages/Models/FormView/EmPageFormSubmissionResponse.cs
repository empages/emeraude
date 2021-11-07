using System.Collections.Generic;

namespace Definux.Emeraude.Application.Admin.EmPages.Models.FormView
{
    /// <summary>
    /// Response of form view data submission.
    /// </summary>
    public class EmPageFormSubmissionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFormSubmissionResponse"/> class.
        /// </summary>
        public EmPageFormSubmissionResponse()
        {
            this.ValidationErrors = new Dictionary<string, string[]>();
        }

        /// <summary>
        /// Id of the mutated model.
        /// </summary>
        public string MutatedModelId { get; set; }

        /// <summary>
        /// Dictionary with all errors thrown during the operation execution.
        /// </summary>
        public IDictionary<string, string[]> ValidationErrors { get; }

        /// <summary>
        /// Error occured during operation that is not related to the model itself.
        /// </summary>
        public string OperationError { get; set; }
    }
}