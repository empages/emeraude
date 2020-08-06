using Definux.Emeraude.Application.Common.Interfaces.Shared;
using System;

namespace Definux.Emeraude.Application.Common.Interfaces.Persistence
{
    public interface IEmContext : IDatabaseContext
    {
        Type GetContextType();
    }
}
