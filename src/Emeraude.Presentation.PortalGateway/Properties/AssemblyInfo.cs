using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Emeraude.Presentation.PortalGateway")]
[assembly: ComVisible(false)]

namespace Emeraude.Presentation.PortalGateway.Properties;

/// <summary>
/// Assembly info provider.
/// </summary>
public static class AssemblyInfo
{
    /// <summary>
    /// Gets execution assembly.
    /// </summary>
    /// <returns></returns>
    public static Assembly GetAssembly()
    {
        return Assembly.GetExecutingAssembly();
    }
}