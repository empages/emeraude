using System;
using System.Collections.Generic;
using System.IO;
using Definux.Emeraude.Cli.Properties;
using Newtonsoft.Json;

namespace Definux.Emeraude.Cli.Commands
{
    /// <summary>
    /// Abstract implementation of CLI command factory.
    /// </summary>
    internal abstract class Command
    {
        /// <summary>
        /// <see cref="Cli.CliConfig"/>.
        /// </summary>
        protected CliConfig CliConfig { get; private set; }

        /// <summary>
        /// Directory where the CLI configuration is placed.
        /// </summary>
        protected string CliConfigDirectory { get; set; }

        /// <summary>
        /// Executes the command generation.
        /// </summary>
        /// <param name="parameters"></param>
        internal abstract void Execute(Dictionary<string, string> parameters);

        /// <summary>
        /// Loads and parse the CLI configuration file.
        /// </summary>
        /// <param name="configurationDirectory"></param>
        internal void LoadCliConfig(string configurationDirectory)
        {
            string workingDirectory = Directory.GetCurrentDirectory();

            if (!string.IsNullOrEmpty(configurationDirectory) && Directory.Exists(configurationDirectory))
            {
                workingDirectory = configurationDirectory;
            }

            Console.WriteLine(configurationDirectory);

            Console.WriteLine($"Scanning '{workingDirectory}' for '{CliConfig.FileName}'");
            var files = Directory.GetFiles(workingDirectory, CliConfig.FileName, SearchOption.AllDirectories);
            if (files != null && files.Length > 0)
            {
                this.CliConfig = JsonConvert.DeserializeObject<CliConfig>(File.ReadAllText(files[0]));
                this.CliConfigDirectory = new FileInfo(files[0]).Directory.FullName;
                Console.WriteLine(Messages.CliFileFound);
            }
            else
            {
                Console.WriteLine(Messages.CliFileNotFound);
            }
        }
    }
}
