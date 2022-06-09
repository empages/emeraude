using System.Reflection;

namespace EmPages.Application;

/// <summary>
/// Current assembly provider.
/// </summary>
public static class ApplicationAssembly
{
    /// <inheritdoc cref="System.Reflection.Assembly"/>
    public static Assembly Assembly => Assembly.GetExecutingAssembly();
}