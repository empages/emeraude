using System.Collections.Generic;

namespace EmPages.Pages.ResponseModels;

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
        this.Components = new List<EmResponseComponent>();
        this.Actions = new List<EmResponseAction>();
    }

    /// <summary>
    /// Collection of components that correspond to the cells.
    /// </summary>
    public IList<EmResponseComponent> Components { get; }

    /// <summary>
    /// Collection of page actions.
    /// </summary>
    public IList<EmResponseAction> Actions { get; set; }
}