using System.Threading.Tasks;

namespace Emeraude.Identity;

/// <summary>
/// Initializer for identity capabilities of the framework.
/// </summary>
public interface IEmIdentityInitializer
{
    /// <summary>
    /// Initialize framework identity.
    /// </summary>
    /// <returns></returns>
    Task InitializeAsync();
}