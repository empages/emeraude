namespace Definux.Emeraude.Configuration.Authorization
{
    /// <summary>
    /// List of all predefined application roles.
    /// </summary>
    public static class ApplicationRoles
    {
        /// <summary>
        /// Role 'Admin' represent user with absolute all rights in the system.
        /// </summary>
        public const string Admin = "Admin";

        /// <summary>
        /// Role 'User' represent user with access onli in client part of the system.
        /// </summary>
        public const string User = "User";
    }
}