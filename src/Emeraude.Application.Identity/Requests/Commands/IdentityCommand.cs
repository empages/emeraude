using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Emeraude.Application.Identity.Requests.Commands;

/// <summary>
/// Base identity command used.
/// </summary>
public abstract class IdentityCommand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityCommand"/> class.
    /// </summary>
    protected IdentityCommand()
    {
        this.AdditionalParameters = new Dictionary<string, object>();
    }

    /// <summary>
    /// Additional parameters useful for the need of identity events.
    /// </summary>
    [BindNever]
    public IDictionary<string, object> AdditionalParameters { get; set; }
}