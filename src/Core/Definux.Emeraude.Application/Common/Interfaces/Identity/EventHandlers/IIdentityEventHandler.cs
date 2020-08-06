using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers
{
    public interface IIdentityEventHandler
    {
        Task HandleAsync(Guid userId, params string[] args);
    }
}
