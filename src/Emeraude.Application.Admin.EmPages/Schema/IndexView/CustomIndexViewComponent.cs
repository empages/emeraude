using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Schema.IndexView;

/// <summary>
/// Implementation of custom view for index view.
/// </summary>
public class CustomIndexViewComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomIndexViewComponent"/> class.
    /// </summary>
    public CustomIndexViewComponent()
    {
        this.Parameters = new Dictionary<string, object>();
    }

    /// <summary>
    /// Name of the custom component.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Parameters that will be provided during runtime to the current component.
    /// </summary>
    public Dictionary<string, object> Parameters { get; }
}