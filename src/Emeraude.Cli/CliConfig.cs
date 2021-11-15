namespace Emeraude.Cli
{
    /// <summary>
    /// Implementation of CLI configuration.
    /// </summary>
    internal class CliConfig
    {
        /// <summary>
        /// Name of the Emeraude CLI configuration.
        /// </summary>
        internal const string FileName = "em-cli.json";

        /// <summary>
        /// Initializes a new instance of the <see cref="CliConfig"/> class.
        /// </summary>
        public CliConfig()
        {
            this.Base = new BaseConfiguration();
        }

        /// <inheritdoc cref="BaseConfiguration"/>
        public BaseConfiguration Base { get; set; }

        /// <summary>
        /// Configuration base section.
        /// </summary>
        internal class BaseConfiguration
        {
            /// <summary>
            /// Name of the project.
            /// </summary>
            public string ProjectName { get; set; }
        }
    }
}
