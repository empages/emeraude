using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;

namespace Definux.Emeraude.Identity.Entities
{
    public class Role : IdentityRole<Guid>, IEntity
    {
        public Role()
        {
        }

        public Role(string roleName) : base(roleName)
        {
        }

        public Role(string roleName, string description) : base(roleName)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
