using System;

namespace Emeraude.Contracts
{
    /// <summary>
    /// Interface that represent user of the application.
    /// </summary>
    public interface IUser : IEntity
    {
        /// <summary>
        /// Name of the user.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Phone number of the user.
        /// </summary>
        string PhoneNumber { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Avatar URL of the user.
        /// </summary>
        string AvatarUrl { get; set; }

        /// <summary>
        /// Registration date of the user.
        /// </summary>
        DateTimeOffset RegistrationDate { get; set; }
    }
}
