using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.IO;

namespace Definux.Emeraude.Identity.Entities
{
    public class User : IdentityUser<Guid>, IUser
    {
        public override Guid Id { get => base.Id; set => base.Id = value; }

        public string Name { get; set; }

        public override string Email { get => base.Email; set => base.Email = value; }

        public DateTime RegistrationDate { get; set; }

        public bool IsLockedOut => this.LockoutEnabled && this.LockoutEnd >= DateTimeOffset.UtcNow;

        public string AvatarUrl { get; set; }

        public string AvatarRelativePath
        {
            get
            {
                return AvatarUrl?.Replace('/', Path.DirectorySeparatorChar);
            }
        }

        public string RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiration { get; set; }
    }
}
