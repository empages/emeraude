using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeResetPasswordEventHandler : IResetPasswordEventHandler
{
    public async virtual Task HandleAsync(ResetPasswordEventArgs args)
    {
    }
}