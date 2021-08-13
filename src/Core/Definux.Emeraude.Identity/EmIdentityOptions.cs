using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Identity
{
    /// <summary>
    /// Options for identity infrastructure of Emeraude.
    /// </summary>
    public class EmIdentityOptions : IEmOptions
    {
        /// <summary>
        /// Flag that indicates whether to be registered external authentication from the settings.
        /// </summary>
        public bool HasExternalAuthentication { get; set; }
    }
}