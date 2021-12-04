using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Emeraude;

/// <summary>
/// Static class that provides access to the Emeraude assembly information.
/// </summary>
public static class ApplicationAssemblyPart
{
    /// <inheritdoc cref="System.Reflection.Assembly"/>
    public static Assembly Assembly => typeof(ApplicationAssemblyPart).GetTypeInfo().Assembly;

    /// <inheritdoc cref="Microsoft.AspNetCore.Mvc.ApplicationParts.AssemblyPart"/>
    public static AssemblyPart AssemblyPart => new AssemblyPart(Assembly);
}