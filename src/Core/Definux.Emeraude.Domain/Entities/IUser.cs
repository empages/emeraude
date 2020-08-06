using System;

namespace Definux.Emeraude.Domain.Entities
{
    public interface IUser : IEntity
    {
        string Name { get; set; }

        string PhoneNumber { get; set; }

        string Email { get; set; }

        string AvatarUrl { get; set; }

        DateTime RegistrationDate { get; set; }
    }
}
