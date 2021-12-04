using Emeraude.Configuration.Options;

namespace Emeraude.Defaults.Options;

/// <summary>
/// Extensions for <see cref="EmOptionsSetup"/> and all of its properties.
/// </summary>
public static class EmOptionsSetupExtensions
{
    /// <summary>
    /// Includes the Emeraude Defaults assembly into the application main options.
    /// </summary>
    /// <param name="mainOptions"></param>
    public static void IncludeEmeraudeDefaultsAssembly(this EmMainOptions mainOptions)
    {
        mainOptions.AddAssembly(typeof(EmOptionsSetupExtensions).Assembly);
    }
}