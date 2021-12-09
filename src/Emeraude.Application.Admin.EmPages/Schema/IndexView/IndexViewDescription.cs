using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Application.Admin.EmPages.Schema.IndexView;

/// <summary>
/// Index view description.
/// </summary>
public class IndexViewDescription : ViewDescription<IndexViewItem>
{
    /// <inheritdoc cref="IndexViewConfigurationBuilder{TModel}.CustomViewComponent"/>
    public CustomIndexViewComponent CustomViewComponent { get; set; }

    /// <inheritdoc cref="IndexViewConfigurationBuilder{TModel}.OrderProperties"/>
    public IDictionary<string, string> OrderProperties { get; set; }

    /// <inheritdoc/>
    public override bool IsActive =>
        (this.ViewItems != null && this.ViewItems.Any()) || this.CustomViewComponent != null;
}