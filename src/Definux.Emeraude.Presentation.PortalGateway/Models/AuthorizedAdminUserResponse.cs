using System;

namespace Definux.Emeraude.Presentation.PortalGateway.Models
{
    /// <summary>
    /// Response of access administration verification.
    /// </summary>
    public class AuthorizedAdminUserResponse
    {
        /// <summary>
        /// Identifier of the admin user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Email address of the admin user.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// User name of the admin user.
        /// </summary>
        public string UserName { get; set; }
    }
}