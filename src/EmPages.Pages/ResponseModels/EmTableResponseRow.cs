using System.Collections.Generic;

namespace EmPages.Pages.ResponseModels;

/// <summary>
/// EmPage table response row.
/// </summary>
public class EmTableResponseRow
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTableResponseRow"/> class.
    /// </summary>
    public EmTableResponseRow()
    {
        this.Cells = new List<EmTableResponseCell>();
        this.Actions = new List<EmResponseAction>();
    }

    /// <summary>
    /// Row index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Collection of row cells.
    /// </summary>
    public IList<EmTableResponseCell> Cells { get; }

    /// <summary>
    /// Collection of row actions.
    /// </summary>
    public IList<EmResponseAction> Actions { get; }
}