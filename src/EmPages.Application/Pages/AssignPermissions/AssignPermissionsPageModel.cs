using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EmPages.Pages;

namespace EmPages.Application.Pages.AssignPermissions;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
public class AssignPermissionsPageModel : EmPageModel
{
    public string UserEmail { get; set; }

    public IEnumerable<string> UserPermissions { get; set; }
}