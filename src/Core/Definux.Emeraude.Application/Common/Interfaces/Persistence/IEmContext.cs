using System;
using Definux.Emeraude.Application.Common.Interfaces.Shared;

namespace Definux.Emeraude.Application.Common.Interfaces.Persistence
{
    /// <summary>
    /// Main database context of Emeraude application.
    /// </summary>
    public interface IEmContext : IDatabaseContext
    {
        /// <summary>
        /// Method that returns the type of the context.
        /// </summary>
        /// <returns></returns>
        Type GetContextType();
    }
}
