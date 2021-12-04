using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Models.DetailsView;

/// <summary>
/// Schema implementation for table view.
/// </summary>
public class EmPageDetailsViewModel : EmPageViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDetailsViewModel"/> class.
    /// </summary>
    /// <param name="context"></param>
    public EmPageDetailsViewModel(EmPageViewContext context)
        : base(context)
    {
        this.Features = new List<EmPageDetailsFeatureModel>();
        this.Fields = new List<EmPageDetailsFieldModel>();
    }

    /// <summary>
    /// Identifier of the view model.
    /// </summary>
    public string Identifier { get; set; }

    /// <summary>
    /// List of all details feature of current EmPage.
    /// </summary>
    public IList<EmPageDetailsFeatureModel> Features { get; set; }

    /// <summary>
    /// Fields of the details view.
    /// </summary>
    public List<EmPageDetailsFieldModel> Fields { get; set; }
}