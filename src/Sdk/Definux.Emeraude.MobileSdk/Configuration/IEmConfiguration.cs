using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.Configuration
{
    public interface IEmConfiguration
    {
        Dictionary<string, string> Headers { get; }

        string RootBaseUrl { get; }

        string FacebookAppId { get; }

        string GoogleClientId { get; }

        string FacebookRedirectUrl { get; }

        string GoogleRedirectUrl { get; }

        HostSettings ToHostSettings();
    }
}
