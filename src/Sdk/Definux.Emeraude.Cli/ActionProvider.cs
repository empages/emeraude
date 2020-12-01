using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Cli.Commands;
using Definux.Emeraude.Cli.Commands.Implementations.Create;
using Definux.Emeraude.Cli.Commands.Implementations.Page;
using Definux.Emeraude.Cli.Commands.Implementations.Request;
using Definux.Emeraude.Cli.Properties;

namespace Definux.Emeraude.Cli
{
    /// <summary>
    /// Command factory provider that contains and triggers the command execution.
    /// </summary>
    internal class ActionProvider
    {
        private readonly string[] args;
        private readonly Dictionary<string, Command> commandFactories;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionProvider"/> class.
        /// </summary>
        /// <param name="args"></param>
        internal ActionProvider(string[] args)
        {
            this.args = args;

            this.commandFactories = new Dictionary<string, Command>
            {
                { CommandsNames.Create, new CreateCommand() },
                { CommandsNames.Page, new PageCommand() },
                { CommandsNames.Request, new RequestCommand() },
            };
        }

        /// <summary>
        /// Parse and executes the inputed command.
        /// </summary>
        internal void Execute()
        {
            try
            {
                if (this.args.FirstOrDefault()?.ToLower() == CommandsNames.Help)
                {
                    StaticConsolePrints.PrintHelpInformation();
                    return;
                }

                ConsoleCommand consoleCommand = new ConsoleCommand(this.args);
                if (consoleCommand.IsValid)
                {
                    this.commandFactories[consoleCommand.Command].LoadCliConfig(consoleCommand.GetParameter(CommandParameters.ConfigurationDirectory));
                    this.commandFactories[consoleCommand.Command].Execute(consoleCommand.Parameters);
                }
                else
                {
                    StaticConsolePrints.PrintGeneralInformation();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Messages.SomethingUnexpectedHappened);
                Console.WriteLine(Messages.SeeHelpForCli);
            }
        }
    }
}
