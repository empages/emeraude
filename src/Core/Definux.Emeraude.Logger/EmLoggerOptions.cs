using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Logger
{
    /// <summary>
    /// Options for logging infrastructure of Emeraude.
    /// </summary>
    public class EmLoggerOptions : IEmOptions
    {
        /// <summary>
        /// Provider of logger storage for the application.
        /// </summary>
        public DatabaseContextProvider ContextProvider { get; set; }

        /// <summary>
        /// Provides the availability to be used custom logger with the base logger definitions.
        /// </summary>
        public bool UseExternalLoggerImplementation { get; set; }
    }
}