namespace EmPages.Pages.ResponseModels;

/// <summary>
/// EmPage response action.
/// </summary>
public class EmResponseAction
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmResponseAction"/> class.
    /// </summary>
    /// <param name="action"></param>
    public EmResponseAction(EmAction action)
    {
        this.Title = action.Title;
        this.Target = action.Target;
        this.Order = action.Order;
        this.Type = action.Type;
        this.RequiresConfirmation = action.RequiresConfirmation;
    }

    /// <summary>
    /// <inheritdoc cref="EmAction.Title"/>.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// <inheritdoc cref="EmAction.Target"/>.
    /// </summary>
    public string Target { get; set; }

    /// <summary>
    /// <inheritdoc cref="EmAction.Order"/>.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// <inheritdoc cref="EmAction.Type"/>.
    /// </summary>
    public PageActionType Type { get; set; }

    /// <summary>
    /// <inheritdoc cref="EmAction.RequiresConfirmation"/>.
    /// </summary>
    public bool RequiresConfirmation { get; set; }
}