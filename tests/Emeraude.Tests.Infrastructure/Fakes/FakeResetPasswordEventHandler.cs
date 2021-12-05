using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeResetPasswordEventHandler : IResetPasswordEventHandler
{
    public virtual async Task HandleAsync(ResetPasswordEventArgs args)
    {
        await Task.CompletedTask;
    }
}