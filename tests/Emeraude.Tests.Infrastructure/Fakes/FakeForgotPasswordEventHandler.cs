using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes;

public class FakeForgotPasswordEventHandler : IForgotPasswordEventHandler
{
    public async virtual Task HandleAsync(ForgotPasswordEventArgs args)
    {
    }
}