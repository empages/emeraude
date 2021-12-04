namespace Emeraude.Presentation.PlatformBase.Models;

/// <summary>
/// View model of execution result action.
/// </summary>
public class ExecutionResultViewModel
{
    /// <summary>
    /// Title of the page.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Message on the page.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Status of the result.
    /// </summary>
    public bool Succeeded { get; set; }

    /// <summary>
    /// Execution reference.
    /// </summary>
    public string Reference { get; set; }
}