using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.UI.ViewModels.ExecutionResult
{
    /// <summary>
    /// View model for the execution result view.
    /// </summary>
    public class IndexViewModel
    {
        /// <summary>
        /// Title of the page.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Message on the page.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Status of the result.
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Execution reference.
        /// </summary>
        public string Reference { get; set; }
    }
}