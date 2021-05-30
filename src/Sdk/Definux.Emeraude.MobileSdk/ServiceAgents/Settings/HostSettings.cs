using System;
using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Settings
{
    /// <summary>
    /// Service agent host settings.
    /// </summary>
    public class HostSettings
    {
        /// <summary>
        /// Dictionary with all headers which must be applied with any request to the web API.
        /// </summary>
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Base URL of the web API.
        /// </summary>
        public string Url { get; set; }
    }
}
