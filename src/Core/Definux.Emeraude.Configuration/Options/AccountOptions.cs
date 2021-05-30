namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Options for authentication and authorization in the system.
    /// </summary>
    public class AccountOptions
    {
        /// <summary>
        /// Flag that indicates whether to be registered external authentication from the settings.
        /// </summary>
        public bool HasExternalAuthentication { get; set; }

        /// <summary>
        /// Flag that turn on/off the provided client MVC authentication. The default value is true.
        /// </summary>
        public bool HasClientMvcAuthentication { get; set; } = true;

        /// <summary>
        /// Flag that turn on/off the provided client API authentication. The defualt value is true.
        /// </summary>
        public bool HasClientApiAuthentication { get; set; } = true;
    }
}
