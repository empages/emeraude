using System;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Mapping;

namespace Definux.Emeraude.Admin.EmPages.User
{
    /// <summary>
    /// EmPage user model.
    /// </summary>
    public class UserEmPageModel : IEmPageModel, IMapFrom<Identity.Entities.User>
    {
        /// <summary>
        /// Identifier of the user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Registration date of the user.
        /// </summary>
        public DateTimeOffset RegistrationDate { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is activate his/her two factor authentication.
        /// </summary>
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is locked out.
        /// </summary>
        public bool IsLockedOut { get; set; }

        /// <summary>
        /// Flat that indicates whether the user has been confirmed his email address.
        /// </summary>
        public bool EmailConfirmed { get; set; }
    }
}