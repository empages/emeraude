using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeLoginEventHandler : ILoginEventHandler
{
    public virtual async Task HandleAsync(LoginEventArgs args)
    {
        await Task.CompletedTask;
    }
}