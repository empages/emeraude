using Definux.Emeraude.Interfaces.Results;

namespace Definux.Emeraude.Application.Identity
{
    /// <summary>
    /// Bearer authentication result for API authentication request.
    /// </summary>
    public class BearerAuthenticationResult : IBearerAuthenticationResult
    {
        /// <summary>
        /// Static property that returns failed bearer result.
        /// </summary>
        public static BearerAuthenticationResult FailedResult => new BearerAuthenticationResult
        {
            Success = false,
            Message = "Authentication failed.",
        };

        /// <inheritdoc/>
        public bool Success { get; set; }

        /// <inheritdoc/>
        public string Message { get; set; }

        /// <inheritdoc/>
        public string JsonWebToken { get; set; }

        /// <inheritdoc/>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Static method that returns success bearer result.
        /// </summary>
        /// <param name="jsonWebToken"></param>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public static BearerAuthenticationResult SuccessResult(string jsonWebToken, string refreshToken)
        {
            return new BearerAuthenticationResult
            {
                Success = true,
                Message = "Successful authentication.",
                JsonWebToken = jsonWebToken,
                RefreshToken = refreshToken,
            };
        }
    }
}
