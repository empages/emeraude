using System;
using System.Collections.Generic;
using System.Linq;
using Emeraude.Cli.Commands;
using Emeraude.Cli.Commands.Implementations.Create;
using Emeraude.Cli.Commands.Implementations.EmPage;
using Emeraude.Cli.Commands.Implementations.Request;
using Emeraude.Cli.Properties;

namespace Emeraude.Cli;

/// <summary>
/// Command factory provider that contains and triggers the command execution.
/// </summary>
internal class ActionProvider
{
    private readonly string[] args;
    private readonly Dictionary<string, Command> commandFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionProvider"/> class.
    /// </summary>
    /// <param name="args"></param>
    internal ActionProvider(string[] args)
    {
        this.args = args;

        this.commandFactory = new Dictionary<string, Command>
        {
            { CommandsNames.Create, new CreateCommand() },
            { CommandsNames.Request, new RequestCommand() },
            { CommandsNames.EmPage, new EmPageCommand() },
        };
    }

    /// <summary>
    /// Parse and executes the input command.
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
                this.commandFactory[consoleCommand.Command].LoadCliConfig(consoleCommand.GetParameter(CommandParameters.ConfigurationDirectory));
                this.commandFactory[consoleCommand.Command].Execute(consoleCommand.Parameters);
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