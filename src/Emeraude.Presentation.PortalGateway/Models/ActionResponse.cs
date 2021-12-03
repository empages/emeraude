using Emeraude.Essentials.Models;

namespace Emeraude.Presentation.PortalGateway.Models
{
    /// <summary>
    /// Response model for execution of action in the admin.
    /// </summary>
    public class ActionResponse : SimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionResponse"/> class.
        /// </summary>
        /// <param name="succeeded"></param>
        public ActionResponse(bool succeeded)
            : base(succeeded)
        {
        }

        /// <summary>
        /// Message from the execution.
        /// </summary>
        public string Message { get; set; }
    }
}