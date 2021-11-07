using System;
using System.Collections.Generic;
using System.Reflection;
using Definux.Emeraude.Configuration.Options;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Presentation.PortalGateway
{
    /// <summary>
    /// Options for Emeraude portal.
    /// </summary>
    public class EmPortalGatewayOptions : IEmOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPortalGatewayOptions"/> class.
        /// </summary>
        public EmPortalGatewayOptions()
        {
            this.PortalUrls = new List<string>
            {
                EmPortalConstants.EmeraudePortalUrl,
            };
        }

        /// <summary>
        /// List of all portal URLs that consume data through the gateway.
        /// </summary>
        public IList<string> PortalUrls { get; }

        /// <summary>
        /// Identification of the gateway. Make sure that value is complex enough.
        /// </summary>
        public string GatewayId { get; set; }

        /// <inheritdoc/>
        public void Validate()
        {
        }
    }
}