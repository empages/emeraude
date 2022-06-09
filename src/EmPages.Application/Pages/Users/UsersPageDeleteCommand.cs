using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EmPages.Pages;

namespace EmPages.Application.Pages.Users;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
public class UsersPageDeleteCommand : IEmPageCommand
{
    public async Task HandleAsync(EmPageCommandRequest request)
    {
    }
}