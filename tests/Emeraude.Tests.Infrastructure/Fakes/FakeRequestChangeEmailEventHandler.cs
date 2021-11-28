using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes
{
    public class FakeRequestChangeEmailEventHandler : IRequestChangeEmailEventHandler
    {
        public async virtual Task HandleAsync(RequestChangeEmailEventArgs args)
        {
        }
    }
}