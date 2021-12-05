using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeExternalLoginEventHandler : IExternalLoginEventHandler
{
    public virtual async Task HandleAsync(ExternalLoginEventArgs args)
    {
        await Task.CompletedTask;
    }
}