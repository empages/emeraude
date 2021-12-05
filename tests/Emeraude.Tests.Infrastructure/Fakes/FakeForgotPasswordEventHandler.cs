using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeForgotPasswordEventHandler : IForgotPasswordEventHandler
{
    public virtual async Task HandleAsync(ForgotPasswordEventArgs args)
    {
        await Task.CompletedTask;
    }
}