namespace Definux.Emeraude.Configuration.Options
{
    public class AccountOptions
    {
        public bool HasFacebookLogin { get; set; }

        public bool HasGoogleLogin { get; set; }

        public bool HasOAuthLogin
        {
            get
            {
                return HasFacebookLogin || HasGoogleLogin;
            }
        }

        public bool HasClientMvcAuthentication { get; set; } = true;

        public bool HasClientApiAuthentication { get; set; } = true;
    }
}
