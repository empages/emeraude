using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeExternalLoginEventHandler : IExternalLoginEventHandler
{
    public async virtual Task HandleAsync(ExternalLoginEventArgs args)
    {
    }
}