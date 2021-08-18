namespace Definux.Emeraude.Presentation.Options
{
    /// <summary>
    /// Implementation of Google Visible ReCaptcha keys options.
    /// </summary>
    public class GoogleRecaptchaKeysOptions
    {
        /// <summary>
        /// Site key.
        /// </summary>
        public string SiteKey { get; set; }

        /// <summary>
        /// Secret key.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Verify the ReCaptcha in development environment.
        /// </summary>
        public bool VerifyInDevelopment { get; set; }
    }
}