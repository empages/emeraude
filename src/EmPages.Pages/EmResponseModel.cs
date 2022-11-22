using System.Collections.Generic;

namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of response model.
/// </summary>
public abstract class EmResponseModel : IEmResponseModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmResponseModel"/> class.
    /// </summary>
    protected EmResponseModel()
    {
        this.Components = new HashSet<EmResponseComponent>();
        this.Actions = new HashSet<EmResponseAction>();
    }

    /// <summary>
    /// Title of the page.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Collection of components that correspond to the cells.
    /// </summary>
    public ICollection<EmResponseComponent> Components { get; }

    /// <summary>
    /// Collection of page actions.
    /// </summary>
    public ICollection<EmResponseAction> Actions { get; }
}