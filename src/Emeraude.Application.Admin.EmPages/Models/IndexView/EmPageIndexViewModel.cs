namespace Emeraude.Application.Admin.EmPages.Models.IndexView;

/// <summary>
/// Model implementation for index view.
/// </summary>
public class EmPageIndexViewModel : EmPageViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageIndexViewModel"/> class.
    /// </summary>
    /// <param name="context"></param>
    public EmPageIndexViewModel(EmPageViewContext context)
        : base(context)
    {
    }

    /// <summary>
    /// Table view model.
    /// </summary>
    public EmPageTableViewModel TableViewModel { get; set; }

    /// <summary>
    /// Custom view model.
    /// </summary>
    public EmPageCustomViewModel CustomViewModel { get; set; }
}