using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeRequestChangeEmailEventHandler : IRequestChangeEmailEventHandler
{
    public virtual async Task HandleAsync(RequestChangeEmailEventArgs args)
    {
        await Task.CompletedTask;
    }
}