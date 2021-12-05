using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeRegisterEventHandler : IRegisterEventHandler
{
    public virtual async Task HandleAsync(RegisterEventArgs args)
    {
        await Task.CompletedTask;
    }
}