using System.Net.Http;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Defines entity model action.
    /// </summary>
    public class EntityModelAction
    {
        /// <summary>
        /// Order of the action.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Name of the action.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Relative to main entity URL of the action. Must not start with '/'.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Represents a flag that indicates whether the action be executed separately or not.
        /// </summary>
        public bool ExecuteSeparately { get; set; }

        /// <summary>
        /// Execution method.
        /// </summary>
        public HttpMethod Method { get; set; } = HttpMethod.Get;

        /// <summary>
        /// Indicates whether the action requires confirmation.
        /// </summary>
        public bool HasConfirmation => string.IsNullOrWhiteSpace(this.ConfirmationMessage);

        /// <summary>
        /// Message for action confirmation.
        /// </summary>
        public string ConfirmationMessage { get; set; }
    }
}