using Definux.Emeraude.Interfaces.Results;

namespace Definux.Emeraude.Application.Common.Results.Identity
{
    public class BearerAuthenticationResult : IBearerAuthenticationResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string JsonWebToken { get; set; }

        public string RefreshToken { get; set; }

        public static BearerAuthenticationResult FailedResult
        {
            get
            {
                return new BearerAuthenticationResult
                {
                    Success = false,
                    Message = "Authentication failed."
                };
            }
        }

        public static BearerAuthenticationResult SuccessResult(string jsonWebToken, string refreshToken)
        {
            return new BearerAuthenticationResult
            {
                Success = true,
                Message = "Successful authentication.",
                JsonWebToken = jsonWebToken,
                RefreshToken = refreshToken
            };
        }
    }
}
