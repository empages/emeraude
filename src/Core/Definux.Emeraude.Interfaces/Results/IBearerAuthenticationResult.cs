using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Interfaces.Results
{
    public interface IBearerAuthenticationResult
    {
        bool Success { get; set; }

        string Message { get; set; }

        string JsonWebToken { get; set; }

        string RefreshToken { get; set; }
    }
}
