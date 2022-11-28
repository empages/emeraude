using System.Collections.Generic;

namespace EmPages.Pages.Pages.Details;

/// <summary>
/// Model representing details model response expected by the page request.
/// </summary>
public class EmDetailsResponseModel : EmResponseModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmDetailsResponseModel"/> class.
    /// </summary>
    public EmDetailsResponseModel()
        : base("EmDetailsPage")
    {
        this.Fields = new HashSet<EmDetailsResponseField>();
    }

    /// <summary>
    /// Collection of details fields.
    /// </summary>
    public ICollection<EmDetailsResponseField> Fields { get; }
}