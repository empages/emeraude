using System.Collections.Generic;

namespace EmPages.Pages.Pages.Form;

/// <summary>
/// Model representing form model response expected by the page request.
/// </summary>
public class EmFormResponseModel : EmResponseModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmFormResponseModel"/> class.
    /// </summary>
    public EmFormResponseModel()
    {
        this.Inputs = new HashSet<EmFormResponseInput>();
    }

    /// <summary>
    /// Name of the form submit command.
    /// </summary>
    public string SubmitCommand { get; set; }

    /// <summary>
    /// Collection of form inputs.
    /// </summary>
    public ICollection<EmFormResponseInput> Inputs { get; }
}