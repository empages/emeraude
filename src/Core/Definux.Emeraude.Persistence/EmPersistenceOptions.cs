using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Persistence
{
    /// <summary>
    /// Options for persistence infrastructure of Emeraude.
    /// </summary>
    public class EmPersistenceOptions : IEmOptions
    {
        /// <summary>
        /// Provider of database storage for the application.
        /// </summary>
        public DatabaseContextProvider ContextProvider { get; set; }
    }
}