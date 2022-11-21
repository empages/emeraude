using System.Collections.Generic;

namespace EmPages.Pages.ResponseModels;

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
        this.Cells = new List<EmTableResponseHeaderCell>();
    }

    /// <summary>
    /// Collection of header cells.
    /// </summary>
    public IList<EmTableResponseHeaderCell> Cells { get; }
}