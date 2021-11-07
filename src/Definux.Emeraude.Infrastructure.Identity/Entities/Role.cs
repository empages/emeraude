using System;
using Definux.Emeraude.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Infrastructure.Identity.Entities
{
    /// <summary>
    /// Role entity used from the application that implements ASP.NET Core <see cref="IdentityRole{TKey}"/>.
    /// </summary>
    public class Role : IdentityRole<Guid>, IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="roleName"></param>
        public Role(string roleName)
            : base(roleName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="description"></param>
        public Role(string roleName, string description)
            : base(roleName)
        {
            this.Description = description;
        }

        /// <summary>
        /// Description of the role.
        /// </summary>
        public string Description { get; set; }
    }
}
