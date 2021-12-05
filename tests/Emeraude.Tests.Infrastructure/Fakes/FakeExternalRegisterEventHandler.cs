using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeExternalRegisterEventHandler : IExternalRegisterEventHandler
{
    public virtual async Task HandleAsync(ExternalRegisterEventArgs args)
    {
        await Task.CompletedTask;
    }
}