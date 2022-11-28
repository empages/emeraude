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
    /// <param name="pageType"></param>
    protected EmResponseModel(string pageType)
    {
        this.PageType = pageType;
        this.Components = new HashSet<EmResponseComponent>();
        this.Actions = new HashSet<EmResponseAction>();
        this.TypeDescriptions = new HashSet<EmTypeDescription>();
    }

    /// <summary>
    /// Type of the page.
    /// </summary>
    public string PageType { get; }

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

    /// <summary>
    /// Collection of type descriptions.
    /// </summary>
    public ICollection<EmTypeDescription> TypeDescriptions { get; }
}