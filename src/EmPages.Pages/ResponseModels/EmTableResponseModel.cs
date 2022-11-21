using System.Collections.Generic;

namespace EmPages.Pages.ResponseModels;

/// <summary>
/// Model representing table model response expected by the page request.
/// </summary>
public class EmTableResponseModel : EmResponseModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmTableResponseModel"/> class.
    /// </summary>
    public EmTableResponseModel()
    {
        this.Header = new EmTableResponseHeader();
        this.Rows = new List<EmTableResponseRow>();
    }

    /// <summary>
    /// Table rows.
    /// </summary>
    public IList<EmTableResponseRow> Rows { get; }

    /// <summary>
    /// Table header.
    /// </summary>
    public EmTableResponseHeader Header { get; set; }
}