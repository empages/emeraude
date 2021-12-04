using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeExternalRegisterEventHandler : IExternalRegisterEventHandler
{
    public async virtual Task HandleAsync(ExternalRegisterEventArgs args)
    {
    }
}