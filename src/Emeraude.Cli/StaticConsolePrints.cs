using System;
using System.Reflection;
using Emeraude.Cli.Commands;

namespace Emeraude.Cli;

/// <summary>
/// Static strings for console prints.
/// </summary>
internal static class StaticConsolePrints
{
    /// <summary>
    /// Prints the general information of the CLI.
    /// </summary>
    internal static void PrintGeneralInformation()
    {
        string versionString = Assembly
            .GetEntryAssembly()?
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion;

        Console.WriteLine($"Emeraude Framework .NET Command-Line Tools {versionString} (https://emeraude.dev/)");
        Console.WriteLine();
        Console.WriteLine("- - - - - -");
        Console.WriteLine();
        Console.WriteLine("Usage: emeraude [command] [parameters]");
        Console.WriteLine();
        Console.WriteLine("- - - - - -");
        Console.WriteLine();
        Console.WriteLine("Commands:");
        Console.WriteLine();
        PrintCommandDetails(
            $"create {CommandParameters.Name} projectName",
            $"Make sure the project name is in PascalCase format.",
            $"emeraude create {CommandParameters.Name} MyAwesomeProject");

        PrintCommandDetails(
            $"em-page {CommandParameters.Name} pageName {CommandParameters.ConfigurationDirectory} configurationDirectory",
            "Make sure the page name is in PascalCase format. Configuration path is optional.",
            $"emeraude em-page {CommandParameters.Name} Dog");

        PrintCommandDetails(
            $"request {CommandParameters.Name} requestName {CommandParameters.ConfigurationDirectory} configurationDirectory",
            "Make sure the page name is in PascalCase format and ends with Query or Command suffix. Configuration path is optional.",
            $"emeraude request {CommandParameters.Name} CreateDogCommand");

        Console.WriteLine("- - - - - -");
        Console.WriteLine();
        Console.WriteLine("=> help");
        Console.WriteLine();
        Console.WriteLine("- - - - - -");
    }

    /// <summary>
    /// Prints the help information of the CLI.
    /// </summary>
    internal static void PrintHelpInformation()
    {
        Console.WriteLine("Help:");
        Console.WriteLine(" - Upgrade Command: 'dotnet tool update --global Emeraude.Cli'");
        Console.WriteLine();
    }

    private static void PrintCommandDetails(string command, string help, string example)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("Command: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(command);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Help: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(help);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Example: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(example);
        Console.WriteLine();
        Console.ResetColor();
    }
}