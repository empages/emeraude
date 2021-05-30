using Newtonsoft.Json;

namespace Definux.Emeraude.MobileSdk.OAuth
{
    /// <summary>
    /// OAuth2 result of the access token external authentication request.
    /// </summary>
    public class OAuth2TokenResult
    {
        /// <summary>
        /// Access token.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        // Facebook

        /// <summary>
        /// State of the OAuth2 request. Applicable for Facebook authorization.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Reauthorization time. Applicable for Facebook authorization.
        /// </summary>
        [JsonProperty("reauthorize_required_in")]
        public string ReauthorizeRequiredIn { get; set; }

        /// <summary>
        /// Data access expiration time. Applicable for Facebook authorization.
        /// </summary>
        [JsonProperty("data_access_expiration_time")]
        public string DataAccessExpirationTime { get; set; }

        // Google

        /// <summary>
        /// Refresh token. Applicable for Google authorization.
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Scope of the request. Applicable for Google authorization.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Type of the token. Applicable for Google authorization.
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Identification of the token. Applicable for Google authorization.
        /// </summary>
        [JsonProperty("id_token")]
        public string IdToken { get; set; }
    }
}
