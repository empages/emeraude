using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Emeraude.Essentials.Extensions;

namespace Emeraude.Application.Admin.EmPages.Schema;

/// <summary>
/// Defines EmPage action.
/// </summary>
public class EmPageAction
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageAction"/> class.
    /// </summary>
    public EmPageAction()
    {
        this.QueryStringParameters = new Dictionary<string, string>();
    }

    /// <summary>
    /// Order of the action.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Name of the action.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Relative to main entity URL of the action.
    /// </summary>
    public string RelativeUrlFormat { get; set; }

    /// <summary>
    /// Dictionary that contains the query string parameters.
    /// </summary>
    public IDictionary<string, string> QueryStringParameters { get; }

    /// <summary>
    /// Relative URL of the action.
    /// </summary>
    public string RelativeUrl { get; set; }

    /// <summary>
    /// Gets or set the redirect URL after the execution of the action.
    /// </summary>
    public string RedirectTo
    {
        get => this.QueryStringParameters.GetValueOrDefault("redirectTo");
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                this.QueryStringParameters["redirectTo"] = value;
            }
        }
    }

    /// <summary>
    /// Represents a flag that indicates whether the action be executed separately or not.
    /// </summary>
    public bool SingleContext { get; set; }

    /// <summary>
    /// Execution method.
    /// </summary>
    public HttpMethod Method { get; set; } = HttpMethod.Get;

    /// <summary>
    /// Indicates whether the action requires confirmation.
    /// </summary>
    public bool HasConfirmation => string.IsNullOrWhiteSpace(this.ConfirmationMessage);

    /// <summary>
    /// Message for action confirmation.
    /// </summary>
    public string ConfirmationMessage { get; set; }

    /// <summary>
    /// Builds full action url.
    /// </summary>
    /// <param name="entityKey"></param>
    /// <returns></returns>
    public string BuildActionUrlFormat(string entityKey)
    {
        if (!string.IsNullOrWhiteSpace(this.RelativeUrl))
        {
            return this.RelativeUrl;
        }

        var relativeUrl = this.RelativeUrlFormat ?? string.Empty;
        var urlBase = relativeUrl.StartsWith("/admin/") ? string.Empty : $"/admin/{entityKey}";
        if (!relativeUrl.StartsWith("/"))
        {
            relativeUrl = "/" + relativeUrl;
        }

        if (relativeUrl.Equals("/"))
        {
            relativeUrl = string.Empty;
        }

        var queryString = string.Join('&', this.QueryStringParameters.Select(x => $"{x.Key}={x.Value}"));

        return $"{urlBase}{relativeUrl}?{queryString}";
    }
}