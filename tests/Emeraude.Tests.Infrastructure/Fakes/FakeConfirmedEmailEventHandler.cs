using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeConfirmedEmailEventHandler : IConfirmedEmailEventHandler
{
    public virtual async Task HandleAsync(ConfirmedEmailEventArgs args)
    {
        await Task.CompletedTask;
    }
}