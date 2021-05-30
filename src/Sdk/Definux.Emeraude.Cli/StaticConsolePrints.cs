using System;
using System.Reflection;

namespace Definux.Emeraude.Cli
{
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
            string versionString = Assembly.GetEntryAssembly()
                                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                .InformationalVersion
                                .ToString();

            Console.WriteLine($"Emeraude .NET Command-line Tools {versionString} (https://emeraude.dev/)");
            Console.WriteLine($"Powered by Definux (https://definux.io/)");
            Console.WriteLine("- - - - - -");
            Console.WriteLine("Usage: em [command] [parameters]");
            Console.WriteLine("- - - - - -");
            Console.WriteLine("Commands:");
            Console.WriteLine("=> create -n projectName(PascalCase)");
            Console.WriteLine("=> page -n pageName(PascalCase) -c configurationDirectory(optional)");
            Console.WriteLine("=> request -n requestName(PascalCase, must ends with Query or Command) -c configurationDirectory(optional)");
            Console.WriteLine("- - - - - -");
            Console.WriteLine("=> help");
            Console.WriteLine("- - - - - -");
        }

        /// <summary>
        /// Prints the help information of the CLI.
        /// </summary>
        internal static void PrintHelpInformation()
        {
            Console.WriteLine("Help:");
            Console.WriteLine(" - Upgrade Command: 'dotnet tool update --global Definux.Emeraude.Cli'");
            Console.WriteLine();
        }
    }
}
