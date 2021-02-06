using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Persistence.Seed;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Interfaces;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Infrastructure.Persistence.Seed
{
    public class TestDataInitializer : DatabaseInitializer<TestEntityContext>, ITestDataInitializer
    {
        public TestDataInitializer(
            IHostEnvironment hostingEnvironment,
            TestEntityContext entityContext,
            ISystemFilesService systemFilesService,
            IUploadService uploadService,
            IRootsService rootsService) 
            : base(hostingEnvironment, entityContext, systemFilesService, uploadService, rootsService)
        {
        }

        public async override Task SeedAsync()
        {
            if (!await this.EntityContext.SimpleEntities.AnyAsync())
            {
                this.EntityContext.SimpleEntities.AddRange(EntitiesForInitialization());
                await this.EntityContext.SaveChangesAsync();
            }
        }

        private List<SimpleEntity> EntitiesForInitialization()
        {
            var list = new List<SimpleEntity>();
            list.Add(new SimpleEntity
            {
                Name = "Simple entity for you",
                Description = "Long description",
                Day = DayOfWeek.Wednesday
            });
            
            list.Add(new SimpleEntity
            {
                Name = "Simple entity for me",
                Description = "Short description",
                Day = DayOfWeek.Friday
            });
            
            list.Add(new SimpleEntity
            {
                Name = "Me like it",
                Description = "No no no",
                Day = DayOfWeek.Friday
            });

            return list;
        }
    }
}