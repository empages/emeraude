using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Emeraude.Pages;

namespace Emeraude.Application.Pages.RegisterUser;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", MessageId = "Elements should be documented", Justification = "Internal framework usage")]
public class RegisterUserPageSubmitCommand : IEmPageSubmitCommand
{
    public async Task HandleAsync(EmPageCommandRequest request)
    {
    }
}