using System;
using System.Collections.Generic;
using System.Text;

namespace Emeraude.Application.ClientBuilder.Models;

/// <summary>
/// Simplified description for a method argument extracted via reflection.
/// </summary>
public class ArgumentDescription
{
    /// <summary>
    /// Name of the argument.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Type description of the argument.
    /// </summary>
    public TypeDescription Type { get; set; }
}