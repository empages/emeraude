using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Schema.DetailsView;

/// <summary>
/// Details view description.
/// </summary>
public class DetailsViewDescription : ViewDescription<DetailsViewItem>
{
    /// <summary>
    /// List of all features for specified details view.
    /// </summary>
    public IList<EmPageFeatureDescription> Features { get; set; }
}