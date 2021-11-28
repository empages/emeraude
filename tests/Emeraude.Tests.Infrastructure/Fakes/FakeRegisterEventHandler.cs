using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;

namespace Emeraude.Tests.Infrastructure.Fakes
{
    public class FakeRegisterEventHandler : IRegisterEventHandler
    {
        public async virtual Task HandleAsync(RegisterEventArgs args)
        {
        }
    }
}