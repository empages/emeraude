using System;
using Emeraude.Infrastructure.Identity;
using Emeraude.Infrastructure.Identity.Persistence;

namespace Emeraude.Infrastructure.Persistence.Context
{
    /// <summary>
    /// Main database context of Emeraude application.
    /// </summary>
    public interface IEmContext : IDatabaseContext, IIdentityContext
    {
        /// <summary>
        /// Method that returns the type of the context.
        /// </summary>
        /// <returns></returns>
        Type GetContextType();
    }
}
