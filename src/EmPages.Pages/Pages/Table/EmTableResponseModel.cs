using System.Collections.Generic;

namespace EmPages.Pages.Pages.Table;

/// <summary>
/// Model representing table model response expected by the page request.
/// </summary>
public class EmTableResponseModel : EmResponseModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTableResponseModel"/> class.
    /// </summary>
    public EmTableResponseModel()
        : base("EmTablePage")
    {
        this.Header = new EmTableResponseHeader();
        this.Rows = new HashSet<EmTableResponseRow>();
    }

    /// <summary>
    /// Table rows.
    /// </summary>
    public ICollection<EmTableResponseRow> Rows { get; }

    /// <summary>
    /// Table header.
    /// </summary>
    public EmTableResponseHeader Header { get; }
}