﻿namespace Emeraude.Cli.Commands;

/// <summary>
/// Commands names provider class.
/// </summary>
internal static class CommandsNames
{
    /// <summary>
    /// Name of the 'Create' command.
    /// </summary>
    internal const string Create = "create";

    /// <summary>
    /// Name of the 'Request' command.
    /// </summary>
    internal const string Request = "request";

    /// <summary>
    /// Name of the 'EmPage' command.
    /// </summary>
    internal const string EmPage = "em-page";

    /// <summary>
    /// Name of the 'Help' command.
    /// </summary>
    internal const string Help = "help";

    /// <summary>
    /// List of all commands names.
    /// </summary>
    internal static readonly string[] CommandList = new string[]
    {
        Create,
        Request,
        EmPage,
    };
}