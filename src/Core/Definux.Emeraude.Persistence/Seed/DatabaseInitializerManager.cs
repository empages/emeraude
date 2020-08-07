using Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Persistence.Seed
{
    public class DatabaseInitializerManager : IDatabaseInitializerManager
    {
        private readonly IServiceProvider serviceProvider;
        private List<IDatabaseInitializer> databaseInitializers;
        
        public DatabaseInitializerManager(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.databaseInitializers = new List<IDatabaseInitializer>();
        }

        public void LoadDatabaseInitializers(params Type[] initializersTypes)
        {
            foreach (var initializerType in initializersTypes)
            {
                this.databaseInitializers.Add(this.serviceProvider.GetService(initializerType) as IDatabaseInitializer);
            }
        }

        public async Task SeedAsync()
        {
            if (this.databaseInitializers == null || this.databaseInitializers.Count == 0)
            {
                throw new InvalidOperationException("To seed data into database please load database initializers (IDatabaseInitializer) by LoadDatabaseInitializers.");
            }
            foreach (var initializer in this.databaseInitializers)
            {
                await initializer.SeedAsync();
            }
        }
    }
}
