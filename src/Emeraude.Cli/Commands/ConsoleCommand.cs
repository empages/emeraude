using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Cli.Commands
{
    /// <summary>
    /// Mapping class that parse the command string.
    /// </summary>
    internal class ConsoleCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleCommand"/> class.
        /// </summary>
        /// <param name="commandArgs"></param>
        internal ConsoleCommand(string[] commandArgs)
        {
            this.Parameters = new Dictionary<string, string>();
            this.ParseCommand(commandArgs);
        }

        /// <summary>
        /// Command string.
        /// </summary>
        internal string Command { get; set; }

        /// <summary>
        /// Parameters of the command.
        /// </summary>
        internal Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Indicates whether the command is valid or not.
        /// </summary>
        internal bool IsValid { get; set; }

        /// <summary>
        /// Get command parameter by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal string GetParameter(string name)
        {
            string parameterValue = null;
            if (this.Parameters.ContainsKey(name))
            {
                parameterValue = this.Parameters[name];
            }

            return parameterValue;
        }

        private void ParseCommand(string[] commandArgs)
        {
            if (commandArgs != null &&
                commandArgs.Length > 2 &&
                commandArgs.Length % 2 == 1 &&
                CommandsNames.CommandList.Contains(commandArgs[0]))
            {
                this.Command = commandArgs[0];
                for (int i = 1; i < commandArgs.Length; i += 2)
                {
                    this.Parameters[commandArgs[i]] = commandArgs[i + 1];
                }

                this.IsValid = true;
            }
            else if (commandArgs != null &&
                     commandArgs.Length == 1 &&
                     CommandsNames.CommandList.Contains(commandArgs[0]))
            {
                this.IsValid = true;
            }
        }
    }
}
