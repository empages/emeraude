using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeLoginEventHandler : ILoginEventHandler
{
    public async virtual Task HandleAsync(LoginEventArgs args)
    {
    }
}