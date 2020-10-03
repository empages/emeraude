namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Options for authentication and authorization in the system.
    /// </summary>
    public class AccountOptions
    {
        /// <summary>
        /// Flag that turn on/off the Facebook login.
        /// </summary>
        public bool HasFacebookLogin { get; set; }

        /// <summary>
        /// Flag that turn on/off the Google login.
        /// </summary>
        public bool HasGoogleLogin { get; set; }

        /// <summary>
        /// Flag that returns that there are at least one external OAuth login provider.
        /// </summary>
        public bool HasOAuthLogin
        {
            get
            {
                return this.HasFacebookLogin || this.HasGoogleLogin;
            }
        }

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
