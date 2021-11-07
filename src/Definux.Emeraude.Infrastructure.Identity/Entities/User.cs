using System;
using System.IO;
using Definux.Emeraude.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Infrastructure.Identity.Entities
{
    /// <summary>
    /// Emeraude application user that implements ASP.NET Core <see cref="IdentityUser{TKey}"/>.
    /// </summary>
    public class User : IdentityUser<Guid>, IUser
    {
        /// <summary>
        /// Name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Registration date of the user.
        /// </summary>
        public DateTimeOffset RegistrationDate { get; set; }

        /// <summary>
        /// Property that indicates whether the user is locked out.
        /// </summary>
        public bool IsLockedOut => this.LockoutEnabled && this.LockoutEnd >= DateTimeOffset.UtcNow;

        /// <summary>
        /// User avatar url.
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// User avatar relative path.
        /// </summary>
        public string AvatarRelativePath
        {
            get
            {
                return this.AvatarUrl?.Replace('/', Path.DirectorySeparatorChar);
            }
        }

        /// <summary>
        /// Refresh token used for requesting new Json Web Token.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Refresh token expiration date.
        /// </summary>
        public DateTimeOffset? RefreshTokenExpiration { get; set; }
    }
}
