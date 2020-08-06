using System;

namespace Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed
{
    public interface IDatabaseInitializerManager : IDatabaseInitializer
    {
        void LoadDatabaseInitializers(params Type[] initializersTypes);
    }
}
