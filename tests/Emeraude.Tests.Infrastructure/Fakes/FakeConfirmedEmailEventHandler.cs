using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes
{
    public class FakeConfirmedEmailEventHandler : IConfirmedEmailEventHandler
    {
        public async virtual Task HandleAsync(ConfirmedEmailEventArgs args)
        {
        }
    }
}