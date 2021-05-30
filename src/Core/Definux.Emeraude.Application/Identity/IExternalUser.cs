namespace Definux.Emeraude.Application.Identity
{
    /// <summary>
    /// Interface of external user definition.
    /// </summary>
    public interface IExternalUser
    {
        /// <summary>
        /// Identifier of the user.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// First name of the user.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        string EmailAddress { get; set; }

        /// <summary>
        /// External provider name.
        /// </summary>
        string Provider { get; set; }

        /// <summary>
        /// Picture of the user.
        /// </summary>
        string PictureUrl { get; }
    }
}
