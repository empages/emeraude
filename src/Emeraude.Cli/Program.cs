namespace Emeraude.Cli
{
    /// <summary>
    /// Startup class of the CLI.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Startup method of the CLI.
        /// </summary>
        /// <param name="args"></param>
        internal static void Main(string[] args)
        {
            ActionProvider actionProvider = new ActionProvider(args);
            actionProvider.Execute();
        }
    }
}
