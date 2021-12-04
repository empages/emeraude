namespace Emeraude.Configuration.Options;

/// <summary>
/// Contract for options instance of Emeraude module.
/// </summary>
public interface IEmOptions
{
    /// <summary>
    /// Validate current instance of the options.
    /// </summary>
    void Validate();
}