using System.Collections.Generic;

namespace EmPages.Pages.Pages.Table;

/// <summary>
/// EmPage table response header.
/// </summary>
public class EmTableResponseHeader
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTableResponseHeader"/> class.
    /// </summary>
    public EmTableResponseHeader()
    {
        this.Cells = new HashSet<EmTableResponseHeaderCell>();
    }

    /// <summary>
    /// Collection of header cells.
    /// </summary>
    public ICollection<EmTableResponseHeaderCell> Cells { get; }
}