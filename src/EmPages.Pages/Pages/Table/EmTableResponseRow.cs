using System.Collections.Generic;

namespace EmPages.Pages.Pages.Table;

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
        this.Cells = new HashSet<EmTableResponseCell>();
        this.Actions = new HashSet<EmResponseAction>();
    }

    /// <summary>
    /// Row index.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Collection of row cells.
    /// </summary>
    public ICollection<EmTableResponseCell> Cells { get; }

    /// <summary>
    /// Collection of row actions.
    /// </summary>
    public ICollection<EmResponseAction> Actions { get; }
}