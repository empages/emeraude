using System.Reflection;

namespace Emeraude.Application.Admin;

/// <summary>
/// Assembly provider of the Emeraude administration.
/// </summary>
public static class AdminAssembly
{
    /// <summary>
    /// Gets the assembly of the Emeraude administration.
    /// </summary>
    /// <returns></returns>
    public static Assembly GetAssembly()
    {
        return Assembly.GetExecutingAssembly();
    }
}