using Newtonsoft.Json;

namespace Definux.Emeraude.MobileSdk.OAuth
{
    public class OAuth2TokenResult
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        #region Facebook

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("reauthorize_required_in")]
        public string ReauthorizeRequiredIn { get; set; }

        [JsonProperty("data_access_expiration_time")]
        public string DataAccessExpirationTime { get; set; }

        #endregion

        #region Google

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("id_token")]
        public string IdToken { get; set; }

        #endregion
    }
}
