using System.Diagnostics.CodeAnalysis;
using EmPages.Pages;

namespace EmPages.Application.Pages.Users;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
public class UsersPageModel : EmPageModel
{
    public string Email { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public bool IsLockedOut { get; set; }
}