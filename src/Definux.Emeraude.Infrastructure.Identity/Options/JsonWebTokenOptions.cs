namespace Definux.Emeraude.Infrastructure.Identity.Options
{
    /// <summary>
    /// Implementation of JSON web token options.
    /// </summary>
    public class JsonWebTokenOptions
    {
        /// <summary>
        /// Secret key of the token.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Issuer of the token.
        /// </summary>
        public string Issuer { get; set; }
    }
}