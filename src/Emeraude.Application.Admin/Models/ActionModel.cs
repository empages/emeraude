using System.Net.Http;

namespace Emeraude.Application.Admin.Models;

/// <summary>
/// Definition for action button that can be used in the <see cref="EmPageViewSchema"/>.
/// </summary>
public class ActionModel : LinkModel
{
    /// <summary>
    /// Order of the action.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Represents a flag that indicates whether the action be opened on separated page or not.
    /// </summary>
    public bool OpenOnSeparatePage { get; set; }

    /// <summary>
    /// HTTP method of the action.
    /// </summary>
    public HttpMethod ActionHttpMethod { get; set; } = HttpMethod.Get;

    /// <summary>
    /// Indicates whether the action requires confirmation.
    /// </summary>
    public bool HasConfirmation => !string.IsNullOrWhiteSpace(this.ConfirmationMessage);

    /// <summary>
    /// Message for action confirmation.
    /// </summary>
    public string ConfirmationMessage { get; set; }
}