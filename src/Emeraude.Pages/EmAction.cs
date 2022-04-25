namespace Emeraude.Pages;

/// <summary>
/// Implementation of action.
/// </summary>
public class EmAction
{
    /// <summary>
    /// Title of the action.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Order of the action in its containing scope.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Type of the action.
    /// </summary>
    public PageActionType Type { get; set; }

    /// <summary>
    /// Indicates whether the action requires additional confirmation or not.
    /// </summary>
    public bool RequiresConfirmation { get; set; }

    /// <summary>
    /// Target value that can be different based on the action type.
    /// For routing type the target is route value.
    /// For command type the target is command name.
    /// </summary>
    public string Target { get; set; }
}